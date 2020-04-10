namespace EZBlacklistSeeking
{
	partial class mainForm
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
			this.txtbxSearch = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.labelPrompt = new System.Windows.Forms.Label();
			this.radbtnServerOwnerID = new System.Windows.Forms.RadioButton();
			this.radbtnQQGroup = new System.Windows.Forms.RadioButton();
			this.btnGoToNiTan = new System.Windows.Forms.Button();
			this.btnAbout = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtbxSearch
			// 
			this.txtbxSearch.Location = new System.Drawing.Point(159, 28);
			this.txtbxSearch.Name = "txtbxSearch";
			this.txtbxSearch.Size = new System.Drawing.Size(222, 21);
			this.txtbxSearch.TabIndex = 0;
			// 
			// btnSearch
			// 
			this.btnSearch.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnSearch.Location = new System.Drawing.Point(17, 91);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(372, 157);
			this.btnSearch.TabIndex = 1;
			this.btnSearch.Text = "点我查找";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// labelPrompt
			// 
			this.labelPrompt.AutoSize = true;
			this.labelPrompt.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.labelPrompt.Location = new System.Drawing.Point(12, 24);
			this.labelPrompt.Name = "labelPrompt";
			this.labelPrompt.Size = new System.Drawing.Size(141, 25);
			this.labelPrompt.TabIndex = 2;
			this.labelPrompt.Text = "要查询的信息...";
			// 
			// radbtnServerOwnerID
			// 
			this.radbtnServerOwnerID.AutoSize = true;
			this.radbtnServerOwnerID.Location = new System.Drawing.Point(17, 69);
			this.radbtnServerOwnerID.Name = "radbtnServerOwnerID";
			this.radbtnServerOwnerID.Size = new System.Drawing.Size(209, 16);
			this.radbtnServerOwnerID.TabIndex = 3;
			this.radbtnServerOwnerID.TabStop = true;
			this.radbtnServerOwnerID.Text = "查询MCBBS用户名/服务器名称/网站";
			this.radbtnServerOwnerID.UseVisualStyleBackColor = true;
			// 
			// radbtnQQGroup
			// 
			this.radbtnQQGroup.AutoSize = true;
			this.radbtnQQGroup.Location = new System.Drawing.Point(232, 69);
			this.radbtnQQGroup.Name = "radbtnQQGroup";
			this.radbtnQQGroup.Size = new System.Drawing.Size(149, 16);
			this.radbtnQQGroup.TabIndex = 3;
			this.radbtnQQGroup.TabStop = true;
			this.radbtnQQGroup.Text = "查询服务器QQ群/服主QQ";
			this.radbtnQQGroup.UseVisualStyleBackColor = true;
			// 
			// btnGoToNiTan
			// 
			this.btnGoToNiTan.Location = new System.Drawing.Point(17, 254);
			this.btnGoToNiTan.Name = "btnGoToNiTan";
			this.btnGoToNiTan.Size = new System.Drawing.Size(262, 23);
			this.btnGoToNiTan.TabIndex = 4;
			this.btnGoToNiTan.Text = "带我去MCBBS的失信黑名单！";
			this.btnGoToNiTan.UseVisualStyleBackColor = true;
			this.btnGoToNiTan.Click += new System.EventHandler(this.btnGoToNiTan_Click);
			// 
			// btnAbout
			// 
			this.btnAbout.Location = new System.Drawing.Point(285, 254);
			this.btnAbout.Name = "btnAbout";
			this.btnAbout.Size = new System.Drawing.Size(104, 23);
			this.btnAbout.TabIndex = 5;
			this.btnAbout.Text = "关于...";
			this.btnAbout.UseVisualStyleBackColor = true;
			this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
			// 
			// mainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(401, 289);
			this.Controls.Add(this.btnAbout);
			this.Controls.Add(this.btnGoToNiTan);
			this.Controls.Add(this.radbtnQQGroup);
			this.Controls.Add(this.radbtnServerOwnerID);
			this.Controls.Add(this.labelPrompt);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.txtbxSearch);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "mainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "快捷查询服务器失信人员";
			this.Load += new System.EventHandler(this.mainForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtbxSearch;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Label labelPrompt;
		private System.Windows.Forms.RadioButton radbtnServerOwnerID;
		private System.Windows.Forms.RadioButton radbtnQQGroup;
		private System.Windows.Forms.Button btnGoToNiTan;
		private System.Windows.Forms.Button btnAbout;
	}
}

