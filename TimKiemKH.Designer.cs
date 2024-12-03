namespace QuanLyThuePhongNhaNghi
{
    partial class TimKiemKH
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gv_ketqua = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_Timkiem = new System.Windows.Forms.Button();
            this.txttimkiemkh = new System.Windows.Forms.TextBox();
            this.rbt_tenkh = new System.Windows.Forms.RadioButton();
            this.rbt_cmt = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ketqua)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gv_ketqua);
            this.groupBox2.Font = new System.Drawing.Font("Times", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(27, 320);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1067, 285);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả tìm kiếm";
            // 
            // gv_ketqua
            // 
            this.gv_ketqua.AllowUserToAddRows = false;
            this.gv_ketqua.AllowUserToDeleteRows = false;
            this.gv_ketqua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_ketqua.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gv_ketqua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_ketqua.Location = new System.Drawing.Point(30, 35);
            this.gv_ketqua.Name = "gv_ketqua";
            this.gv_ketqua.ReadOnly = true;
            this.gv_ketqua.RowHeadersWidth = 62;
            this.gv_ketqua.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_ketqua.Size = new System.Drawing.Size(1008, 232);
            this.gv_ketqua.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(826, 51);
            this.label1.TabIndex = 4;
            this.label1.Text = "TÌM KIẾM THÔNG TIN KHÁCH HÀNG";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_thoat);
            this.groupBox1.Controls.Add(this.btn_Timkiem);
            this.groupBox1.Controls.Add(this.txttimkiemkh);
            this.groupBox1.Controls.Add(this.rbt_tenkh);
            this.groupBox1.Controls.Add(this.rbt_cmt);
            this.groupBox1.Font = new System.Drawing.Font("Times", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1067, 201);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // btn_thoat
            // 
            this.btn_thoat.AutoSize = true;
            this.btn_thoat.Location = new System.Drawing.Point(795, 104);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(137, 43);
            this.btn_thoat.TabIndex = 4;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_Timkiem
            // 
            this.btn_Timkiem.AutoSize = true;
            this.btn_Timkiem.Location = new System.Drawing.Point(505, 104);
            this.btn_Timkiem.Name = "btn_Timkiem";
            this.btn_Timkiem.Size = new System.Drawing.Size(137, 43);
            this.btn_Timkiem.TabIndex = 3;
            this.btn_Timkiem.Text = "Tìm kiếm";
            this.btn_Timkiem.UseVisualStyleBackColor = true;
            // 
            // txttimkiemkh
            // 
            this.txttimkiemkh.Location = new System.Drawing.Point(505, 53);
            this.txttimkiemkh.Name = "txttimkiemkh";
            this.txttimkiemkh.Size = new System.Drawing.Size(427, 36);
            this.txttimkiemkh.TabIndex = 2;
            // 
            // rbt_tenkh
            // 
            this.rbt_tenkh.AutoSize = true;
            this.rbt_tenkh.Location = new System.Drawing.Point(111, 104);
            this.rbt_tenkh.Name = "rbt_tenkh";
            this.rbt_tenkh.Size = new System.Drawing.Size(243, 33);
            this.rbt_tenkh.TabIndex = 1;
            this.rbt_tenkh.TabStop = true;
            this.rbt_tenkh.Text = "Theo tên khách hàng";
            this.rbt_tenkh.UseVisualStyleBackColor = true;
            // 
            // rbt_cmt
            // 
            this.rbt_cmt.AutoSize = true;
            this.rbt_cmt.Location = new System.Drawing.Point(111, 54);
            this.rbt_cmt.Name = "rbt_cmt";
            this.rbt_cmt.Size = new System.Drawing.Size(194, 33);
            this.rbt_cmt.TabIndex = 0;
            this.rbt_cmt.TabStop = true;
            this.rbt_cmt.Text = "Theo số CMND";
            this.rbt_cmt.UseVisualStyleBackColor = true;
            // 
            // TimKiemKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1126, 650);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "TimKiemKH";
            this.Text = "TimKiemKH";
            this.Load += new System.EventHandler(this.TimKiemKH_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_ketqua)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gv_ketqua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_Timkiem;
        private System.Windows.Forms.TextBox txttimkiemkh;
        private System.Windows.Forms.RadioButton rbt_tenkh;
        private System.Windows.Forms.RadioButton rbt_cmt;
    }
}