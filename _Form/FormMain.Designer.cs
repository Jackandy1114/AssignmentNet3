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
            this.grid_dsSV = new System.Windows.Forms.DataGridView();
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
            this.rd_male = new System.Windows.Forms.RadioButton();
            this.rd_female = new System.Windows.Forms.RadioButton();
            this.px_hinhanh = new System.Windows.Forms.PictureBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.tb_tiengAnh = new System.Windows.Forms.TextBox();
            this.tb_tinHoc = new System.Windows.Forms.TextBox();
            this.tb_gdtc = new System.Windows.Forms.TextBox();
            this.tb_diemTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.grid_dsSV)).BeginInit();
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
            this.tb_search.Margin = new System.Windows.Forms.Padding(6);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(229, 29);
            this.tb_search.TabIndex = 3;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
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
            // grid_dsSV
            // 
            this.grid_dsSV.AllowUserToAddRows = false;
            this.grid_dsSV.AllowUserToDeleteRows = false;
            this.grid_dsSV.AllowUserToOrderColumns = true;
            this.grid_dsSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_dsSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.grid_dsSV.Location = new System.Drawing.Point(15, 466);
            this.grid_dsSV.Name = "grid_dsSV";
            this.grid_dsSV.ReadOnly = true;
            this.grid_dsSV.Size = new System.Drawing.Size(1227, 203);
            this.grid_dsSV.TabIndex = 6;
         
            this.grid_dsSV.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_dsSV_CellEnter);
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
            this.tb_masv.Size = new System.Drawing.Size(242, 29);
            this.tb_masv.TabIndex = 11;
            // 
            // tb_hoten
            // 
            this.tb_hoten.Location = new System.Drawing.Point(237, 148);
            this.tb_hoten.Name = "tb_hoten";
            this.tb_hoten.Size = new System.Drawing.Size(242, 29);
            this.tb_hoten.TabIndex = 12;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(237, 189);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(242, 29);
            this.tb_email.TabIndex = 13;
            // 
            // tb_sdt
            // 
            this.tb_sdt.Location = new System.Drawing.Point(237, 224);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(242, 29);
            this.tb_sdt.TabIndex = 14;
            // 
            // tb_diachi
            // 
            this.tb_diachi.Location = new System.Drawing.Point(237, 294);
            this.tb_diachi.Name = "tb_diachi";
            this.tb_diachi.Size = new System.Drawing.Size(191, 136);
            this.tb_diachi.TabIndex = 16;
            this.tb_diachi.Text = "";
            // 
            // rd_male
            // 
            this.rd_male.AutoSize = true;
            this.rd_male.Checked = true;
            this.rd_male.Location = new System.Drawing.Point(237, 264);
            this.rd_male.Name = "rd_male";
            this.rd_male.Size = new System.Drawing.Size(68, 28);
            this.rd_male.TabIndex = 17;
            this.rd_male.TabStop = true;
            this.rd_male.Text = "Nam";
            this.rd_male.UseVisualStyleBackColor = true;
            this.rd_male.CheckedChanged += new System.EventHandler(this.rd_male_CheckedChanged);
            // 
            // rd_female
            // 
            this.rd_female.AutoSize = true;
            this.rd_female.Location = new System.Drawing.Point(328, 264);
            this.rd_female.Name = "rd_female";
            this.rd_female.Size = new System.Drawing.Size(53, 28);
            this.rd_female.TabIndex = 18;
            this.rd_female.Text = "Nữ";
            this.rd_female.UseVisualStyleBackColor = true;
            // 
            // px_hinhanh
            // 
            this.px_hinhanh.Image = global::Assignment.Properties.Resources._1;
            this.px_hinhanh.Location = new System.Drawing.Point(485, 111);
            this.px_hinhanh.Name = "px_hinhanh";
            this.px_hinhanh.Size = new System.Drawing.Size(195, 179);
            this.px_hinhanh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
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
            // tb_tiengAnh
            // 
            this.tb_tiengAnh.Location = new System.Drawing.Point(536, 296);
            this.tb_tiengAnh.Name = "tb_tiengAnh";
            this.tb_tiengAnh.Size = new System.Drawing.Size(144, 29);
            this.tb_tiengAnh.TabIndex = 24;
            // 
            // tb_tinHoc
            // 
            this.tb_tinHoc.Location = new System.Drawing.Point(536, 331);
            this.tb_tinHoc.Name = "tb_tinHoc";
            this.tb_tinHoc.Size = new System.Drawing.Size(144, 29);
            this.tb_tinHoc.TabIndex = 25;
            // 
            // tb_gdtc
            // 
            this.tb_gdtc.Location = new System.Drawing.Point(536, 366);
            this.tb_gdtc.Name = "tb_gdtc";
            this.tb_gdtc.Size = new System.Drawing.Size(144, 29);
            this.tb_gdtc.TabIndex = 26;
            // 
            // tb_diemTb
            // 
            this.tb_diemTb.Location = new System.Drawing.Point(536, 401);
            this.tb_diemTb.Name = "tb_diemTb";
            this.tb_diemTb.Size = new System.Drawing.Size(144, 29);
            this.tb_diemTb.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(434, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 24);
            this.label6.TabIndex = 28;
            this.label6.Text = "Tiếng anh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(456, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 24);
            this.label7.TabIndex = 29;
            this.label7.Text = "Tin học";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(468, 371);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 24);
            this.label8.TabIndex = 30;
            this.label8.Text = "GDTC";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(447, 406);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 24);
            this.label9.TabIndex = 31;
            this.label9.Text = "Điểm TB";
            // 
            // maSV
            // 
            this.maSV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maSV.DataPropertyName = "maSV";
            this.maSV.FillWeight = 304.5685F;
            this.maSV.HeaderText = "Mã sinh viên";
            this.maSV.MinimumWidth = 100;
            this.maSV.Name = "maSV";
            this.maSV.ReadOnly = true;
            // 
            // hoTen
            // 
            this.hoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hoTen.DataPropertyName = "hoTen";
            this.hoTen.FillWeight = 257.9662F;
            this.hoTen.HeaderText = "Họ tên";
            this.hoTen.MinimumWidth = 200;
            this.hoTen.Name = "hoTen";
            this.hoTen.ReadOnly = true;
            this.hoTen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.email.DataPropertyName = "email";
            this.email.FillWeight = 32.76281F;
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 250;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // soDT
            // 
            this.soDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.soDT.DataPropertyName = "soDT";
            this.soDT.FillWeight = 3.648585F;
            this.soDT.HeaderText = "Số điện thoại";
            this.soDT.MinimumWidth = 150;
            this.soDT.Name = "soDT";
            this.soDT.ReadOnly = true;
            this.soDT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // gioiTinh
            // 
            this.gioiTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gioiTinh.DataPropertyName = "gioiTinh";
            this.gioiTinh.HeaderText = "Giới tính";
            this.gioiTinh.Name = "gioiTinh";
            this.gioiTinh.ReadOnly = true;
            this.gioiTinh.Visible = false;
            // 
            // diaChi
            // 
            this.diaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.diaChi.DataPropertyName = "diaChi";
            this.diaChi.FillWeight = 1.024138F;
            this.diaChi.HeaderText = "Địa chỉ";
            this.diaChi.MinimumWidth = 250;
            this.diaChi.Name = "diaChi";
            this.diaChi.ReadOnly = true;
            // 
            // hinh
            // 
            this.hinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hinh.DataPropertyName = "hinh";
            this.hinh.HeaderText = "Hình";
            this.hinh.Name = "hinh";
            this.hinh.ReadOnly = true;
            this.hinh.Visible = false;
            // 
            // tiengAnh
            // 
            this.tiengAnh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tiengAnh.DataPropertyName = "tiengAnh";
            this.tiengAnh.HeaderText = "Tiếng Anh";
            this.tiengAnh.MinimumWidth = 75;
            this.tiengAnh.Name = "tiengAnh";
            this.tiengAnh.ReadOnly = true;
            this.tiengAnh.Visible = false;
            // 
            // tinHoc
            // 
            this.tinHoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tinHoc.DataPropertyName = "tinHoc";
            this.tinHoc.HeaderText = "Tin Học";
            this.tinHoc.MinimumWidth = 75;
            this.tinHoc.Name = "tinHoc";
            this.tinHoc.ReadOnly = true;
            this.tinHoc.Visible = false;
            // 
            // gdtc
            // 
            this.gdtc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gdtc.DataPropertyName = "gdtc";
            this.gdtc.HeaderText = "GDTC";
            this.gdtc.MinimumWidth = 75;
            this.gdtc.Name = "gdtc";
            this.gdtc.ReadOnly = true;
            this.gdtc.Visible = false;
            // 
            // diemTB
            // 
            this.diemTB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.diemTB.DataPropertyName = "diemTB";
            this.diemTB.FillWeight = 0.02977145F;
            this.diemTB.HeaderText = "Điểm TB";
            this.diemTB.MinimumWidth = 100;
            this.diemTB.Name = "diemTB";
            this.diemTB.ReadOnly = true;
            this.diemTB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 681);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_diemTb);
            this.Controls.Add(this.tb_gdtc);
            this.Controls.Add(this.tb_tinHoc);
            this.Controls.Add(this.tb_tiengAnh);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.px_hinhanh);
            this.Controls.Add(this.rd_female);
            this.Controls.Add(this.rd_male);
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
            this.Controls.Add(this.grid_dsSV);
            this.Controls.Add(this.lb_masv);
            this.Controls.Add(this.lb_search);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.lb_role);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang Chủ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_dsSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.px_hinhanh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_role;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Label lb_search;
        private System.Windows.Forms.Label lb_masv;
        private System.Windows.Forms.DataGridView grid_dsSV;
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
        private System.Windows.Forms.RadioButton rd_male;
        private System.Windows.Forms.RadioButton rd_female;
        private System.Windows.Forms.PictureBox px_hinhanh;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.TextBox tb_tiengAnh;
        private System.Windows.Forms.TextBox tb_tinHoc;
        private System.Windows.Forms.TextBox tb_gdtc;
        private System.Windows.Forms.TextBox tb_diemTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
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
    }
}