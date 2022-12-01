using System;
using System.Collections;
using System.Linq;

using System.Windows.Forms;

using Assignment.Models;

namespace Assignment._Form
{
    public partial class FormMain : Form
    {
        public IList LoadDssv(string text = "")
        {
            ///Load dữ liệu lên data grid view
            return Program.db.Students.Where(p =>
            p.HoTen.ToLower().Contains(text) ||
            p.MaSV.ToLower().Contains(text)).Select(p => new dssv()
            {
                maSV = p.MaSV,
                hoTen = p.HoTen,
                email = p.Email,
                soDT = p.SDT,
                gioiTinh = p.GioiTinh == "nam" ? true : false,
                diaChi = p.DiaChi,
                hinh = p.Image,
                tiengAnh = Math.Round(p.Grades.FirstOrDefault().TiengAnh.Value, 2),
                tinHoc = Math.Round(p.Grades.FirstOrDefault().TinHoc.Value, 2),
                gdtc = Math.Round(p.Grades.FirstOrDefault().GDTC.Value),
                diemTB = Math.Round((p.Grades.FirstOrDefault().TiengAnh.Value
                + p.Grades.FirstOrDefault().TinHoc.Value
                + p.Grades.FirstOrDefault().GDTC.Value) / 3, 2)

            }).ToList();

        }

        public void Setup()
        {
            tb_masv.DataBindings.Add(new Binding("Text", grid_dsSV.DataSource, "maSV"));
            tb_hoten.DataBindings.Add(new Binding("Text", grid_dsSV.DataSource, "hoTen"));
            tb_email.DataBindings.Add(new Binding("Text", grid_dsSV.DataSource, "email"));
            tb_sdt.DataBindings.Add(new Binding("Text", grid_dsSV.DataSource, "soDT"));
            rd_male.DataBindings.Add(new Binding("Checked", grid_dsSV.DataSource, "gioiTinh"));
            tb_diachi.DataBindings.Add(new Binding("Text", grid_dsSV.DataSource, "diaChi"));
            px_hinhanh.DataBindings.Add(new Binding("Tag", grid_dsSV.DataSource, "hinh"));
            tb_tiengAnh.DataBindings.Add(new Binding("Text", grid_dsSV.DataSource, "tinHoc"));
            tb_tinHoc.DataBindings.Add(new Binding("Text", grid_dsSV.DataSource, "tiengAnh"));
            tb_gdtc.DataBindings.Add(new Binding("Text", grid_dsSV.DataSource, "gdtc"));
            tb_diemTb.DataBindings.Add(new Binding("Text", grid_dsSV.DataSource, "diemTB"));
        }
        public void ClearBinding()
        {
            tb_masv.DataBindings.Clear();
            tb_hoten.DataBindings.Clear();
            tb_email.DataBindings.Clear();
            tb_sdt.DataBindings.Clear();
            rd_male.DataBindings.Clear();
            tb_diachi.DataBindings.Clear();
            px_hinhanh.DataBindings.Clear();
            tb_tiengAnh.DataBindings.Clear();
            tb_tinHoc.DataBindings.Clear();
            tb_gdtc.DataBindings.Clear();
            tb_diemTb.DataBindings.Clear();
        }
        public FormMain()
        {
            InitializeComponent();
            px_hinhanh.Tag = "https://i.ibb.co/BgwBsGB/Study-Girl2.png";
            grid_dsSV.DataSource = LoadDssv();
            ClearBinding();
            Setup();
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
            btn_luu.Enabled = false;
            if (query.FirstOrDefault().Value == Program.roles["Admin"])
            {

            }
            else if (query.FirstOrDefault().Value == Program.roles["GiangVien"])
            {
                tb_masv.Enabled = false;
                tb_hoten.Enabled = false;
                tb_email.Enabled = false;
                tb_sdt.Enabled = false;
                rd_male.Enabled = false;
                rd_female.Enabled = false;
                tb_diachi.Enabled = false;
                btn_them.Enabled = false;
                btn_xoa.Enabled = false;

            }
            else if (query.FirstOrDefault().Value == Program.roles["CanBo"])
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

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            var searchBox = sender as TextBox;
            grid_dsSV.DataSource = LoadDssv(searchBox.Text);

            ClearBinding();
            Setup();
        }



        private void rd_male_CheckedChanged(object sender, EventArgs e)
        {
            var radio_male = sender as RadioButton;
            if (radio_male.Checked == true)
            {
                this.rd_female.Checked = false;
            }
            else
            {
                this.rd_female.Checked = true;

            }
        }

        private void grid_dsSV_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            px_hinhanh.LoadAsync(px_hinhanh.Tag.ToString());

        }
    }
}
