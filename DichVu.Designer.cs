namespace QuanLyThuePhongNhaNghi
{
    partial class DichVu
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
            System.Windows.Forms.Label dVTLabel;
            System.Windows.Forms.Label txtgiadv;
            System.Windows.Forms.Label maDVLabel;
            System.Windows.Forms.Label tenDVLabel;
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dichvuDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtdvt = new System.Windows.Forms.TextBox();
            this.txt_gia = new System.Windows.Forms.TextBox();
            this.txtmadv = new System.Windows.Forms.TextBox();
            this.txttendv = new System.Windows.Forms.TextBox();
            this.btnthoatdv = new System.Windows.Forms.Button();
            this.btnxoadv = new System.Windows.Forms.Button();
            this.btnsuadv = new System.Windows.Forms.Button();
            this.btnthemdv = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            dVTLabel = new System.Windows.Forms.Label();
            txtgiadv = new System.Windows.Forms.Label();
            maDVLabel = new System.Windows.Forms.Label();
            tenDVLabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dichvuDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dVTLabel
            // 
            dVTLabel.AutoSize = true;
            dVTLabel.Location = new System.Drawing.Point(582, 56);
            dVTLabel.Name = "dVTLabel";
            dVTLabel.Size = new System.Drawing.Size(125, 29);
            dVTLabel.TabIndex = 8;
            dVTLabel.Text = "Đơn vị tính";
            // 
            // txtgiadv
            // 
            txtgiadv.AutoSize = true;
            txtgiadv.Location = new System.Drawing.Point(582, 116);
            txtgiadv.Name = "txtgiadv";
            txtgiadv.Size = new System.Drawing.Size(128, 29);
            txtgiadv.TabIndex = 10;
            txtgiadv.Text = "Giá dịch vụ";
            // 
            // maDVLabel
            // 
            maDVLabel.AutoSize = true;
            maDVLabel.Location = new System.Drawing.Point(74, 56);
            maDVLabel.Name = "maDVLabel";
            maDVLabel.Size = new System.Drawing.Size(125, 29);
            maDVLabel.TabIndex = 12;
            maDVLabel.Text = "Mã dịch vụ";
            // 
            // tenDVLabel
            // 
            tenDVLabel.AutoSize = true;
            tenDVLabel.Location = new System.Drawing.Point(74, 116);
            tenDVLabel.Name = "tenDVLabel";
            tenDVLabel.Size = new System.Drawing.Size(130, 29);
            tenDVLabel.TabIndex = 14;
            tenDVLabel.Text = "Tên dịch vụ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dichvuDataGridView);
            this.groupBox2.Font = new System.Drawing.Font("Times", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(31, 404);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1065, 271);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách dịch vụ";
            // 
            // dichvuDataGridView
            // 
            this.dichvuDataGridView.AllowUserToAddRows = false;
            this.dichvuDataGridView.AllowUserToDeleteRows = false;
            this.dichvuDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dichvuDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dichvuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dichvuDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dichvuDataGridView.Location = new System.Drawing.Point(3, 32);
            this.dichvuDataGridView.Name = "dichvuDataGridView";
            this.dichvuDataGridView.ReadOnly = true;
            this.dichvuDataGridView.RowHeadersWidth = 62;
            this.dichvuDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dichvuDataGridView.Size = new System.Drawing.Size(1059, 236);
            this.dichvuDataGridView.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(dVTLabel);
            this.groupBox1.Controls.Add(this.txtdvt);
            this.groupBox1.Controls.Add(txtgiadv);
            this.groupBox1.Controls.Add(this.txt_gia);
            this.groupBox1.Controls.Add(maDVLabel);
            this.groupBox1.Controls.Add(this.txtmadv);
            this.groupBox1.Controls.Add(tenDVLabel);
            this.groupBox1.Controls.Add(this.txttendv);
            this.groupBox1.Controls.Add(this.btnthoatdv);
            this.groupBox1.Controls.Add(this.btnxoadv);
            this.groupBox1.Controls.Add(this.btnsuadv);
            this.groupBox1.Controls.Add(this.btnthemdv);
            this.groupBox1.Font = new System.Drawing.Font("Times", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 107);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1062, 269);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin dịch vụ";
            // 
            // txtdvt
            // 
            this.txtdvt.Location = new System.Drawing.Point(746, 53);
            this.txtdvt.Name = "txtdvt";
            this.txtdvt.Size = new System.Drawing.Size(238, 36);
            this.txtdvt.TabIndex = 9;
            // 
            // txt_gia
            // 
            this.txt_gia.Location = new System.Drawing.Point(746, 113);
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.Size = new System.Drawing.Size(238, 36);
            this.txt_gia.TabIndex = 11;
            // 
            // txtmadv
            // 
            this.txtmadv.Location = new System.Drawing.Point(233, 53);
            this.txtmadv.Name = "txtmadv";
            this.txtmadv.Size = new System.Drawing.Size(238, 36);
            this.txtmadv.TabIndex = 13;
            // 
            // txttendv
            // 
            this.txttendv.Location = new System.Drawing.Point(233, 113);
            this.txttendv.Name = "txttendv";
            this.txttendv.Size = new System.Drawing.Size(238, 36);
            this.txttendv.TabIndex = 15;
            // 
            // btnthoatdv
            // 
            this.btnthoatdv.BackColor = System.Drawing.SystemColors.Info;
            this.btnthoatdv.Location = new System.Drawing.Point(840, 187);
            this.btnthoatdv.Name = "btnthoatdv";
            this.btnthoatdv.Size = new System.Drawing.Size(144, 51);
            this.btnthoatdv.TabIndex = 8;
            this.btnthoatdv.Text = "Thoát";
            this.btnthoatdv.UseVisualStyleBackColor = false;
            this.btnthoatdv.Click += new System.EventHandler(this.btnthoatdv_Click);
            // 
            // btnxoadv
            // 
            this.btnxoadv.BackColor = System.Drawing.SystemColors.Info;
            this.btnxoadv.Location = new System.Drawing.Point(587, 187);
            this.btnxoadv.Name = "btnxoadv";
            this.btnxoadv.Size = new System.Drawing.Size(144, 51);
            this.btnxoadv.TabIndex = 8;
            this.btnxoadv.Text = "Xóa";
            this.btnxoadv.UseVisualStyleBackColor = false;
            this.btnxoadv.Click += new System.EventHandler(this.btnxoadv_Click);
            // 
            // btnsuadv
            // 
            this.btnsuadv.BackColor = System.Drawing.SystemColors.Info;
            this.btnsuadv.Location = new System.Drawing.Point(327, 187);
            this.btnsuadv.Name = "btnsuadv";
            this.btnsuadv.Size = new System.Drawing.Size(144, 51);
            this.btnsuadv.TabIndex = 8;
            this.btnsuadv.Text = "Sửa";
            this.btnsuadv.UseVisualStyleBackColor = false;
            this.btnsuadv.Click += new System.EventHandler(this.btnsuadv_Click);
            // 
            // btnthemdv
            // 
            this.btnthemdv.BackColor = System.Drawing.SystemColors.Info;
            this.btnthemdv.Location = new System.Drawing.Point(79, 187);
            this.btnthemdv.Name = "btnthemdv";
            this.btnthemdv.Size = new System.Drawing.Size(144, 51);
            this.btnthemdv.TabIndex = 8;
            this.btnthemdv.Text = "Thêm";
            this.btnthemdv.UseVisualStyleBackColor = false;
            this.btnthemdv.Click += new System.EventHandler(this.btnthemdv_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(348, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 55);
            this.label1.TabIndex = 16;
            this.label1.Text = "QUẢN LÝ DỊCH VỤ";
            // 
            // DichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1126, 701);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "DichVu";
            this.Text = "DichVu";
            this.Load += new System.EventHandler(this.DichVu_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dichvuDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dichvuDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtdvt;
        private System.Windows.Forms.TextBox txt_gia;
        private System.Windows.Forms.TextBox txtmadv;
        private System.Windows.Forms.TextBox txttendv;
        private System.Windows.Forms.Button btnthoatdv;
        private System.Windows.Forms.Button btnxoadv;
        private System.Windows.Forms.Button btnsuadv;
        private System.Windows.Forms.Button btnthemdv;
        private System.Windows.Forms.Label label1;
    }
}