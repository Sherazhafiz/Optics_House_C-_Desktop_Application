using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Optics_1._0
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            // Establish database connection
            SqlConnection connection = Connectivity.Connection();

            try
            {
                // SQL query for inserting data
                string query = @"INSERT INTO Customer (Name, PhoneNumber, DateAdded, R_SPH, R_CYL, R_AXIS, R_ADD, L_SPH, L_CYL, L_AXIS, L_ADD, Distance, Reading, Delivered, Total, Advance, Balance)
                     VALUES (@Name, @PhoneNumber, @DateAdded, @R_SPH, @R_CYL, @R_AXIS, @R_ADD, @L_SPH, @L_CYL, @L_AXIS, @L_ADD, @Distance, @Reading, @Delivered, @Total, @Advance, @Balance)";

                // Create SQL command object
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                // Add parameter values
                // Add parameter values
                sqlCommand.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@PhoneNumber", txtPhone.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@DateAdded", DateTime.Now);
                sqlCommand.Parameters.AddWithValue("@R_SPH", string.IsNullOrEmpty(R_SPHtxt.Text) ? (object)DBNull.Value : decimal.Parse(R_SPHtxt.Text.Trim()));
                sqlCommand.Parameters.AddWithValue("@R_CYL", string.IsNullOrEmpty(R_CYLtxt.Text) ? (object)DBNull.Value : decimal.Parse(R_CYLtxt.Text.Trim()));
                sqlCommand.Parameters.AddWithValue("@R_AXIS", string.IsNullOrEmpty(R_AXIStxt.Text) ? (object)DBNull.Value : int.Parse(R_AXIStxt.Text.Trim()));
                sqlCommand.Parameters.AddWithValue("@R_ADD", string.IsNullOrEmpty(R_ADDtxt.Text) ? (object)DBNull.Value : decimal.Parse(R_ADDtxt.Text.Trim()));
                sqlCommand.Parameters.AddWithValue("@L_SPH", string.IsNullOrEmpty(L_SPHtxt.Text) ? (object)DBNull.Value : decimal.Parse(L_SPHtxt.Text.Trim()));
                sqlCommand.Parameters.AddWithValue("@L_CYL", string.IsNullOrEmpty(L_CYLtxt.Text) ? (object)DBNull.Value : decimal.Parse(L_CYLtxt.Text.Trim()));
                sqlCommand.Parameters.AddWithValue("@L_AXIS", string.IsNullOrEmpty(L_AXIStxt.Text) ? (object)DBNull.Value : int.Parse(L_AXIStxt.Text.Trim()));
                sqlCommand.Parameters.AddWithValue("@L_ADD", string.IsNullOrEmpty(L_ADDtxt.Text) ? (object)DBNull.Value : decimal.Parse(L_ADDtxt.Text.Trim()));
                sqlCommand.Parameters.AddWithValue("@Distance", Distancetxt.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@Reading", Readingtxt.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@Delivered", checkPayment.Checked);
                sqlCommand.Parameters.AddWithValue("@Total", string.IsNullOrEmpty(Totaltxt.Text) ? (object)DBNull.Value : decimal.Parse(Totaltxt.Text.Trim()));
                sqlCommand.Parameters.AddWithValue("@Advance", string.IsNullOrEmpty(Advancetxt.Text) ? (object)DBNull.Value : decimal.Parse(Advancetxt.Text.Trim()));
                sqlCommand.Parameters.AddWithValue("@Balance", string.IsNullOrEmpty(Balancetxt.Text) ? (object)DBNull.Value : decimal.Parse(Balancetxt.Text.Trim()));

                // Execute the query
                sqlCommand.ExecuteNonQuery();

                // Show success message
                MessageBox.Show("Record saved successfully...");
            }
            catch (Exception ex)
            {
                // Show error message
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Close the database connection
                connection.Close();
            }

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
           

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Customer_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void Customer_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void txtName_KeyPress_1(object sender, KeyPressEventArgs e)
        {

        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {
           


        }
    }
}

//char ch = e.KeyChar;
//if (!char.IsNumber(ch) && !char.IsLetter(ch) && ch != 8 && ch != 46)
//{
//    e.Handled = true;
//}