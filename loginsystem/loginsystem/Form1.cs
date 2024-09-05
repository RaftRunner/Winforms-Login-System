using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginsystem
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void close_login_button_Click(object sender, EventArgs e)
		{
			Application.Exit();

		}

		private void password_textbox_TextChanged(object sender, EventArgs e)
		{

		}

		private void login_button_Click(object sender, EventArgs e)
		{

		}

		private void register_button_on_login_page_Click(object sender, EventArgs e)
		{
			register_form regForm = new register_form();
			regForm.Show();
			this.Hide(); 
		}

		private void password_checkbox_CheckedChanged(object sender, EventArgs e)
		{
			password_textbox.PasswordChar = password_checkbox.Checked ? '\0' : '*';
		}
	}
}
