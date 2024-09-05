using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace loginsystem
{
	public partial class register_form : Form
	{
		SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tyler\OneDrive\Documents\loginsystem.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");
		public register_form()
		{
			InitializeComponent();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void close_register_button_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void login_button_reg_Click(object sender, EventArgs e)
		{
			Form1 login = new Form1();
			login.Show();
			this.Hide();
		}

		private void password_checkbox_reg_CheckedChanged(object sender, EventArgs e)
		{
			password_textbox_reg.PasswordChar = password_checkbox_reg.Checked ? '\0' : '*';
		}

		private void register_button_Click(object sender, EventArgs e)
		{
			if(username_textbox_reg.Text == "" || password_textbox_reg.Text == "")
			{
				MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
            else
            {
				if(connect.State != ConnectionState.Open)
				{
					try
					{
						connect.Open();

						string selectUsername = "SELECT COUNT(id) FROM users WHERE username = @user";

						using (SqlCommand checkUser = new SqlCommand(selectUsername, connect))
						{
							checkUser.Parameters.AddWithValue("@user", username_textbox_reg.Text.Trim());
							int count = (int)checkUser.ExecuteScalar();
						
							if(count >= 1)
							{
								MessageBox.Show("The username " + username_textbox_reg.Text.Trim() + " is already taken.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
							else
							{
								DateTime today = DateTime.Today;

								string insertData = "INSERT INTO users " + "(username, password, date_register) VALUES(@username, @password, @date_Reg)";

								using (SqlCommand cmd = new SqlCommand(insertData, connect))
								{
									cmd.Parameters.AddWithValue("@username", username_textbox_reg.Text.Trim());
									cmd.Parameters.AddWithValue("@password", password_textbox_reg.Text.Trim());
									cmd.Parameters.AddWithValue("@dateReg", today);

									cmd.ExecuteNonQuery();

									MessageBox.Show("Registered Account", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

									Form1 loginForm = new Form1();
									loginForm.Show();
									this.Hide();

								}
							}
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

					}
					finally
					{
						connect.Close();
					}
				}

            }
        }
	}
}
