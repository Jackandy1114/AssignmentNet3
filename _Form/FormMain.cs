using System;
using System.Collections;
using System.Linq;

using System.Windows.Forms;

using Assignment.Models;

namespace Assignment._Form
{
    public partial class FormMain : Form
    {
        public IEnumerable LoadDssv()
        {
            return Program.db.Students.Select(p => new dssv()
            {
                maSV = p.MaSV,
                hoTen = p.HoTen,
                email = p.Email,
                soDT = p.SDT,
                gioiTinh = p.GioiTinh,
                diaChi = p.DiaChi,
                hinh = p.Image,
                tiengAnh = p.Grades.FirstOrDefault().TiengAnh.Value,
                tinHoc = p.Grades.FirstOrDefault().TinHoc.Value,
                gdtc = p.Grades.FirstOrDefault().GDTC.Value,
                diemTB =
                (p.Grades.FirstOrDefault().TiengAnh.Value
                + p.Grades.FirstOrDefault().TinHoc.Value
                + p.Grades.FirstOrDefault().GDTC.Value) / 3

            }).ToList();
        }
        public FormMain()
        {
            InitializeComponent();
            grid_dsSV.DataSource = LoadDssv();
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
            var query = Program.roles.Where(p => p.Key == Program.role);
            lb_role.Text = query.FirstOrDefault().Value;
            if (query.FirstOrDefault().Value == Program.roles["Admin"])
            {

            }
        }


        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.isLogin = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
