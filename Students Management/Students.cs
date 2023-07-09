using System;
using System.Drawing;
using System.Windows.Forms;

namespace Students_Management
{
    public partial class Students : Form
    {
        functions con;
        public Students()
        {
            InitializeComponent();
            con = new functions();
            ShowStudents();
            GetDepartment();
        }
        // show grid data on grid view
        private void ShowStudents()
        {
            string Query = "select * from StudentTable ";
            StuDataGridView1.DataSource = con.GetData(Query);
        }
        // get data from department table
        private void GetDepartment()
        {
            string Query = "select * from DepartmentTab1";
            DepartmentComb.DisplayMember = con.GetData(Query).Columns["DeptName"].ToString();
            DepartmentComb.ValueMember = con.GetData(Query).Columns["DeptID"].ToString();
            DepartmentComb.DataSource = con.GetData(Query);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ClearBtn();
            MessegeBoxView.Text = "Student Data Loaded Sucessfully";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearBtn();

        }

        private void ClearBtn()
        {
            Stu_Name.Clear();
            Stu_Phone.Clear();
            Stu_Session.Clear();
            Stu_Address.Clear();
            GengerComb.SelectedIndex = -1;
            DepartmentComb.SelectedIndex = -1;
            MessegeBoxView.Text = " All Data Reset";
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (Stu_Name.Text == "" || Stu_Session.Text == "" ||
                Stu_Phone.Text == "" || Stu_Address.Text == "" ||
                GengerComb.SelectedIndex == -1 || DepartmentComb.SelectedIndex == -1)
            {
                MessegeBoxView.Text = "Input String cant't Be Blank !";
            }
            else
            {
                try
                {
                    string StuName = Stu_Name.Text;
                    string StuSession = Stu_Session.Text;
                    string StuPhone = Stu_Phone.Text;
                    string StuAddress = Stu_Address.Text;

                    string StuGen = GengerComb.SelectedItem.ToString();
                    //string Dep= DepartmentComb.SelectedItem.ToString();
                    int Dep = Convert.ToInt32(DepartmentComb.SelectedValue.ToString());

                    string Query = "insert into StudentTable values('{0}','{1}','{2}','{3}','{4}','{5}')";
                    Query = string.Format(Query, StuName, StuGen, Dep, StuSession, StuPhone, StuAddress);
                    con.SetData(Query);

                    MessegeBoxView.Text = " Student inserted Sucessfully !";
                    ShowStudents();
                  

                }
                catch (Exception Ex)
                {
                    MessegeBoxView.Text = Ex.Message;
                }
            }
        }
        int key = 0;
        private void StuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Stu_Name.Text = StuDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            GengerComb.SelectedItem = StuDataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            DepartmentComb.SelectedValue = StuDataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            Stu_Session.Text = StuDataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            Stu_Phone.Text = StuDataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            Stu_Address.Text = StuDataGridView1.SelectedRows[0].Cells[6].Value.ToString();

            if (Stu_Name.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(StuDataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                MessegeBoxView.Text = "Get data from grid View !";
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (Stu_Name.Text == "" || Stu_Session.Text == "" ||
               Stu_Phone.Text == "" || Stu_Address.Text == "" ||
               GengerComb.SelectedIndex == -1 ||
               DepartmentComb.SelectedIndex == -1)
            {
                MessegeBoxView.Text = "Input String cant't Be Blank !";
            }
            else
            {
                try
                {
                    string StuName = Stu_Name.Text;
                    string StuSession = Stu_Session.Text;
                    string StuPhone = Stu_Phone.Text;
                    string StuAddress = Stu_Address.Text;

                    string StuGen = GengerComb.SelectedItem.ToString();
                    //string Dep= DepartmentComb.SelectedItem.ToString();
                    int Dep = Convert.ToInt32(DepartmentComb.SelectedValue.ToString());

                    string Query = "update StudentTable set StuName='{0}', StuGen='{1}',StuDepartment='{2}',StuSession='{3}',StuPhone='{4}',StuAddress='{5}' where Stu_ID={6}";
                    Query = string.Format(Query, StuName, StuGen, Dep, StuSession, StuPhone, StuAddress, key);
                    con.SetData(Query);

                    MessegeBoxView.Text = " Student Updated Sucessfully !";
                    ShowStudents();
                   

                }
                catch (Exception Ex)
                {
                    MessegeBoxView.Text = Ex.Message;
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key==0)
            {
                MessegeBoxView.Text = "Select a row !";
            }
            else
            {
                try
                {
                   
                    string Query = "Delete from StudentTable  where Stu_ID={0}";
                    Query = string.Format(Query, key);
                    con.SetData(Query);

                    MessegeBoxView.Text = " Student Deleted Sucessfully !";
                    ShowStudents();
                   

                }
                catch (Exception Ex)
                {
                    MessegeBoxView.Text = Ex.Message;
                }

            }
        }

        private void DepartmentOk_Paint(object sender, PaintEventArgs e)
        {
            //Departments dep = new Departments();
            //dep.Show();
            //this.Hide();
        }

        private void DeshboardOk_Paint(object sender, PaintEventArgs e)
        {
            //Deshboard des = new Deshboard();
            //des.Show();
            //this.Hide();
        }

        private void StudentOk_Paint(object sender, PaintEventArgs e)
        {
            //Students stu = new Students();
            //stu.Show();
            //this.Hide();
        }

        private void StudentSelect_Click(object sender, EventArgs e)
        {

            //Students stu = new Students();
            //stu.Show();
            //this.Hide();
        }

        private void DepartmentClick_Click(object sender, EventArgs e)
        {
           
        }

        private void DeshboardClick_Click(object sender, EventArgs e)
        {
            //Deshboard des = new Deshboard();
            //des.Show();
            //this.Hide();
        }

        private void DepartmentBtn_Click(object sender, EventArgs e)
        {
            Departments dep = new Departments();
            dep.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            Students stu = new Students();
            stu.Show();
            this.Hide();
        }

        private void DeshboardBtn_Click(object sender, EventArgs e)
        {
            Deshboard des = new Deshboard();
            des.Show();
            this.Hide();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void AboutBtn_Click(object sender, EventArgs e)
        {
            AboutSec log = new AboutSec();
            log.Show();
            this.Hide();
        }

        private void DeveloperBtn_Click(object sender, EventArgs e)
        {
            DeveloperSec log = new DeveloperSec();
            log.Show();
            this.Hide();
        }
    }
}
