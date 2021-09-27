using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Epic_Dumper
{
    public partial class DetectAntidumps : Form
    {
        string strmodulename;
        int baseaddress;
        int modulesize;
        public int procid;

        public DetectAntidumps(int prid, string strmn, int ba, int ms)
        {
            strmodulename = strmn;
            baseaddress = ba;
            modulesize = ms;
            procid = prid;
            InitializeComponent();
        }

        [DllImport("kernel32.dll")]
        static extern IntPtr OpenProcess(UInt32 dwDesiredAccess, Int32 bInheritHandle, UInt32 dwProcessId);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool CloseHandle(IntPtr hObject);

        private const uint PROCESS_TERMINATE = 0x0001;
        private const uint PROCESS_CREATE_THREAD = 0x0002;
        private const uint PROCESS_SET_SESSIONID = 0x0004;
        private const uint PROCESS_VM_OPERATION = 0x0008;
        private const uint PROCESS_VM_READ = 0x0010;
        private const uint PROCESS_VM_WRITE = 0x0020;
        private const uint PROCESS_DUP_HANDLE = 0x0040;
        private const uint PROCESS_CREATE_PROCESS = 0x0080;
        private const uint PROCESS_SET_QUOTA = 0x0100;
        private const uint PROCESS_SET_INFORMATION = 0x0200;
        private const uint PROCESS_QUERY_INFORMATION = 0x0400;

        [StructLayout(LayoutKind.Sequential)]
        public struct SYSTEM_INFO
        {
            public uint dwOemId;
            public uint dwPageSize;
            public uint lpMinimumApplicationAddress;
            public uint lpMaximumApplicationAddress;
            public uint dwActiveProcessorMask;
            public uint dwNumberOfProcessors;
            public uint dwProcessorType;
            public uint dwAllocationGranularity;
            public uint dwProcessorLevel;
            public uint dwProcessorRevision;
        }

        [DllImport("kernel32")]
        public static extern void GetSystemInfo(ref SYSTEM_INFO pSI);

        public static MemoryBasicInformation mbi;

        [StructLayout(LayoutKind.Sequential)]
        public struct MemoryBasicInformation
        {
            public IntPtr BaseAddress;
            public IntPtr AllocationBase;
            public MemoryProtection AllocationProtect;
            public IntPtr RegionSize;
            public MemoryState State;
            public MemoryProtection Protect;
            public MemoryType Type;
        }

        [Flags]
        public enum MemoryState : uint
        {
            Commit = 0x1000,
            Decommit = 0x4000,
            Free = 0x10000,
            LargePages = 0x20000000,
            Physical = 0x400000,
            Release = 0x8000,
            Reserve = 0x2000,
            Reset = 0x80000
        }

        [Flags]
        public enum MemoryProtection : uint
        {
            AccessDenied = 0x0,
            Execute = 0x10,
            ExecuteRead = 0x20,
            ExecuteReadWrite = 0x40,
            ExecuteWriteCopy = 0x80,
            Guard = 0x100,
            NoCache = 0x200,
            WriteCombine = 0x400,
            NoAccess = 0x01,
            ReadOnly = 0x02,
            ReadWrite = 0x04,
            WriteCopy = 0x08
        }


        public enum MemoryType
        {
            Image = 0x1000000,
            Mapped = 0x40000,
            Private = 0x20000
        }


        [DllImport("kernel32.dll")]
        public static extern bool VirtualQueryEx(IntPtr hProcess,
    uint lpAddress, out MemoryBasicInformation lpBuffer,
    uint dwLength);

        [DllImport("Kernel32.dll")]
        public static extern bool ReadProcessMemory
        (
            IntPtr hProcess,
            IntPtr lpBaseAddress,
            byte[] lpBuffer,
            UInt32 nSize,
            ref UInt32 lpNumberOfBytesRead
        );

        void DetectAntidumpsShown(object sender, EventArgs e)
        {

            string buildedstring = "Finding anti-dumps on module: " + strmodulename + " address: " + baseaddress.ToString("X8") +
            " size: " + modulesize.ToString("X8") + "\r\n";

            SYSTEM_INFO pSI = new SYSTEM_INFO();
            pSI.dwPageSize = 0x1000;
            pSI.lpMaximumApplicationAddress = 0xF0000000;
            pSI.lpMinimumApplicationAddress = 0;

            try
            {
                GetSystemInfo(ref pSI);
            }
            catch
            {
            }

            uint i = 0;
            Dictionary<uint, uint> allmemory = new Dictionary<uint, uint>();
            Dictionary<uint, uint> neededmemory = new Dictionary<uint, uint>();

            uint firstaddress = 0;

            IntPtr hProcess = OpenProcess(PROCESS_CREATE_THREAD | PROCESS_QUERY_INFORMATION | PROCESS_VM_OPERATION | PROCESS_VM_WRITE | PROCESS_VM_READ | PROCESS_TERMINATE, 0, (uint)procid);

            if (hProcess != IntPtr.Zero)
            {

                while (i < pSI.lpMaximumApplicationAddress)
                {
                    if (VirtualQueryEx(hProcess, i,
                    out mbi, (uint)System.Runtime.InteropServices.Marshal.SizeOf(mbi))
                    )
                    {
                        if (firstaddress == 0) firstaddress = (uint)mbi.BaseAddress;

                        i = (uint)mbi.BaseAddress + (uint)mbi.RegionSize;
                        if (mbi.State == MemoryState.Commit)
                        {
                            if ((uint)mbi.BaseAddress < (uint)baseaddress || i > (uint)(baseaddress + modulesize))
                            {

                                if (allmemory.ContainsKey((uint)mbi.AllocationBase))
                                {
                                    uint oldmaxim = 0;
                                    allmemory.TryGetValue((uint)mbi.AllocationBase, out oldmaxim);
                                    uint newmaxim = 0;
                                    if (oldmaxim > i) newmaxim = oldmaxim;
                                    else newmaxim = i;

                                    allmemory.Remove((uint)mbi.AllocationBase);
                                    allmemory.Add((uint)mbi.AllocationBase, newmaxim);

                                }
                                else
                                {
                                    allmemory.Add((uint)mbi.AllocationBase, i);
                                }
                            }
                        }
                    }
                }
                bool isok;
                byte[] onepage = new byte[pSI.dwPageSize];
                uint BytesRead = 0;
                byte[] infokeep = new byte[8];

                isok = ReadProcessMemory(hProcess, (IntPtr)baseaddress, onepage, (uint)onepage.Length, ref BytesRead);
                if (isok)
                {
                    if (ReadProcessMemory(hProcess, (IntPtr)(baseaddress + 0x03C), infokeep, 4, ref BytesRead))
                    {
                        int PEOffset = BitConverter.ToInt32(infokeep, 0);
                        if (PEOffset > 0 && (PEOffset + 0x0120) < onepage.Length)
                        {
                            if (ReadProcessMemory(hProcess, (IntPtr)(baseaddress + PEOffset), infokeep, 2, ref BytesRead))
                            {
                                int nrofsection = (int)BitConverter.ToInt16(onepage, PEOffset + 0x06);
                                if (nrofsection > 0)
                                {

                                    int virtualsize = BitConverter.ToInt32(onepage, PEOffset + 0x0F8 + 0x28 * 0 + 08);
                                    int virtualAddress = BitConverter.ToInt32(onepage, PEOffset + 0x0F8 + 0x28 * 0 + 012);
                                    byte[] firstsection = new byte[virtualsize];

                                    if (ReadProcessMemory(hProcess, (IntPtr)(baseaddress + virtualAddress),
                                      firstsection, (uint)firstsection.Length, ref BytesRead))
                                    {
                                        for (int j = 0; j < firstsection.Length - 6; j++)
                                        {




                                        }

                                        textBox1.Text = buildedstring;
                                    }


                                }
                            }
                        }
                    }
                }

            }

        }
    }
}
