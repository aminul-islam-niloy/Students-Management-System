using System;
using System.Windows.Forms;

namespace Students_Management
{
    public partial class Departments : Form
    {
        functions Con;


        public Departments()
        {
            InitializeComponent();
            Con = new functions();
            ShowDepartment();
        }

        private void ShowDepartment()
        {
            string Query = "select * from DepartmentTab1";
            DeptDataGridView1.DataSource = Con.GetData(Query);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (DeptNameTb.Text == "" || DeptDetails.Text=="")
            {
                DeptMessBox.Text = "Input String cant't Be Blank !";
            }
            else
            {
                try
                {
                    string DName = DeptNameTb.Text;
                    string DDetails = DeptDetails.Text;
                    string Query = "insert into DepartmentTab1 values('{0}','{1}')";
                    Query = string.Format(Query, DName, DDetails);
                    Con.SetData(Query);

                    DeptMessBox.Text = " Dept inserted Sucessfully !";
                    ShowDepartment();
                }
                catch (Exception Ex)
                {
                    DeptMessBox.Text = Ex.Message;
                }
            }
        }

       
        private void DeptDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
         

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

        }

        int key = 0;

        private void DeptDataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DeptNameTb.Text = DeptDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            DeptDetails.Text = DeptDataGridView1.SelectedRows[0].Cells[2].Value.ToString();

            if (DeptNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(DeptDataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void UpdateBtn_Click_1(object sender, EventArgs e)
        {
            if (DeptNameTb.Text == "" || DeptDetails.Text == "")
            {
                DeptMessBox.Text = "Input String cant't Be Blank !";
            }
            else
            {
                try
                {
                    string DName = DeptNameTb.Text;
                    string DDetails = DeptDetails.Text;
                    string Query = "update DepartmentTab1 set DeptName='{0}', DeptDetails='{1}' where DeptID={2}";
                    Query = string.Format(Query, DName, DDetails,key);
                    Con.SetData(Query);

                    DeptMessBox.Text = " Dept Updated Sucessfully !";
                    ShowDepartment();
                }
                catch (Exception Ex)
                {
                    DeptMessBox.Text = Ex.Message;
                }
            }
        }

        private void DeleteBtn_Click_1(object sender, EventArgs e)
        {
            if (key ==0)
            {
                DeptMessBox.Text = "Select a row !";
            }
            else
            {
                try
                {                   
                    string Query = "delete from DepartmentTab1  where DeptID={0}";
                    Query = string.Format(Query, key);
                    Con.SetData(Query);

                    DeptMessBox.Text = " Dept Deleted Sucessfully !";
                    ShowDepartment();
                }
                catch (Exception Ex)
                {
                    DeptMessBox.Text = Ex.Message;
                }
            }
        }

        private void ResetBtn_Click_1(object sender, EventArgs e)
        {
            DeptNameTb.Clear();
            DeptDetails.Clear();
            DeptMessBox.Text = " Data Reset!";

        }

        private void guna2Button1_Click(object sender, EventArgs e)
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

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            DeptMessBox.Text = "Data Loaded";
        }

        private void AboutBtn_Click(object sender, EventArgs e)
        {
            AboutSec log = new AboutSec();
            log.Show();
            this.Close();
        }

        private void DeveloperBtn_Click(object sender, EventArgs e)
        {
            DeveloperSec log = new DeveloperSec();
            log.Show();
            this.Close();
        }
    }
}
