using System;
using System.Linq;
using System.Windows.Forms;

namespace Assignment._Form
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var query_username = Program.db.Users.Where(p => p.username_ == tb_Username.Text).FirstOrDefault();
            if (query_username != null)
            {
                var query_password = Program.db.Users.Where(p => p.password_ == tb_Password.Text).FirstOrDefault();
                if (query_password != null)
                {
                    Program.isLogin = true;
                    Program.role = query_username.role_;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sai rồi");
                }
            }
            else
            {
                MessageBox.Show("Sai rồi");
            }
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Program.isLogin)
            {
                Program.isLoading = false;
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
