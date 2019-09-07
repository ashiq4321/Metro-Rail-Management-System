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
    public partial class ManagerForm : Form
    {
        readonly string ConnectionString = @"Data Source=DESKTOP-C18Q6RS;Initial Catalog=MetroRailManagementSystem;Integrated Security=True";
        public ManagerForm(string id)
        {

            
            InitializeComponent();
            textBoxID.Text = id;

            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string Sqlselectquery = "SELECT * from ManagerInfo where ID=" + int.Parse(textBoxID.Text);
            SqlCommand cmd = new SqlCommand(Sqlselectquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBoxName.Text = (dr["Name"].ToString());
                textBox1.Text = (dr["Assigned Rail"].ToString());
            }
            else
            {

            }
            con.Close();
        }

        private void LinkLabeldetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DetailsForm d1 = new DetailsForm();
            d1.ShowDialog();
        }

        private void LabelN_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxName_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string Sqlselectquery = "SELECT * from ManagerInfo where ID=" + int.Parse(textBoxID.Text);
            SqlCommand cmd = new SqlCommand(Sqlselectquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBoxName.Text = (dr["Name"].ToString());
            }
            else
            {

            }
            con.Close();
        }

        private void ButtonMe_Click(object sender, EventArgs e)
        {
            //buttonSubmit.Visible = false;
            panel1.BringToFront();
            buttonMe.Visible = true;


            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                string Sqlselectquery = "SELECT * from ManagerInfo where ID=" + int.Parse(textBoxID.Text);
                SqlCommand cmd = new SqlCommand(Sqlselectquery, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBoxN.Text = (dr["Name"].ToString());
                    label4.Text = (dr["ID"].ToString());
                    textBoxAge.Text = (dr["Age"].ToString());
                    textBoxAdd.Text = (dr["Address"].ToString());
                    textBoxP.Text = (dr["Phone No"].ToString());
                    textBoxE.Text = (dr["Email"].ToString());
                    textBoxPass.Text = (dr["Password"].ToString());
                    label3.Text = (dr["Assigned Rail"].ToString());
                }

                con.Close();

            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string Sqlselectquery = "SELECT * from ManagerInfo where ID=" + int.Parse(textBoxID.Text);
            SqlCommand cmd = new SqlCommand(Sqlselectquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBoxName.Text = (dr["Name"].ToString());
            }
            else
            {

            }
            con.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to Update?", "Edit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {

                SqlConnection con = new SqlConnection(ConnectionString);

                string query = "UPDATE ManagerInfo set Name='" + this.textBoxN.Text + "',Age='" + this.textBoxAge.Text + "',Address='" + this.textBoxAdd.Text + "',[Phone No]='" + this.textBoxP.Text + "',Email='" + this.textBoxE.Text + "',Password='" + textBoxPass.Text + "'where ID='" + this.label4.Text + "';";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader myreader;
                try
                {
                    con.Open();
                    myreader = cmd.ExecuteReader();


                    MessageBox.Show("Updated");
                    while (myreader.Read())
                    {

                    }
                    con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (dialog == DialogResult.No)
            {

            }
        }

        private void TextBoxI_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TextBoxI_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                MessageBox.Show("Invalid key.");
                e.Handled = true;

            }
        }

        private void TextBoxAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                MessageBox.Show("Invalid Key");
                e.Handled = true;

            }
        }

        private void TextBoxN_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TextBoxN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void TextBoxAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxP_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || comboBoxSource.Text == "" || comboBoxNext.Text == "")
            {
                MessageBox.Show("You must enter values");
            }
            else
            {

                try
                {
                    SqlConnection con = new SqlConnection(ConnectionString);
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE RailInfo set [Current Location] = '" + this.comboBoxSource.SelectedItem.ToString()+ "',[Next Location]='" + this.comboBoxNext.SelectedItem.ToString()+"'where ID='" + this.textBox1.Text+ "';";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Added successfully");
                    con.Close();

                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("invalid of Id or Assign Manager");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to Exit?", "Exiting the Window ", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();
                LoginForm fm = new LoginForm();
                fm.ShowDialog();
            }
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@ConnectionString);
                conn.Open();
                string Sqlselectquery = "SELECT Name from ManagerInfo where ID='" + int.Parse(textBoxID.Text) + "'";
                SqlCommand cd = new SqlCommand(Sqlselectquery, conn);
                SqlDataReader sdr = cd.ExecuteReader();
                if (sdr.Read())
                {
                    textBoxName.Text = sdr["Name"].ToString();
                    //textBox1.Text = sdr["[Assigned Rail]"].ToString();
                    
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
