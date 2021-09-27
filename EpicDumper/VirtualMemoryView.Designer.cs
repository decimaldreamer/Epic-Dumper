/*
 * Created by Visual Studio 2019.
 * User: 0x7fff
 * Date: 25.09.2021
 * Time: 00:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Epic_Dumper
{
	partial class VirtualMemoryView
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VirtualMemoryView));
            this.lvvirtualmem = new System.Windows.Forms.ListView();
            this.alocbase = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ba = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prot = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ressize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.state = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.additional = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvvirtualmem
            // 
            this.lvvirtualmem.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lvvirtualmem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvvirtualmem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.alocbase,
            this.ap,
            this.ba,
            this.prot,
            this.ressize,
            this.state,
            this.type,
            this.additional});
            this.lvvirtualmem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lvvirtualmem.FullRowSelect = true;
            this.lvvirtualmem.HideSelection = false;
            this.lvvirtualmem.Location = new System.Drawing.Point(-1, 0);
            this.lvvirtualmem.MultiSelect = false;
            this.lvvirtualmem.Name = "lvvirtualmem";
            this.lvvirtualmem.Size = new System.Drawing.Size(876, 338);
            this.lvvirtualmem.TabIndex = 10;
            this.lvvirtualmem.UseCompatibleStateImageBehavior = false;
            this.lvvirtualmem.View = System.Windows.Forms.View.Details;
            // 
            // alocbase
            // 
            this.alocbase.Text = "AllocationBase";
            this.alocbase.Width = 105;
            // 
            // ap
            // 
            this.ap.Text = "AllocationProtect";
            this.ap.Width = 106;
            // 
            // ba
            // 
            this.ba.Text = "BaseAddress";
            this.ba.Width = 83;
            // 
            // prot
            // 
            this.prot.Text = "Protect";
            this.prot.Width = 88;
            // 
            // ressize
            // 
            this.ressize.Text = "RegionSize";
            this.ressize.Width = 82;
            // 
            // state
            // 
            this.state.Text = "State";
            // 
            // type
            // 
            this.type.Text = "Type";
            // 
            // additional
            // 
            this.additional.Text = "Additional";
            this.additional.Width = 198;
            // 
            // VirtualMemoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 336);
            this.Controls.Add(this.lvvirtualmem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VirtualMemoryView";
            this.Text = "Epic Dumper | VirtualMemoryView";
            this.Shown += new System.EventHandler(this.VirtualMemoryViewShown);
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.ColumnHeader additional;
		private System.Windows.Forms.ColumnHeader alocbase;
		private System.Windows.Forms.ColumnHeader ap;
		private System.Windows.Forms.ColumnHeader prot;
		private System.Windows.Forms.ColumnHeader type;
		private System.Windows.Forms.ColumnHeader state;
		private System.Windows.Forms.ColumnHeader ressize;
		private System.Windows.Forms.ColumnHeader ba;
		private System.Windows.Forms.ListView lvvirtualmem;
	}
}
