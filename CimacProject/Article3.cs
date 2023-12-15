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
    public partial class Article3 : Form
    {
        public Article3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Article3.ActiveForm.Close();
            int incrementBy = 5; // Increment value

            using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\IamR\\source\\repos\\CimacProject\\CimacProject\\Database1.mdf;Integrated Security=True"))
            {
                string selectQuery = "SELECT point FROM CimacData WHERE id=@id"; // Retrieve the current value
                string updateQuery = "UPDATE CimacData SET point = @newPoint WHERE id=@id"; // Update with the new value

                using (SqlCommand selectCmd = new SqlCommand(selectQuery, con))
                {
                    selectCmd.Parameters.AddWithValue("@id", UserSession.UserID);
                    con.Open();
                    object result = selectCmd.ExecuteScalar();

                    if (result != DBNull.Value) // Check for DBNull.Value before conversion
                    {
                        int currentPoints = Convert.ToInt32(result);

                        // Increment the points
                        int newPoints = currentPoints + incrementBy;

                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, con))
                        {
                            updateCmd.Parameters.AddWithValue("@id", UserSession.UserID);
                            updateCmd.Parameters.AddWithValue("@newPoint", newPoints);
                            updateCmd.ExecuteNonQuery();
                        }


                        MessageBox.Show("Congratulations, you earned 5 points!");
                    }
                    else
                    {
                        MessageBox.Show("User points not found.");
                    }

                    con.Close();
                }
            }
        }
    }
}
