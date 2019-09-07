using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metro_Rail_Management_System
{
    public partial class RegistrationForm : Form
    {
        public bool ValidatePassword(string password)
        {
            string patternPassword = @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{4,8}$";
            if (!string.IsNullOrEmpty(password))
            {
                if (!Regex.IsMatch(password, patternPassword))
                {
                    return false;
                }

            }
            return true;
        }
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidatePassword(textBoxPassword.Text))
                {

                    string type = Convert.ToString(this.comboBox1.SelectedItem);
                    string MyConnection2 = "Data Source=DESKTOP-C18Q6RS;Initial Catalog=MetroRailManagementSystem;Integrated Security=True";
                    SqlConnection MyConn2 = new SqlConnection(MyConnection2);
                    string Query = "insert into ApplicationInfo (ID,Name,Age,[User Type],Address,[Phone No],Email,Password) values('" + this.textBoxId.Text + "','" + this.textBoxName.Text + "','" + this.textBoxage.Text + "','" + type + "','" + this.textBoxAddress.Text + "','" + this.textBoxPhone.Text + "','" + this.textBoxMail.Text + "','" + this.textBoxPassword.Text + "');";
                    SqlCommand MyCommand2 = new SqlCommand(Query, MyConn2);
                    SqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    MessageBox.Show("Application Successful");
                    MyConn2.Close();
                    this.Hide();
                    LoginForm lg = new LoginForm();
                    lg.ShowDialog();
                }
                else
                {
                    MessageBox.Show(" Password must be at least 4 characters, no more than 8 characters, and must include at least one upper case letter, one lower case letter, and one numeric digit.");
                    this.textBoxPassword.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Labelage_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxId_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                MessageBox.Show("Invalid key.");
                e.Handled = true;

            }
        }

        private void TextBoxage_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                MessageBox.Show("Invalid Key");
                e.Handled = true;

            }
        }

        private void TextBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
