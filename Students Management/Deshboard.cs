using System;
using System.Data;
using System.Windows.Forms;

namespace Students_Management
{
    public partial class Deshboard : Form
    {
        functions con;
        public Deshboard()
        {
            InitializeComponent();
            con = new functions();
            CountStudent();
            CountDept();
            CountSession();
            CountMale();
            CountFeMale();

        }
        
        private void CountStudent()
        {
            string Query = "select count(*) as total from StudentTable";
            foreach (DataRow dsr in con.GetData(Query).Rows) 
            {
                StudentNum.Text= dsr["total"].ToString();
            }
        }

        private void CountDept()
        {
            string Query = "select count(DISTINCT DeptName) as totalDp from DepartmentTab1";
            foreach (DataRow dsr in con.GetData(Query).Rows)
            {
                DepartmentNum.Text = dsr["totalDp"].ToString();
            }
        }

        private void CountSession()
        {
            string Query = "select count(DISTINCT StuSession) as totalSession from StudentTable";
            foreach (DataRow dsr in con.GetData(Query).Rows)
            {
                SessionNum.Text = dsr["totalSession"].ToString();
            }
        }

        private void CountMale()
        {
            string Gen = "Male";
            string Query = "select count(*) as totalMale from StudentTable where StuGen='{0}'";
            Query = string.Format(Query, Gen);
            foreach (DataRow dsr in con.GetData(Query).Rows)
            {
                GenMaleNum.Text = dsr["totalMale"].ToString();
            }
        }

        private void CountFeMale()
        {
            string Gen = "Female";
            string Query = "select count(*) as totalFeMale from StudentTable where StuGen='{0}'";
            Query = string.Format(Query, Gen);
            foreach (DataRow dsr in con.GetData(Query).Rows)
            {
                GenFemaleNum.Text = dsr["totalFeMale"].ToString();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

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
            aboutBtnClick();
        }

        private void aboutBtnClick()
        {
            AboutSec abu = new AboutSec();
            abu.Show();
            this.Close();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void UserNametext_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StudentNum_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void DeveloperBtn_Click(object sender, EventArgs e)
        {
            DeveloperSec log = new DeveloperSec();
            log.Show();
            this.Close();

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SessionNum_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DepartmentNum_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void GenMaleNum_Click(object sender, EventArgs e)
        {

        }

        private void GenFemaleNum_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }
    }
}
