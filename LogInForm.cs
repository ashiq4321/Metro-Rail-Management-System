using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Metro_Rail_Management_System
{
    public partial class LoginForm : Form
    {
        readonly string ConnectionString = @"Data Source=DESKTOP-C18Q6RS;Initial Catalog=MetroRailManagementSystem;Integrated Security=True";

        public LoginForm()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void LinkLabeRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegistrationForm r1 = new RegistrationForm();
            r1.ShowDialog();

        }

        private void LinkLabeldetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //MessageBox.Show("Showing Metro Rail details.......");
            //this.Hide();
            DetailsForm d1 = new DetailsForm();
            d1.ShowDialog();
        }

        private void Buttonlogin_Click(object sender, EventArgs e)
        {

            if (comboBoxUserType.SelectedIndex == 0)
            {
                if (textBoxId.Text=="1" && textBoxPassword.Text=="password") {
                    MessageBox.Show("Admin Login Successful");
                    this.Hide();
                    AdminForm a1 = new AdminForm();
                    a1.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid Id or password");
                }

            }
            else if (comboBoxUserType.SelectedIndex == 1)
            {
                try
                {
                    SqlConnection con = new SqlConnection(ConnectionString);
                    SqlDataAdapter sqlData1 = new SqlDataAdapter("SELECT Count(*) from ManagerInfo where ID='" + textBoxId.Text + "'and  Password='" + textBoxPassword.Text + "'", con);
                    DataTable dt = new DataTable();
                    sqlData1.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        MessageBox.Show("Manager login succesful");
                        this.Hide();
                        ManagerForm q1= new ManagerForm(textBoxId.Text);
                        q1.ShowDialog();

                    }

                    else
                    {
                        MessageBox.Show("Invalid Id or password");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }

            }
            else if (comboBoxUserType.SelectedIndex == 2)
            {
                try
                {
                    SqlConnection con = new SqlConnection(ConnectionString);
                    SqlDataAdapter sqlData1 = new SqlDataAdapter("SELECT Count(*) from PassengerInfo where ID='" + textBoxId.Text + "'and  Password='" + textBoxPassword.Text + "'", con);
                    DataTable dt = new DataTable();
                    sqlData1.Fill(dt);
                    if(dt.Rows[0][0].ToString()=="1")
                    { 
                        MessageBox.Show("Passenger login succesful");
                        this.Hide();
                        PassengerForm p1 = new PassengerForm(textBoxId.Text, textBoxPassword.Text);
                        p1.ShowDialog();

                    }

                    else
                    {
                        MessageBox.Show("Invalid Id orpassword");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error"+ex.Message);
                }
            }
        }

               

        

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
