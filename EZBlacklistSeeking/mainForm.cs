using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EZBlacklistSeeking
{
	public partial class mainForm : Form
	{
		public mainForm()
		{
			InitializeComponent();
		}
		public string QQGroup(string GroupNum)
		{
			string tmp;
			tmp = GroupNum.Substring(4, 2);
			GroupNum = GroupNum.Replace(tmp, "**");
			return GroupNum;
		}
		private void btnSearch_Click(object sender, EventArgs e)
		{

			WebBrowser ljyys = new WebBrowser();
			ljyys.Navigate("https://www.mcbbs.net/thread-803451-1-1.html");
			ljyys.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(web_DocumentCompleted);
			void web_DocumentCompleted(object websender, WebBrowserDocumentCompletedEventArgs webe)
			{
				HtmlElementCollection ElementCollection = ljyys.Document.GetElementsByTagName("Table");
				if (File.Exists("cache"))
				{
					File.Delete("cache");
				}
				foreach (HtmlElement item in ElementCollection)
				{
					File.AppendAllText("cache", item.InnerText);
				}
				string BlackList = File.ReadAllText("cache");
				int iStartPos = BlackList.IndexOf("名称");
				BlackList = BlackList.Substring(iStartPos);
				int iEndPos = BlackList.IndexOf("参与人数");
				BlackList = BlackList.Remove(iEndPos);
				if(radbtnQQGroup.Checked==true)
				{
					string groupNum = QQGroup(txtbxSearch.Text);
					if(BlackList.Contains(groupNum))
					{
						MessageBox.Show("抱歉，根据QQ群号，您所在的服务器可能失信，请去MCBBS失信黑名单列表查看详情!");
					}
					else
					{
						MessageBox.Show("恭喜，根据QQ群号，您的服务器未被列入黑名单！");
					}
				}
				else
				{
					if(BlackList.Contains(txtbxSearch.Text))
					{
						MessageBox.Show("抱歉，根据服主ID或服务器名称，您所在的服务器可能失信，请去MCBBS失信黑名单列表查看详情!");
					}
					else
					{
						MessageBox.Show("恭喜，根据服主ID或服务器名称，您的服务器未被列入黑名单！");
					}
				}
			}

		}

		private void mainForm_Load(object sender, EventArgs e)
		{
			radbtnServerOwnerID.Checked = true;
		}

		private void btnGoToNiTan_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.mcbbs.net/thread-803451-1-1.html");
		}

		private void btnAbout_Click(object sender, EventArgs e)
		{
			formAbout frmAbout = new formAbout();
			frmAbout.Show();
		}
	}
}
