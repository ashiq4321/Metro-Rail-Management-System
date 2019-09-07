using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Metro_Rail_Management_System
{
    public partial class DetailsForm : Form
    {
        readonly string ConnectionString = @"Data Source=DESKTOP-C18Q6RS;Initial Catalog=MetroRailManagementSystem;Integrated Security=True";
        public void FillCombo()
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                comboBoxMetroNo.Items.Clear();
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT ID from RailInfo ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    comboBoxMetroNo.Items.Add(dr["ID"].ToString());
                }

                con.Close();
            }
        }
        public DetailsForm()
        {
            InitializeComponent();
            FillCombo();

        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Select [Current Location] from RailInfo where ID='" + this.comboBoxMetroNo.SelectedItem.ToString() + "'";
                    string current = (string)cmd.ExecuteScalar();
                    label3.Text = (string)cmd.ExecuteScalar();
                    SqlCommand cmd2 = con.CreateCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = "Select [Next Location] from RailInfo where ID='" + this.comboBoxMetroNo.SelectedItem.ToString() + "'";
                    label2.Text = (string)cmd2.ExecuteScalar();
                    System.Text.StringBuilder sb = new System.Text.StringBuilder();
                    sb.Append("http://maps.google.com/maps?q=");
                    sb.Append(current + "," + "+");
                    webBrowser1.Navigate(sb.ToString());
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are you Sure?", "Exiting the Window", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
    }
}
