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
    public partial class UserControl4 : UserControl
    {
        public static UserControl4 instance;
        public Label lab1;
        public Label lab2;
        public Label lab3;
        public Label lab4;
        public Label lab5;

        public UserControl4()
        {
            InitializeComponent();
            instance = this;
            lab1 = lbl_Name;
            lab2 = lbl_UserName;
            lab3 = lbl_NamaLkp;
            lab4 = lbl_Gender;
            lab5 = lbl_Status;

            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void UserControl4_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\IamR\source\repos\CimacProject\CimacProject\Database1.mdf;Integrated Security=True");
            string sql = "select * from CimacData WHERE id=@id";
            using (SqlCommand cmd = new SqlCommand(sql, cn)) {
                cmd.Parameters.AddWithValue("@id", UserSession.UserID);
                cn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        lbl_UserName.Text = dr["username"].ToString();
                        lbl_Name.Text = dr["username"].ToString();
                        lbl_NamaLkp.Text = dr["full_name"].ToString();
                        lbl_Gender.Text = dr["gender"].ToString();
                        lbl_Status.Text = dr["status"].ToString();
                    }
                }
        }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            EditProfile editProfile = new EditProfile();
            editProfile.ShowDialog();
            Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_NamaLkp_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
