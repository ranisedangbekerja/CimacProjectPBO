using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CimacProject
{
    public partial class dashbord : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\IamR\\source\\repos\\CimacProject\\CimacProject\\Database1.mdf;Integrated Security=True");
        public dashbord()
        {
            InitializeComponent();
            userControl11.BringToFront();
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashbord_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\IamR\source\repos\CimacProject\CimacProject\Database1.mdf;Integrated Security=True");
            string sql = "select * from CimacData WHERE id=@id";
            using (SqlCommand cmd = new SqlCommand(sql, cn))
            {
                cmd.Parameters.AddWithValue("@id", UserSession.UserID);
                cn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                { 
                    if (dr.Read())
                    {
                        lbl_score.Text = dr["point"].ToString();
                    }
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl11.BringToFront();
        }

        private void userControl21_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl21.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            userControl31.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            userControl41.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you want to close this program?", "Exit message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            Hide();
            WeatherAPI weatherAPI = new WeatherAPI();
            weatherAPI.ShowDialog();
            Show();
        }
    }
}
