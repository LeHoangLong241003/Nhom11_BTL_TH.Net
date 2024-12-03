namespace QuanLyThuePhongNhaNghi
{
    partial class ThuePhong
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.thuePDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tennv = new System.Windows.Forms.TextBox();
            this.btnthuep = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnchonp = new System.Windows.Forms.Button();
            this.cbb_loaip = new System.Windows.Forms.ComboBox();
            this.phongDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnthemk = new System.Windows.Forms.Button();
            this.btnchonk = new System.Windows.Forms.Button();
            this.txtcccd = new System.Windows.Forms.TextBox();
            this.khachDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thuePDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phongDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khachDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.thuePDataGridView);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txt_tennv);
            this.groupBox3.Controls.Add(this.btnthuep);
            this.groupBox3.Font = new System.Drawing.Font("Times", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 454);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1104, 213);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách thuê phòng";
            // 
            // thuePDataGridView
            // 
            this.thuePDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.thuePDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.thuePDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.thuePDataGridView.Location = new System.Drawing.Point(18, 35);
            this.thuePDataGridView.Name = "thuePDataGridView";
            this.thuePDataGridView.ReadOnly = true;
            this.thuePDataGridView.RowHeadersWidth = 62;
            this.thuePDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.thuePDataGridView.Size = new System.Drawing.Size(895, 172);
            this.thuePDataGridView.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(944, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhân viên";
            // 
            // txt_tennv
            // 
            this.txt_tennv.Font = new System.Drawing.Font("Times", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tennv.Location = new System.Drawing.Point(937, 61);
            this.txt_tennv.Name = "txt_tennv";
            this.txt_tennv.Size = new System.Drawing.Size(143, 38);
            this.txt_tennv.TabIndex = 3;
            // 
            // btnthuep
            // 
            this.btnthuep.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthuep.Location = new System.Drawing.Point(937, 148);
            this.btnthuep.Name = "btnthuep";
            this.btnthuep.Size = new System.Drawing.Size(140, 45);
            this.btnthuep.TabIndex = 1;
            this.btnthuep.Text = "Thuê phòng";
            this.btnthuep.UseVisualStyleBackColor = true;
            this.btnthuep.Click += new System.EventHandler(this.btnthuep_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnchonp);
            this.groupBox2.Controls.Add(this.cbb_loaip);
            this.groupBox2.Controls.Add(this.phongDataGridView);
            this.groupBox2.Font = new System.Drawing.Font("Times", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 242);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1104, 206);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin phòng thuê";
            // 
            // btnchonp
            // 
            this.btnchonp.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchonp.Location = new System.Drawing.Point(943, 127);
            this.btnchonp.Name = "btnchonp";
            this.btnchonp.Size = new System.Drawing.Size(140, 45);
            this.btnchonp.TabIndex = 5;
            this.btnchonp.Text = "Chọn";
            this.btnchonp.UseVisualStyleBackColor = true;
            this.btnchonp.Click += new System.EventHandler(this.btnchonp_Click);
            // 
            // cbb_loaip
            // 
            this.cbb_loaip.Font = new System.Drawing.Font("Times", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_loaip.FormattingEnabled = true;
            this.cbb_loaip.Items.AddRange(new object[] {
            "Đơn thường",
            "Đôi thường",
            "Ba thường",
            "VIP đơn",
            "VIP đôi",
            "VIP ba"});
            this.cbb_loaip.Location = new System.Drawing.Point(940, 49);
            this.cbb_loaip.Name = "cbb_loaip";
            this.cbb_loaip.Size = new System.Drawing.Size(143, 39);
            this.cbb_loaip.TabIndex = 2;
            this.cbb_loaip.Text = " Chọn loại ";
            this.cbb_loaip.SelectedIndexChanged += new System.EventHandler(this.cbb_loaip_SelectedIndexChanged);
            // 
            // phongDataGridView
            // 
            this.phongDataGridView.AllowUserToAddRows = false;
            this.phongDataGridView.AllowUserToDeleteRows = false;
            this.phongDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.phongDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.phongDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phongDataGridView.Location = new System.Drawing.Point(21, 35);
            this.phongDataGridView.Name = "phongDataGridView";
            this.phongDataGridView.RowHeadersWidth = 62;
            this.phongDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.phongDataGridView.Size = new System.Drawing.Size(892, 165);
            this.phongDataGridView.TabIndex = 0;
            this.phongDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.phongDataGridView_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnthemk);
            this.groupBox1.Controls.Add(this.btnchonk);
            this.groupBox1.Controls.Add(this.txtcccd);
            this.groupBox1.Controls.Add(this.khachDataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Times", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1104, 207);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // btnthemk
            // 
            this.btnthemk.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthemk.Location = new System.Drawing.Point(943, 93);
            this.btnthemk.Name = "btnthemk";
            this.btnthemk.Size = new System.Drawing.Size(140, 45);
            this.btnthemk.TabIndex = 7;
            this.btnthemk.Text = "Thêm";
            this.btnthemk.UseVisualStyleBackColor = true;
            this.btnthemk.Click += new System.EventHandler(this.btnthemk_Click);
            // 
            // btnchonk
            // 
            this.btnchonk.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchonk.Location = new System.Drawing.Point(943, 144);
            this.btnchonk.Name = "btnchonk";
            this.btnchonk.Size = new System.Drawing.Size(140, 45);
            this.btnchonk.TabIndex = 6;
            this.btnchonk.Text = "Chọn";
            this.btnchonk.UseVisualStyleBackColor = true;
            this.btnchonk.Click += new System.EventHandler(this.btnchonk_Click);
            // 
            // txtcccd
            // 
            this.txtcccd.Font = new System.Drawing.Font("Times", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcccd.Location = new System.Drawing.Point(940, 32);
            this.txtcccd.Name = "txtcccd";
            this.txtcccd.Size = new System.Drawing.Size(143, 38);
            this.txtcccd.TabIndex = 2;
            // 
            // khachDataGridView
            // 
            this.khachDataGridView.AllowUserToAddRows = false;
            this.khachDataGridView.AllowUserToDeleteRows = false;
            this.khachDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.khachDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.khachDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.khachDataGridView.Location = new System.Drawing.Point(18, 32);
            this.khachDataGridView.Name = "khachDataGridView";
            this.khachDataGridView.RowHeadersWidth = 62;
            this.khachDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.khachDataGridView.Size = new System.Drawing.Size(893, 164);
            this.khachDataGridView.TabIndex = 0;
            this.khachDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.khachDataGridView_CellContentClick);
            // 
            // ThuePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1128, 679);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ThuePhong";
            this.Text = "ThuePhong";
            this.Load += new System.EventHandler(this.ThuePhong_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thuePDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.phongDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khachDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView thuePDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tennv;
        private System.Windows.Forms.Button btnthuep;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbb_loaip;
        private System.Windows.Forms.DataGridView phongDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtcccd;
        private System.Windows.Forms.DataGridView khachDataGridView;
        private System.Windows.Forms.Button btnchonp;
        private System.Windows.Forms.Button btnthemk;
        private System.Windows.Forms.Button btnchonk;
    }
}