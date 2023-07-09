using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Students_Management
{
    public partial class DeveloperSec : Form
    {
        public DeveloperSec()
        {
            InitializeComponent();
        }

        private void StudentBtn_Click(object sender, EventArgs e)
        {
            Students stu = new Students();
            stu.Show();
            this.Close();
        }

        private void DepartmentBtn_Click(object sender, EventArgs e)
        {
            Departments dep = new Departments();
            dep.Show();
            this.Close();
        }

        private void DeshboardBtn_Click(object sender, EventArgs e)
        {
            Deshboard des = new Deshboard();
            des.Show();
            this.Close();
        }

        private void AboutBtn_Click(object sender, EventArgs e)
        {
            AboutSec abu = new AboutSec();
            abu.Show();
            this.Close();
        }

        private void DeveloperBtn_Click(object sender, EventArgs e)
        {
            DeveloperSec log = new DeveloperSec();
            log.Show();
            this.Close();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
