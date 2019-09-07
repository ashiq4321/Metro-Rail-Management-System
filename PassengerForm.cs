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


    public partial class PassengerForm : Form
    {
        double count1, count2;

        readonly string ConnectionString = @"Data Source=DESKTOP-C18Q6RS;Initial Catalog=MetroRailManagementSystem;Integrated Security=True";

        public PassengerForm(String id, string pass)
        {
            InitializeComponent();
            textBoxID.Text = id;
            textBoxpass.Text = pass;

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT Name  from PassengerInfo where ID='" + id + "'";
                Name = cmd.ExecuteNonQuery().ToString();
                textBoxName.Text = Name.ToString();
                con.Close();
            }


            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT Balance  from PassengerInfo where ID='" + id + "'";
                Name = cmd.ExecuteNonQuery().ToString();
                textBoxBl.Text = Name.ToString();
                con.Close();
            }
            panelBlank.BringToFront();
        }

        private void PassengerForm_Load(object sender, EventArgs e)
        {

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ButtonRailDetails_Click(object sender, EventArgs e)
        {

        }

        private void LinkLabeldetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DetailsForm d1 = new DetailsForm();
            d1.ShowDialog();
        }

        private void PanelMe_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LabelB_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxB_TextChanged(object sender, EventArgs e)
        {

        }

        private void LabelE_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TextBoxName_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string Sqlselectquery = "SELECT * from PassengerInfo where ID=" + int.Parse(textBoxID.Text);
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

        private void TextBoxBl_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            string Sqlselectquery = "SELECT * from PassengerInfo where ID=" + int.Parse(textBoxID.Text);
            SqlCommand cd = new SqlCommand(Sqlselectquery, conn);
            SqlDataReader sdr = cd.ExecuteReader();
            if (sdr.Read())
            {
                textBoxBl.Text = sdr["Balance"].ToString();
            }
            else
            {

            }
            conn.Close();

        }


        private void ButtonMe_Click(object sender, EventArgs e)
        {
            panelBlank.SendToBack();
            panelRecharge.SendToBack();
            buttonRec.Visible = false;
            button2.Visible = false;
            panelMe.BringToFront();
            buttonE.Visible = true;


            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                string Sqlselectquery = "SELECT * from PassengerInfo where ID='" + int.Parse(textBoxID.Text)+"'";
                SqlCommand cmd = new SqlCommand(Sqlselectquery, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBoxN.Text = (dr["Name"].ToString());
                    textBoxI.Text = (dr["ID"].ToString());
                    textBoxAge.Text = (dr["Age"].ToString());
                    textBoxA.Text = (dr["Address"].ToString());
                    textBoxp.Text = (dr["Phone No"].ToString());
                    textBoxEmail.Text = (dr["Email"].ToString());
                    textBoxPassword.Text = (dr["Password"].ToString());
                    textBoxB.Text = (dr["Balance"].ToString());
                }

                con.Close();

            }
        }

        private void LabelA_Click(object sender, EventArgs e)
        {

        }

        private void ButtonBack2_Click(object sender, EventArgs e)
        {

            panelMe.SendToBack();

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void TextBoxN_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void ButtonE_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to Update?", "Edit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {

                SqlConnection con = new SqlConnection(ConnectionString);

                string query = "UPDATE PassengerInfo set Name='" + this.textBoxN.Text + "',Age='" + this.textBoxAge.Text + "',Address='" + this.textBoxA.Text + "',[Phone No]='" + this.textBoxp.Text + "',Email='" + this.textBoxEmail.Text + "',Password='" + textBoxPassword.Text + "'where ID='" + this.textBoxI.Text + "';";
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

        private void TextBoxA_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxI_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxp_TextChanged(object sender, EventArgs e)
        {

        }

        private void PassengerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to close?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void LabelName_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();
                string Sqlselectquery = "SELECT Name,Balance from PassengerInfo where ID='" + int.Parse(textBoxID.Text) + "'";
                SqlCommand cd = new SqlCommand(Sqlselectquery, conn);
                SqlDataReader sdr = cd.ExecuteReader();
                if (sdr.Read())
                {
                    textBoxBl.Text = sdr["Balance"].ToString();
                    textBoxName.Text = sdr["Name"].ToString();
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

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void ButtonAddB_Click(object sender, EventArgs e)
        {
            panelBlank.SendToBack();
          
            buttonRec.Visible = true;
            panelMe.SendToBack();
            panelRecharge.BringToFront();
            buttonE.Visible = false;
            


            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                string Sqlselectquery = "SELECT * from PassengerInfo where ID=" + int.Parse(textBoxID.Text);
                SqlCommand cmd = new SqlCommand(Sqlselectquery, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBoxN2.Text = (dr["Name"].ToString());
                    textBoxI2.Text = (dr["ID"].ToString());
                    textBoxB2.Text = (dr["Balance"].ToString());

                }

                con.Close();

            }
        }

        private void ButtonRec_Click(object sender, EventArgs e)
        {
            if (textBoxAR.Text.ToString() == "")
            {
                MessageBox.Show("Please give the amount first.");
            }
            else
            {
                float b1 = float.Parse(textBoxAR.Text);
                float b2 = float.Parse(textBoxB2.Text);
                float b3 = b1 + b2;

                SqlConnection con = new SqlConnection(ConnectionString);

                string query = "UPDATE PassengerInfo set Balance='" + b3 + "'where ID='" + this.textBoxI2.Text + "';";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader myreader;
                try
                {
                    con.Open();
                    myreader = cmd.ExecuteReader();


                    MessageBox.Show("Recharged");
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
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            string Sqlselectquery = "SELECT * from PassengerInfo where ID=" + int.Parse(textBoxI2.Text);
            SqlCommand cd = new SqlCommand(Sqlselectquery, conn);
            SqlDataReader sdr = cd.ExecuteReader();
            if (sdr.Read())
            {
                textBoxB2.Text = sdr["Balance"].ToString();
            }
            else
            {

            }
            conn.Close();
        }

        private void TextBoxAR_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                MessageBox.Show("Invalid Key");
                e.Handled = true;

            }

        }

        private void TextBoxAR_TextChanged(object sender, EventArgs e)
        {

        }

        private void PanelBlank_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {

            DialogResult dialog = MessageBox.Show("Do you really want to Exit?", "Exiting the Window ", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();
                LoginForm fm = new LoginForm();
                fm.ShowDialog();
            }
        }

        private void TextBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxI_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                MessageBox.Show("Invalid Key");
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

        private void TextBoxN_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void TextBoxN_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonCost_Click(object sender, EventArgs e)
        {
            if (comboBoxNo.Text == "" || comboBoxDes.Text == "" || comboBoxSource.Text == "")
            {
                MessageBox.Show("You must fillup the boxes");

            }
            else
            {

                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();
                string Sqlselectquery = "SELECT * from PassengerInfo where ID=" + int.Parse(textBoxID.Text);
                SqlCommand cd = new SqlCommand(Sqlselectquery, conn);
                SqlDataReader sdr = cd.ExecuteReader();
                if (sdr.Read())
                {
                    textBoxBl.Text = sdr["Balance"].ToString();
                }
                else
                {

                }
                conn.Close();






                string no = comboBoxNo.SelectedItem.ToString();
                string a = comboBoxSource.SelectedItem.ToString();
                string b = comboBoxDes.SelectedItem.ToString();

                if (a == "Uttara-North")
                {

                    count1 = 1.0;

                }
                if (a == "Uttara-Center")
                {
                    count1 = 1.5;

                }
                if (a == "Uttara-South")
                {
                    count1 = 2;

                }
                if (a == "Pallabi")
                {
                    count1 = 3;


                }
                if (a == "Mirpur11")
                {
                    count1 = 3.5;


                }
                if (a == "Mirpur10")
                {
                    count1 = 4;

                }
                if (a == "Kazipara")
                {
                    count1 = 4.5;

                }
                if (a == "Shawrapara")
                {
                    count1 = 5;

                }
                if (a == "Agargaon")
                {
                    count1 = 5.5;

                }
                if (a == "Bijoy-Sarani")
                {
                    count1 = 6;

                }
                if (a == "Farmgate")
                {
                    count1 = 6.5;

                }
                if (a == "Karwan-Bazar")
                {
                    count1 = 7;


                }
                if (a == "Shahbagh")
                {
                    count1 = 7.5;

                }
                if (a == "Dhaka-University")
                {
                    count1 = 8;

                }
                if (a == "Bangladesh Secretariat")
                {
                    count1 = 8.5;

                }
                if (a == "Motijheel")
                {
                    count1 = 9;

                }
                if (b == "Uttara-North")
                {
                    count2 = 1;

                }
                if (b == "Uttara-Center")
                {

                    count2 = 1.5;

                }
                if (b == "Uttara-South")
                {

                    count2 = 2;

                }
                if (b == "Pallabi")
                {

                    count2 = 3;

                }
                if (b == "Mirpur11")
                {

                    count2 = 3.5;

                }
                if (b == "Mirpur10")
                {

                    count2 = 4;

                }
                if (b == "Kazipara")
                {

                    count2 = 4.5;

                }
                if (b == "Shawrapara")
                {

                    count2 = 5;

                }
                if (b == "Agargaon")
                {

                    count2 = 5.5;

                }
                if (b == "Bijoy-Sarani")
                {

                    count2 = 6;

                }
                if (b == "Farmgate")
                {

                    count2 = 6.5;
                }
                if (b == "Karwan-Bazar")
                {

                    count2 = 7;

                }
                if (b == "Shahbagh")
                {

                    count2 = 7.5;

                }
                if (b == "Dhaka-University")
                {

                    count2 = 8;

                }
                if (b == "Bangladesh Secretariat")
                {

                    count2 = 8.5;

                }
                if (b == "Motijheel")
                {

                    count2 = 9;

                }
                double cost, c;
                c = Math.Abs(count1 - count2);
                cost = c * 5;
                MessageBox.Show(no + ": Cost from " + a + " to " + b + "is: " + cost + "tk");



                DialogResult dialog = MessageBox.Show("Do you want to buy tickets?", "", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    if (cost > double.Parse(textBoxBl.Text))
                    {
                        MessageBox.Show("You have insufficient balannce. Please Recharge.");

                    }
                    else
                    {

                        double balance = double.Parse(s: textBoxBl.Text);
                        double CB;
                        CB = balance - cost;
                        MessageBox.Show("balance" + CB);
                        SqlConnection con = new SqlConnection(ConnectionString);

                        string query = "UPDATE PassengerInfo set Balance='" + CB + "'where ID='" + this.textBoxID.Text + "';";
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

                }
            }
        }
    }
}

