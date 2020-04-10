namespace EZBlacklistSeeking
{
	partial class formAbout
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAbout));
			this.labelVer = new System.Windows.Forms.Label();
			this.labelAuthor = new System.Windows.Forms.Label();
			this.labelCopyRight = new System.Windows.Forms.Label();
			this.labelGoToMCBBS = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelVer
			// 
			this.labelVer.AutoSize = true;
			this.labelVer.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.labelVer.Location = new System.Drawing.Point(24, 20);
			this.labelVer.Name = "labelVer";
			this.labelVer.Size = new System.Drawing.Size(249, 27);
			this.labelVer.TabIndex = 0;
			this.labelVer.Text = "EZBlacklistSeeking v1.0.2";
			// 
			// labelAuthor
			// 
			this.labelAuthor.AutoSize = true;
			this.labelAuthor.Cursor = System.Windows.Forms.Cursors.Hand;
			this.labelAuthor.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.labelAuthor.Location = new System.Drawing.Point(50, 55);
			this.labelAuthor.Name = "labelAuthor";
			this.labelAuthor.Size = new System.Drawing.Size(180, 22);
			this.labelAuthor.TabIndex = 1;
			this.labelAuthor.Text = "作者:MCBBS @SHZLP";
			this.labelAuthor.Click += new System.EventHandler(this.labelAuthor_Click);
			// 
			// labelCopyRight
			// 
			this.labelCopyRight.AutoSize = true;
			this.labelCopyRight.Location = new System.Drawing.Point(3, 90);
			this.labelCopyRight.Name = "labelCopyRight";
			this.labelCopyRight.Size = new System.Drawing.Size(293, 12);
			this.labelCopyRight.TabIndex = 2;
			this.labelCopyRight.Text = "本程序仅于MCBBS发布,允许说明来源的情况下自由转载";
			// 
			// labelGoToMCBBS
			// 
			this.labelGoToMCBBS.AutoSize = true;
			this.labelGoToMCBBS.Location = new System.Drawing.Point(29, 93);
			this.labelGoToMCBBS.Name = "labelGoToMCBBS";
			this.labelGoToMCBBS.Size = new System.Drawing.Size(0, 12);
			this.labelGoToMCBBS.TabIndex = 3;
			// 
			// formAbout
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(304, 114);
			this.Controls.Add(this.labelGoToMCBBS);
			this.Controls.Add(this.labelCopyRight);
			this.Controls.Add(this.labelAuthor);
			this.Controls.Add(this.labelVer);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "formAbout";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "关于...";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelVer;
		private System.Windows.Forms.Label labelAuthor;
		private System.Windows.Forms.Label labelCopyRight;
		private System.Windows.Forms.Label labelGoToMCBBS;
	}
}