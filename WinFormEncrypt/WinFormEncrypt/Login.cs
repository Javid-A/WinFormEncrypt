using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormEncrypt
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

		private void btnRegister_Click(object sender, EventArgs e)
		{
			this.Hide();
			Register register = new Register(this);
			register.Show();
		}
	}
}
