/*
 * Created by Visual Studio 2019.
 * User: 0x7fff
 * Date: 03.03.2011
 * Time: 21:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Epic_Dumper
{
	partial class HeapView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeapView));
            this.lvheaps = new System.Windows.Forms.ListView();
            this.address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.blocksize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flags = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvheaps
            // 
            this.lvheaps.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lvheaps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvheaps.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.address,
            this.blocksize,
            this.flags});
            this.lvheaps.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lvheaps.FullRowSelect = true;
            this.lvheaps.HideSelection = false;
            this.lvheaps.Location = new System.Drawing.Point(-1, 0);
            this.lvheaps.MultiSelect = false;
            this.lvheaps.Name = "lvheaps";
            this.lvheaps.Size = new System.Drawing.Size(390, 373);
            this.lvheaps.TabIndex = 11;
            this.lvheaps.UseCompatibleStateImageBehavior = false;
            this.lvheaps.View = System.Windows.Forms.View.Details;
            // 
            // address
            // 
            this.address.Text = "Address";
            this.address.Width = 105;
            // 
            // blocksize
            // 
            this.blocksize.Text = "BlockSize";
            this.blocksize.Width = 124;
            // 
            // flags
            // 
            this.flags.Text = "Flags";
            this.flags.Width = 143;
            // 
            // HeapView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 373);
            this.Controls.Add(this.lvheaps);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HeapView";
            this.Text = "Epic Dumper | HeapView";
            this.Shown += new System.EventHandler(this.HeapViewShown);
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.ColumnHeader flags;
		private System.Windows.Forms.ColumnHeader address;
		private System.Windows.Forms.ColumnHeader blocksize;
		private System.Windows.Forms.ListView lvheaps;
	}
}
