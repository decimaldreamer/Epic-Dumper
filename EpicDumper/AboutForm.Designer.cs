/*
 * Created by Visual Studio 2019.
 * User: 0x7fff
 * Date: 04.03.2011
 * Time: 16:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Epic_Dumper
{
	partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelAppName = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.userrank = new System.Windows.Forms.TextBox();
            this.hwid = new System.Windows.Forms.TextBox();
            this.uservariable = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.expiry = new System.Windows.Forms.TextBox();
            this.ip = new System.Windows.Forms.TextBox();
            this.lastlogin = new System.Windows.Forms.TextBox();
            this.registerdate = new System.Windows.Forms.TextBox();
            this.userid = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonClose.Location = new System.Drawing.Point(256, 252);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(113, 36);
            this.buttonClose.TabIndex = 23;
            this.buttonClose.Text = "Nigga are you trippin?";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelAppName
            // 
            this.labelAppName.AutoSize = true;
            this.labelAppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppName.Location = new System.Drawing.Point(12, 9);
            this.labelAppName.Name = "labelAppName";
            this.labelAppName.Size = new System.Drawing.Size(148, 16);
            this.labelAppName.TabIndex = 16;
            this.labelAppName.Text = "Epic Dumper | 0x7fff ";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(12, 34);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(63, 13);
            this.labelVersion.TabIndex = 17;
            this.labelVersion.Text = "Version: 0.1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.userrank);
            this.groupBox1.Controls.Add(this.hwid);
            this.groupBox1.Controls.Add(this.uservariable);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.username);
            this.groupBox1.Controls.Add(this.expiry);
            this.groupBox1.Controls.Add(this.ip);
            this.groupBox1.Controls.Add(this.lastlogin);
            this.groupBox1.Controls.Add(this.registerdate);
            this.groupBox1.Controls.Add(this.userid);
            this.groupBox1.Location = new System.Drawing.Point(13, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 163);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User and Stats";
            // 
            // userrank
            // 
            this.userrank.Location = new System.Drawing.Point(175, 123);
            this.userrank.Name = "userrank";
            this.userrank.Size = new System.Drawing.Size(164, 20);
            this.userrank.TabIndex = 9;
            // 
            // hwid
            // 
            this.hwid.Location = new System.Drawing.Point(6, 97);
            this.hwid.Name = "hwid";
            this.hwid.Size = new System.Drawing.Size(163, 20);
            this.hwid.TabIndex = 8;
            // 
            // uservariable
            // 
            this.uservariable.Location = new System.Drawing.Point(6, 123);
            this.uservariable.Name = "uservariable";
            this.uservariable.Size = new System.Drawing.Size(163, 20);
            this.uservariable.TabIndex = 7;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(6, 71);
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Size = new System.Drawing.Size(163, 20);
            this.email.TabIndex = 6;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(6, 45);
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.Size = new System.Drawing.Size(163, 20);
            this.username.TabIndex = 5;
            // 
            // expiry
            // 
            this.expiry.Location = new System.Drawing.Point(175, 19);
            this.expiry.Name = "expiry";
            this.expiry.Size = new System.Drawing.Size(164, 20);
            this.expiry.TabIndex = 4;
            // 
            // ip
            // 
            this.ip.Location = new System.Drawing.Point(175, 45);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(164, 20);
            this.ip.TabIndex = 3;
            // 
            // lastlogin
            // 
            this.lastlogin.Location = new System.Drawing.Point(175, 71);
            this.lastlogin.Name = "lastlogin";
            this.lastlogin.Size = new System.Drawing.Size(164, 20);
            this.lastlogin.TabIndex = 2;
            // 
            // registerdate
            // 
            this.registerdate.Location = new System.Drawing.Point(175, 97);
            this.registerdate.Name = "registerdate";
            this.registerdate.Size = new System.Drawing.Size(164, 20);
            this.registerdate.TabIndex = 1;
            // 
            // userid
            // 
            this.userid.Location = new System.Drawing.Point(6, 19);
            this.userid.Name = "userid";
            this.userid.ReadOnly = true;
            this.userid.Size = new System.Drawing.Size(163, 20);
            this.userid.TabIndex = 0;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 300);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelAppName);
            this.Controls.Add(this.labelVersion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutForm";
            this.Text = "Epic Dumper | AboutForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.Label labelVersion;
		private System.Windows.Forms.Label labelAppName;
		private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox hwid;
        private System.Windows.Forms.TextBox uservariable;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox expiry;
        private System.Windows.Forms.TextBox ip;
        private System.Windows.Forms.TextBox lastlogin;
        private System.Windows.Forms.TextBox registerdate;
        private System.Windows.Forms.TextBox userid;
        private System.Windows.Forms.TextBox userrank;
    }
}
