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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CimacProject
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
         
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register.ActiveForm.Close();
            string pts = "0";
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\IamR\source\repos\CimacProject\CimacProject\Database1.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[CimacData] ([username], [password], [point] ) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + pts + "')", cn);
           
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();

            MessageBox.Show("Your Account has been Succesfully Created ", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Hide();
            Next next = new Next();
            next.ShowDialog();
            Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
    }
}
