using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
    
namespace Thrifting_Treasures
{
    public partial class frmRegister : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        
        public frmRegister()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtComPassword.Text)
            {
                MessageBox.Show("Password doesn't match!", "Error");
                return;
            }

            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtComPassword.Text))
            {
                MessageBox.Show("Please fill out all information!", "Error");
                return;
            }

            else
            {
                connection.Open();

                MySqlCommand cmd1 = new MySqlCommand("SELECT Username FROM loginform.userinfo WHERE Username = @Username And Password = @Password", connection);
               // cmd2 = new MySqlCommand("SELECT  FROM loginform.userinfo WHERE Password = @Password", connection);

                bool userExists = false, mailExists = false;

                if (!(userExists || mailExists))
                {

                    string iquery = "INSERT INTO loginform.userinfo (`Username`, `Password`, `ComPassword`) VALUES (@Username, @Password, @ComPassword)";
                    MySqlCommand commandDatabase = new MySqlCommand(iquery, connection);
                    commandDatabase.Parameters.AddWithValue("@Username", txtUsername.Text);
                    commandDatabase.Parameters.AddWithValue("@Password", txtPassword.Text);
                    commandDatabase.Parameters.AddWithValue("@ComPassword", txtComPassword.Text);

                    try
                    {
                        commandDatabase.ExecuteNonQuery();
                        MessageBox.Show("Account Successfully Created!");
                    } 
                    catch (Exception ex)
                    {
                        // Show any error message.
                        MessageBox.Show(ex.Message);
                    }

                   // MessageBox.Show("Account Successfully Created!");

                }

                connection.Close();
            }
        }

        private void checkbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPas.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtComPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
                txtComPassword.PasswordChar = '•';
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmlogin frm1 = new frmlogin();
            frm1.ShowDialog();
        }
    }
}