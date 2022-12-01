namespace Assignment._Form
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_role = new System.Windows.Forms.Label();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.lb_search = new System.Windows.Forms.Label();
            this.lb_masv = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiengAnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdtc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_masv = new System.Windows.Forms.TextBox();
            this.tb_hoten = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            this.tb_diachi = new System.Windows.Forms.RichTextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.px_hinhanh = new System.Windows.Forms.PictureBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.px_hinhanh)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_role
            // 
            this.lb_role.AutoSize = true;
            this.lb_role.Location = new System.Drawing.Point(22, 17);
            this.lb_role.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_role.Name = "lb_role";
            this.lb_role.Size = new System.Drawing.Size(110, 24);
            this.lb_role.TabIndex = 2;
            this.lb_role.Text = "Người dùng";
            // 
            // tb_search
            // 
            this.tb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search.Location = new System.Drawing.Point(1010, 12);
            this.tb_search.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(229, 29);
            this.tb_search.TabIndex = 3;
            // 
            // lb_search
            // 
            this.lb_search.AutoSize = true;
            this.lb_search.Location = new System.Drawing.Point(911, 17);
            this.lb_search.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_search.Name = "lb_search";
            this.lb_search.Size = new System.Drawing.Size(87, 24);
            this.lb_search.TabIndex = 4;
            this.lb_search.Text = "Tìm kiếm";
            // 
            // lb_masv
            // 
            this.lb_masv.AutoSize = true;
            this.lb_masv.Location = new System.Drawing.Point(96, 116);
            this.lb_masv.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_masv.Name = "lb_masv";
            this.lb_masv.Size = new System.Drawing.Size(66, 24);
            this.lb_masv.TabIndex = 5;
            this.lb_masv.Text = "Mã SV";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSV,
            this.hoTen,
            this.email,
            this.soDT,
            this.gioiTinh,
            this.diaChi,
            this.hinh,
            this.tiengAnh,
            this.tinHoc,
            this.gdtc,
            this.diemTB});
            this.dataGridView1.Location = new System.Drawing.Point(15, 466);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1227, 203);
            this.dataGridView1.TabIndex = 6;
            // 
            // maSV
            // 
            this.maSV.HeaderText = "Mã sinh viên";
            this.maSV.Name = "maSV";
            // 
            // hoTen
            // 
            this.hoTen.HeaderText = "Họ tên";
            this.hoTen.Name = "hoTen";
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // soDT
            // 
            this.soDT.HeaderText = "Số điện thoại";
            this.soDT.Name = "soDT";
            // 
            // gioiTinh
            // 
            this.gioiTinh.HeaderText = "Giới tính";
            this.gioiTinh.Name = "gioiTinh";
            // 
            // diaChi
            // 
            this.diaChi.HeaderText = "Địa chỉ";
            this.diaChi.Name = "diaChi";
            // 
            // hinh
            // 
            this.hinh.HeaderText = "Hình";
            this.hinh.Name = "hinh";
            // 
            // tiengAnh
            // 
            this.tiengAnh.HeaderText = "Tiếng Anh";
            this.tiengAnh.Name = "tiengAnh";
            this.tiengAnh.Visible = false;
            // 
            // tinHoc
            // 
            this.tinHoc.HeaderText = "Tin Học";
            this.tinHoc.Name = "tinHoc";
            this.tinHoc.Visible = false;
            // 
            // gdtc
            // 
            this.gdtc.HeaderText = "GDTC";
            this.gdtc.Name = "gdtc";
            this.gdtc.Visible = false;
            // 
            // diemTB
            // 
            this.diemTB.HeaderText = "Điểm TB";
            this.diemTB.Name = "diemTB";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(40, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Giới tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Địa chỉ";
            // 
            // tb_masv
            // 
            this.tb_masv.Location = new System.Drawing.Point(237, 111);
            this.tb_masv.Name = "tb_masv";
            this.tb_masv.Size = new System.Drawing.Size(144, 29);
            this.tb_masv.TabIndex = 11;
            // 
            // tb_hoten
            // 
            this.tb_hoten.Location = new System.Drawing.Point(237, 148);
            this.tb_hoten.Name = "tb_hoten";
            this.tb_hoten.Size = new System.Drawing.Size(144, 29);
            this.tb_hoten.TabIndex = 12;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(237, 189);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(144, 29);
            this.tb_email.TabIndex = 13;
            // 
            // tb_sdt
            // 
            this.tb_sdt.Location = new System.Drawing.Point(237, 224);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(144, 29);
            this.tb_sdt.TabIndex = 14;
            // 
            // tb_diachi
            // 
            this.tb_diachi.Location = new System.Drawing.Point(237, 294);
            this.tb_diachi.Name = "tb_diachi";
            this.tb_diachi.Size = new System.Drawing.Size(144, 96);
            this.tb_diachi.TabIndex = 16;
            this.tb_diachi.Text = "";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(237, 264);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(68, 28);
            this.radioButton1.TabIndex = 17;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nam";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(328, 264);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(53, 28);
            this.radioButton2.TabIndex = 18;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Nữ";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // px_hinhanh
            // 
            this.px_hinhanh.Image = global::Assignment.Properties.Resources._1;
            this.px_hinhanh.Location = new System.Drawing.Point(536, 111);
            this.px_hinhanh.Name = "px_hinhanh";
            this.px_hinhanh.Size = new System.Drawing.Size(140, 142);
            this.px_hinhanh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.px_hinhanh.TabIndex = 19;
            this.px_hinhanh.TabStop = false;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(781, 97);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(88, 43);
            this.btn_them.TabIndex = 20;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(915, 97);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(88, 43);
            this.btn_luu.TabIndex = 21;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(781, 210);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(88, 43);
            this.btn_xoa.TabIndex = 22;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(915, 210);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(88, 43);
            this.btn_sua.TabIndex = 23;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 681);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.px_hinhanh);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.tb_diachi);
            this.Controls.Add(this.tb_sdt);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_hoten);
            this.Controls.Add(this.tb_masv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lb_masv);
            this.Controls.Add(this.lb_search);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.lb_role);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang Chủ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.px_hinhanh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_role;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Label lb_search;
        private System.Windows.Forms.Label lb_masv;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn hinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiengAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn gdtc;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_masv;
        private System.Windows.Forms.TextBox tb_hoten;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_sdt;
        private System.Windows.Forms.RichTextBox tb_diachi;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.PictureBox px_hinhanh;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
    }
}