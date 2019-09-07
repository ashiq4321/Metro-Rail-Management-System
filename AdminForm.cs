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
    public partial class AdminForm : Form
    {
        readonly string ConnectionString = @"Data Source=DESKTOP-C18Q6RS;Initial Catalog=MetroRailManagementSystem;Integrated Security=True";
        public void FillCombo()
        {
           using(SqlConnection con = new SqlConnection(ConnectionString))
                    {
                comboBox1.Items.Clear();
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText= "SELECT ID from ManagerInfo where [Assigned Rail]='Not Set Yet'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewRail.DataSource = dt;
                foreach (DataRow dr in dt.Rows)
                {
                    comboBox1.Items.Add(dr["ID"].ToString());
                }
                comboBox1.Items.Add("Not Set yet");

                SqlDataAdapter sqlData1 = new SqlDataAdapter("SELECT * from Railinfo", con);
                    DataTable d1 = new DataTable();
                    sqlData1.Fill(d1);
                    dataGridViewRail.DataSource = d1;
               
                con.Close();
            }
        }
        public AdminForm()
        {
            InitializeComponent();
            FillCombo();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlDataAdapter sqlData1 = new SqlDataAdapter("SELECT * from Railinfo", con);
                DataTable d1 = new DataTable();
                sqlData1.Fill(d1);
                dataGridViewRail.DataSource = d1;
            }
        }

        private void ManagerListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelPassengerRequest.SendToBack();
            panelManagerRequest.SendToBack();
            panelpassengerlist.SendToBack();
            panelRaillist.SendToBack();
            buttonPassenger.Visible=false;
            buttonReject.Visible = false;
            buttonRejected.Visible = false;
            buttonAccept.Visible = false;
            buttonAccepted.Visible = false;
            panelmanagerlist.BringToFront();
            buttonManager.Visible = true;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlDataAdapter sqlData1 = new SqlDataAdapter("SELECT ID,Name,Age,Address,[Phone No],Email from ManagerInfo", con);
                DataTable d1 = new DataTable();
                sqlData1.Fill(d1);
                dataGridViewManager.DataSource = d1;
            }
        }

        private void PassengerListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelPassengerRequest.SendToBack();
            panelManagerRequest.SendToBack();
            panelmanagerlist.SendToBack();
            panelRaillist.SendToBack();
            buttonManager.Visible = false;
            buttonReject.Visible = false;
            buttonRejected.Visible = false;
            buttonAccept.Visible = false;
            buttonAccepted.Visible = false;
            panelpassengerlist.BringToFront();
            buttonPassenger.Visible= true;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlDataAdapter sqlData1 = new SqlDataAdapter("SELECT ID,Name,Age,Address,[Phone No],Email from PassengerInfo", con);
                DataTable d1 = new DataTable();
                sqlData1.Fill(d1);
                dataGridViewPassenger.DataSource = d1;
            }
        }

        private void ButtonManager_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridViewManager.CurrentRow;
                int id = Convert.ToInt32(row.Cells[0].Value);

                DialogResult dialogResult = MessageBox.Show("Are you Sure?", "Removing the selected Manager", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(ConnectionString))
                    {
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "DELETE from ManagerInfo where ID='" + id + "'";
                        cmd.ExecuteNonQuery();
                        con.Close();
                        int rowindex = dataGridViewManager.CurrentCell.RowIndex;
                        dataGridViewManager.Rows.RemoveAt(rowindex);
                        MessageBox.Show("Removed successfully");
                    }
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            catch(NullReferenceException )
            {
                MessageBox.Show("select a row first");
            }
        }

        private void ButtonPassenger_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridViewPassenger.CurrentRow;
                int id = Convert.ToInt32(row.Cells[0].Value);

                DialogResult dialogResult = MessageBox.Show("Are you Sure?", "Removing the selected Passenger", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(ConnectionString))
                    {
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "DELETE from PassengerInfo where ID='" + id + "'";
                        cmd.ExecuteNonQuery();
                        con.Close();
                        int rowindex = dataGridViewPassenger.CurrentCell.RowIndex;
                        dataGridViewPassenger.Rows.RemoveAt(rowindex);
                        MessageBox.Show("Removed successfully");
                    }
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            catch (NullReferenceException )
            {
                MessageBox.Show("select a row first");
            }
        }

        private void ManagerRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelPassengerRequest.SendToBack();
            panelpassengerlist.SendToBack();
            panelmanagerlist.SendToBack();
            panelRaillist.SendToBack();
            buttonAccept.Visible = false;
            buttonReject.Visible = false;
            buttonPassenger.Visible = false;
            buttonManager.Visible = false;
            panelManagerRequest.BringToFront();
            buttonAccepted.Visible =true;
            buttonRejected.Visible = true;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlDataAdapter sqlData1 = new SqlDataAdapter("SELECT ID,Name,Age,Address,[Phone No],Email from ApplicationInfo Where [User Type] ='Manager'", con);
                DataTable d1 = new DataTable();
                sqlData1.Fill(d1);
                dataGridViewManagerRequest.DataSource = d1;
            }
            FillCombo();
        }

        private void PassengerRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelpassengerlist.SendToBack();
            panelmanagerlist.SendToBack();
            panelManagerRequest.SendToBack();
            panelRaillist.SendToBack();
            buttonAccepted.Visible = false;
            buttonRejected.Visible = false;
            buttonPassenger.Visible = false;
            buttonManager.Visible = false;
            panelPassengerRequest.BringToFront();
            buttonAccept.Visible = true;
            buttonReject.Visible = true;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlDataAdapter sqlData1 = new SqlDataAdapter("SELECT ID,Name,Age,Address,[Phone No],Email from ApplicationInfo Where [User Type] ='Passenger'", con);
                DataTable d1 = new DataTable();
                sqlData1.Fill(d1);
                dataGridViewPassengerRequest.DataSource = d1;
            }
        }

        private void ButtonReject_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridViewPassengerRequest.CurrentRow;
                int id = Convert.ToInt32(row.Cells[0].Value);

                DialogResult dialogResult = MessageBox.Show("Are you Sure?", "Removing the selected Applicant", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(ConnectionString))
                    {
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "DELETE from ApplicationInfo where ID='" + id + "'";
                        cmd.ExecuteNonQuery();
                        con.Close();
                        int rowindex = dataGridViewPassengerRequest.CurrentCell.RowIndex;
                        dataGridViewPassengerRequest.Rows.RemoveAt(rowindex);
                        MessageBox.Show("Removed successfully");
                    }
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("select a row first");
            }

        }

        private void ButtonRejected_Click(object sender, EventArgs e)
        {
       
            try
            {
                DataGridViewRow row = dataGridViewManagerRequest.CurrentRow;
                int id = Convert.ToInt32(row.Cells[0].Value);

                DialogResult dialogResult = MessageBox.Show("Are you Sure?", "Removing the selected Applicant", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(ConnectionString))
                    {
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "DELETE from ApplicationInfo where ID='" + id + "'";
                        cmd.ExecuteNonQuery();
                        con.Close();
                        int rowindex = dataGridViewManagerRequest.CurrentCell.RowIndex;
                        dataGridViewManagerRequest.Rows.RemoveAt(rowindex);
                        MessageBox.Show("Removed successfully");
                    }
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("select a row first");
            }

        }

        private void ButtonAccepted_Click(object sender, EventArgs e)
        {
             try
            {
                DataGridViewRow row = dataGridViewManagerRequest.CurrentRow;
                int id = Convert.ToInt16(row.Cells[0].Value);
                String name = Convert.ToString(row.Cells[1].Value);
                int age = Convert.ToInt16(row.Cells[2].Value);
                String address = Convert.ToString(row.Cells[3].Value);
                String phoneNo = Convert.ToString(row.Cells[4].Value);
                String email = Convert.ToString(row.Cells[5].Value);
                String password = "";
                String assign = "Not Set Yet";

                DialogResult dialogResult = MessageBox.Show("Are you Sure?", " Selecting  Applicant", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(ConnectionString))
                    {
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        SqlCommand cmd2 = con.CreateCommand();
                        SqlCommand cmd3 = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd2.CommandType = CommandType.Text;
                        cmd3.CommandType = CommandType.Text;
                        cmd.CommandText = "DELETE from ApplicationInfo where ID='" + id + "'";
                        cmd3.CommandText = "Select Password from ApplicationInfo where ID='" + id + "'";
                        password = (string)cmd3.ExecuteScalar();
                        cmd2.CommandText = "insert into ManagerInfo values('" + id + "','" + name + "','" + age + "','" + address + "','" + phoneNo + "','" + email + "','" + password + "','" + assign + "')";
                        cmd.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();
                        con.Close();
                        int rowindex = dataGridViewManagerRequest.CurrentCell.RowIndex;
                        dataGridViewManagerRequest.Rows.RemoveAt(rowindex);
                        MessageBox.Show("Saved successfully");
                    }
                }
                else if (dialogResult == DialogResult.No)
                {

                }
                 }
                 catch (NullReferenceException)
                 {
                     MessageBox.Show("select a row first");
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show("Error : " + ex.Message);
                 }
        }

        private void ButtonAccept_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridViewPassengerRequest.CurrentRow;
                int id = Convert.ToInt16(row.Cells[0].Value);
                String name = Convert.ToString(row.Cells[1].Value);
                int age = Convert.ToInt16(row.Cells[2].Value);
                String address = Convert.ToString(row.Cells[3].Value);
                String phoneNo = Convert.ToString(row.Cells[4].Value);
                String email = Convert.ToString(row.Cells[5].Value);
                String password = "";
                String balance = "";

                DialogResult dialogResult = MessageBox.Show("Are you Sure?", " Selecting  Applicant", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(ConnectionString))
                    {
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        SqlCommand cmd2 = con.CreateCommand();
                        SqlCommand cmd3 = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd2.CommandType = CommandType.Text;
                        cmd3.CommandType = CommandType.Text;
                        cmd3.CommandText = "Select Password from ApplicationInfo where ID='" + id + "'";
                        password = (string)cmd3.ExecuteScalar();
                        cmd.CommandText = "DELETE from ApplicationInfo where ID='" + id + "'";
                        cmd2.CommandText = "insert into PassengerInfo values('" + id + "','" + name + "','" + age + "','" + address + "','" + phoneNo + "','" + email + "','" + password + "','" + balance + "')";
                        cmd.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();
                        con.Close();
                        int rowindex = dataGridViewPassengerRequest.CurrentCell.RowIndex;
                        dataGridViewPassengerRequest.Rows.RemoveAt(rowindex);
                        MessageBox.Show("Saved successfully");
                    }
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("select a row first");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void RailDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelPassengerRequest.SendToBack();
            panelpassengerlist.SendToBack();
            panelmanagerlist.SendToBack();
            buttonAccept.Visible = false;
            buttonReject.Visible = false;
            buttonPassenger.Visible = false;
            buttonManager.Visible = false;
            panelManagerRequest.SendToBack();
            buttonAccepted.Visible = false;
            buttonRejected.Visible = false;
            panelRaillist.BringToFront();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlDataAdapter sqlData1 = new SqlDataAdapter("SELECT * from Railinfo", con);
                DataTable d1 = new DataTable();
                sqlData1.Fill(d1);
                dataGridViewRail.DataSource = d1;
                con.Close();
            }
            FillCombo();
        }

        private void LinkLabeldetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DetailsForm d1 = new DetailsForm();
            d1.ShowDialog();
        }
        private void ButtonAddtrain_Click(object sender, EventArgs e)
        {
            if (textBoxid.Text == "" || comboBox1.SelectedItem.ToString() == "")
                MessageBox.Show("Fill up the Fields");
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(ConnectionString);
                    con.Open();
                    SqlCommand cmd2 = con.CreateCommand();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = "insert into RailInfo values('" + this.textBoxid.Text + "','" + this.comboBox1.SelectedItem.ToString() + "','" + "" + "','" + "" + "')";
                    cmd.CommandText = "UPDATE ManagerInfo set [Assigned Rail] = '" + this.textBoxid.Text + "'where ID='" + this.comboBox1.SelectedItem.ToString() + "';";
                    cmd2.ExecuteNonQuery();
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter sqlData2 = new SqlDataAdapter("SELECT * from Railinfo", con);
                    DataTable d1 = new DataTable();
                    sqlData2.Fill(d1);
                    dataGridViewRail.DataSource = d1;
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
            FillCombo();

        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            string assign = "Not Set Yet";
            try
            {
                DataGridViewRow row = dataGridViewRail.CurrentRow;
                int id = Convert.ToInt32(row.Cells[0].Value);
                string value= Convert.ToString(row.Cells[1].Value);
                DialogResult dialogResult = MessageBox.Show("Are you Sure?", "Removing the selected Rail", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(ConnectionString))
                    {
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        SqlCommand cmd2 = con.CreateCommand();
                        cmd2.CommandType = CommandType.Text;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "DELETE from RailInfo where ID='" + id + "'";
                        cmd2.CommandText = "UPDATE ManagerInfo set [Assigned Rail] = '"+ assign+ "' where ID='" + value + "';";
                        cmd2.ExecuteNonQuery();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        int rowindex = dataGridViewRail.CurrentCell.RowIndex;
                        dataGridViewRail.Rows.RemoveAt(rowindex); SqlDataAdapter sqlData2 = new SqlDataAdapter("SELECT * from Railinfo", con);
                        DataTable d1 = new DataTable();
                        sqlData2.Fill(d1);
                        dataGridViewRail.DataSource = d1;
                        MessageBox.Show("Removed successfully");
                    }
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("select a row first");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            FillCombo();
        }

        private void DataGridViewRail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedrow = dataGridViewRail.Rows[index];
            textBoxid.Text = selectedrow.Cells[0].Value.ToString();
            comboBox1.Text = selectedrow.Cells[1].Value.ToString();
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridViewRail.CurrentRow;
                int id = Convert.ToInt32(row.Cells[0].Value);
                string change = Convert.ToString(row.Cells[1].Value);
                string assign = "Not Set Yet";
                    DialogResult dialogResult = MessageBox.Show("Are you Sure?", "updating the selected Rail", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        using (SqlConnection con = new SqlConnection(ConnectionString))
                        {
                            con.Open();
                            SqlCommand cmd = con.CreateCommand();
                            SqlCommand cmd2 = con.CreateCommand();
                            SqlCommand cmd3 = con.CreateCommand();
                            cmd3.CommandType = CommandType.Text;
                            cmd2.CommandType = CommandType.Text;
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "UPDATE RailInfo set ID='" + this.textBoxid.Text + "',[Assigned Manager]='" + this.comboBox1.SelectedItem.ToString() + "'where ID='" + id + "';";
                            cmd2.CommandText = "UPDATE ManagerInfo set [Assigned Rail] = '" + this.textBoxid.Text + "' where ID='" + this.comboBox1.SelectedItem.ToString() + "';";
                            cmd3.CommandText = "UPDATE ManagerInfo set [Assigned Rail] = '"+assign+"' where ID='" + change + "';";
                            cmd3.ExecuteNonQuery();
                            cmd2.ExecuteNonQuery();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            SqlDataAdapter sqlData2 = new SqlDataAdapter("SELECT * from Railinfo", con);
                            DataTable d1 = new DataTable();
                            sqlData2.Fill(d1);
                            dataGridViewRail.DataSource = d1;
                            MessageBox.Show("updated successfully");
                        }
                    }

                    else if (dialogResult == DialogResult.No)
                    {

                    }
                }
            catch (NullReferenceException)
            {
                MessageBox.Show("select a row first");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            FillCombo();
        }

        private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to Exit?", "Exiting the Window ", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();
                LoginForm fm = new LoginForm();
                fm.ShowDialog();
            }
        }
    }

        }

    
