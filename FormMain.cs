using System;
using System.Linq;
using System.Windows.Forms;

namespace Assignment
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.isLogin = false;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            var query = Program.roles.Where(p => p.Value == Program.role);
            lb_role.Text = query.FirstOrDefault().Value;
            if (query.FirstOrDefault().Value == Program.roles[1])
            {
                button1.Enabled = false;
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.isLogin = false;
        }
    }
}
