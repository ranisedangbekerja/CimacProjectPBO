using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CimacProject
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Hide();
            EditProfile editProfile = new EditProfile();
            editProfile.ShowDialog();
            Show();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Hide();
            Mission1 mission1 = new Mission1();
            mission1.ShowDialog();
            Show();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Hide();
            Article1 article1 = new Article1();
            article1.ShowDialog();
            Show();
        }
    }
}
