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

namespace CimacProject
{
    public partial class EditProfile : Form
    {
        public static EditProfile instance;
        public EditProfile()
        {
            InitializeComponent();
            instance = this;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditProfile.ActiveForm.Close();
            UserControl4.instance.lab1.Text = textBox1.Text;
            UserControl4.instance.lab2.Text = textBox1.Text;
            UserControl4.instance.lab3.Text = textBox2.Text;
            UserControl4.instance.lab4.Text = textBox3.Text;
            UserControl4.instance.lab5.Text = textBox4.Text;

            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\IamR\\source\\repos\\CimacProject\\CimacProject\\Database1.mdf;Integrated Security=True");
            string updateQuery = "UPDATE CimacData SET status = @status, full_name = @full_name, gender = @gender, username = @username WHERE id=@id";

            using (SqlCommand cmd = new SqlCommand(updateQuery, con))
            {
                cmd.Parameters.AddWithValue("@id", UserSession.UserID);
                cmd.Parameters.AddWithValue("@status", textBox4.Text);
                cmd.Parameters.AddWithValue("@full_name", textBox2.Text); // Assuming textBox2 contains the full name
                cmd.Parameters.AddWithValue("@gender", textBox3.Text); // Assuming textBox3 contains the gender
                cmd.Parameters.AddWithValue("@username", textBox1.Text); // Assuming textBox4 contains the username

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Saved");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
