namespace QuanLyThuePhongNhaNghi
{
    partial class Phong
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
            System.Windows.Forms.Label tinhtrangLabel;
            System.Windows.Forms.Label giaPLabel1;
            System.Windows.Forms.Label loaiPLabel1;
            System.Windows.Forms.Label maPLabel1;
            System.Windows.Forms.Label tenPLabel1;
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.danhsachphong = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.cbtinhtrang = new System.Windows.Forms.ComboBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.txtgiap = new System.Windows.Forms.TextBox();
            this.cbloaip = new System.Windows.Forms.ComboBox();
            this.txtmap = new System.Windows.Forms.TextBox();
            this.txttenp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            tinhtrangLabel = new System.Windows.Forms.Label();
            giaPLabel1 = new System.Windows.Forms.Label();
            loaiPLabel1 = new System.Windows.Forms.Label();
            maPLabel1 = new System.Windows.Forms.Label();
            tenPLabel1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachphong)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tinhtrangLabel
            // 
            tinhtrangLabel.AutoSize = true;
            tinhtrangLabel.Location = new System.Drawing.Point(625, 102);
            tinhtrangLabel.Name = "tinhtrangLabel";
            tinhtrangLabel.Size = new System.Drawing.Size(126, 31);
            tinhtrangLabel.TabIndex = 12;
            tinhtrangLabel.Text = "Tình trạng";
            // 
            // giaPLabel1
            // 
            giaPLabel1.AutoSize = true;
            giaPLabel1.Location = new System.Drawing.Point(627, 45);
            giaPLabel1.Name = "giaPLabel1";
            giaPLabel1.Size = new System.Drawing.Size(124, 31);
            giaPLabel1.TabIndex = 0;
            giaPLabel1.Text = "Giá phòng";
            // 
            // loaiPLabel1
            // 
            loaiPLabel1.AutoSize = true;
            loaiPLabel1.Location = new System.Drawing.Point(45, 155);
            loaiPLabel1.Name = "loaiPLabel1";
            loaiPLabel1.Size = new System.Drawing.Size(135, 31);
            loaiPLabel1.TabIndex = 2;
            loaiPLabel1.Text = "Loại phòng";
            // 
            // maPLabel1
            // 
            maPLabel1.AutoSize = true;
            maPLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maPLabel1.Location = new System.Drawing.Point(46, 53);
            maPLabel1.Name = "maPLabel1";
            maPLabel1.Size = new System.Drawing.Size(116, 26);
            maPLabel1.TabIndex = 4;
            maPLabel1.Text = "Mã phòng";
            // 
            // tenPLabel1
            // 
            tenPLabel1.AutoSize = true;
            tenPLabel1.Location = new System.Drawing.Point(45, 102);
            tenPLabel1.Name = "tenPLabel1";
            tenPLabel1.Size = new System.Drawing.Size(127, 31);
            tenPLabel1.TabIndex = 6;
            tenPLabel1.Text = "Tên phòng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.danhsachphong);
            this.groupBox2.Font = new System.Drawing.Font("Times", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(37, 380);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1057, 293);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách phòng thuê";
            // 
            // danhsachphong
            // 
            this.danhsachphong.AllowUserToAddRows = false;
            this.danhsachphong.AllowUserToDeleteRows = false;
            this.danhsachphong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.danhsachphong.BackgroundColor = System.Drawing.SystemColors.Window;
            this.danhsachphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danhsachphong.Location = new System.Drawing.Point(20, 42);
            this.danhsachphong.Name = "danhsachphong";
            this.danhsachphong.RowHeadersWidth = 62;
            this.danhsachphong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.danhsachphong.Size = new System.Drawing.Size(1018, 232);
            this.danhsachphong.TabIndex = 0;
            this.danhsachphong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.danhsachphong_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnthoat);
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Controls.Add(this.btnsua);
            this.groupBox1.Controls.Add(tinhtrangLabel);
            this.groupBox1.Controls.Add(this.cbtinhtrang);
            this.groupBox1.Controls.Add(this.btnthem);
            this.groupBox1.Controls.Add(giaPLabel1);
            this.groupBox1.Controls.Add(this.txtgiap);
            this.groupBox1.Controls.Add(loaiPLabel1);
            this.groupBox1.Controls.Add(this.cbloaip);
            this.groupBox1.Controls.Add(maPLabel1);
            this.groupBox1.Controls.Add(this.txtmap);
            this.groupBox1.Controls.Add(tenPLabel1);
            this.groupBox1.Controls.Add(this.txttenp);
            this.groupBox1.Font = new System.Drawing.Font("Times", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(37, 81);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1057, 292);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phòng";
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.SystemColors.Info;
            this.btnthoat.Location = new System.Drawing.Point(823, 213);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(159, 58);
            this.btnthoat.TabIndex = 16;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.SystemColors.Info;
            this.btnxoa.Location = new System.Drawing.Point(573, 213);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(159, 58);
            this.btnxoa.TabIndex = 15;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.SystemColors.Info;
            this.btnsua.Location = new System.Drawing.Point(321, 213);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(159, 58);
            this.btnsua.TabIndex = 14;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // cbtinhtrang
            // 
            this.cbtinhtrang.BackColor = System.Drawing.SystemColors.Window;
            this.cbtinhtrang.FormattingEnabled = true;
            this.cbtinhtrang.Items.AddRange(new object[] {
            "Trống",
            "Có khách"});
            this.cbtinhtrang.Location = new System.Drawing.Point(766, 99);
            this.cbtinhtrang.Name = "cbtinhtrang";
            this.cbtinhtrang.Size = new System.Drawing.Size(236, 39);
            this.cbtinhtrang.TabIndex = 13;
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.SystemColors.Info;
            this.btnthem.Location = new System.Drawing.Point(76, 213);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(159, 58);
            this.btnthem.TabIndex = 8;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txtgiap
            // 
            this.txtgiap.BackColor = System.Drawing.SystemColors.Window;
            this.txtgiap.Location = new System.Drawing.Point(766, 42);
            this.txtgiap.Name = "txtgiap";
            this.txtgiap.Size = new System.Drawing.Size(236, 38);
            this.txtgiap.TabIndex = 1;
            // 
            // cbloaip
            // 
            this.cbloaip.BackColor = System.Drawing.SystemColors.Window;
            this.cbloaip.FormattingEnabled = true;
            this.cbloaip.Items.AddRange(new object[] {
            "Đơn thường",
            "Đôi thường",
            "Ba thường",
            "VIP đơn",
            "VIP đôi",
            "VIP ba"});
            this.cbloaip.Location = new System.Drawing.Point(185, 152);
            this.cbloaip.Name = "cbloaip";
            this.cbloaip.Size = new System.Drawing.Size(236, 39);
            this.cbloaip.TabIndex = 3;
            // 
            // txtmap
            // 
            this.txtmap.BackColor = System.Drawing.SystemColors.Window;
            this.txtmap.Location = new System.Drawing.Point(185, 45);
            this.txtmap.Name = "txtmap";
            this.txtmap.Size = new System.Drawing.Size(236, 38);
            this.txtmap.TabIndex = 5;
            // 
            // txttenp
            // 
            this.txttenp.BackColor = System.Drawing.SystemColors.Window;
            this.txttenp.Location = new System.Drawing.Point(185, 99);
            this.txttenp.Name = "txttenp";
            this.txttenp.Size = new System.Drawing.Size(236, 38);
            this.txttenp.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(580, 55);
            this.label1.TabIndex = 13;
            this.label1.Text = "QUẢN LÝ PHÒNG THUÊ";
            // 
            // Phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1131, 704);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Phong";
            this.Text = "Phong";
            this.Load += new System.EventHandler(this.Phong_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.danhsachphong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView danhsachphong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbtinhtrang;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txtgiap;
        private System.Windows.Forms.ComboBox cbloaip;
        private System.Windows.Forms.TextBox txtmap;
        private System.Windows.Forms.TextBox txttenp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
    }
}