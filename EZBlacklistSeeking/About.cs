using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EZBlacklistSeeking
{
	public partial class formAbout : Form
	{
		public formAbout()
		{
			InitializeComponent();
		}

		private void labelAuthor_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.mcbbs.net/?1698727");
		}
	}
}
