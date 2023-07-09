using System;
using System.Windows.Forms;

namespace Students_Management
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UserNameTxt.Text == "" && PasswordTxt.Text == "")
            {
                MessegeBoxView.Text = "Insert Username and Password";
                
            }
            else if((UserNameTxt.Text == "17122"|| UserNameTxt.Text == "aminul") && PasswordTxt.Text == "aminul")
            {
                Deshboard des = new Deshboard();
                des.Show();
                this.Hide();
                ClearBtn();
            }
            else
            {
                
                MessegeBoxView.Text = "Incorrect Username Or Password";

            }
        }

        private void ClearBtn()
        {
            UserNameTxt.Clear();
            PasswordTxt.Clear();
        }

        private void HeadTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
