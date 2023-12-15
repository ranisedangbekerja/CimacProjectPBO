using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CimacProject
{
    public partial class Next : Form
    {

        public Next()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isValid()) 
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\IamR\source\repos\CimacProject\CimacProject\Database1.mdf;Integrated Security=True"))
                {
                    string query = "SELECT * FROM CimacData WHERE Username = '" + textBox1.Text.Trim() + "'AND Password = '" + textBox2.Text.Trim() + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    DataTable dta = new DataTable();
                    sda.Fill(dta);
                    if (dta.Rows.Count == 1) 
                    {
                        UserSession.UserID = Convert.ToInt32(dta.Rows[0]["id"]); ;
                        MessageBox.Show("SUCCESS");
                        dashbord dashbord = new dashbord();
                        this.Hide();
                        dashbord.Show();
                    }
                }
            }
        }
        private bool isValid()
        {
            if (textBox1.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("enter valid user name", "error");
                return false;

            }else if (textBox2.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("enter valid password", "error");
                return false;
            }
            return true;
        }

        private void Next_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.UseSystemPasswordChar == true)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else if (textBox2.UseSystemPasswordChar == false)
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Hide();
            Register register = new Register();
            register.ShowDialog();
            Show();
        }
    }
}
