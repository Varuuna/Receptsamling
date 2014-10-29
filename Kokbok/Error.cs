﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kokbok
{
	public partial class Error : Form
	{
		public Error()
		{
			InitializeComponent();
		}

		public void ErrorMsg(string err)
		{
			ErrorLabel.Text = err;
		}

		private void OKButton_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
