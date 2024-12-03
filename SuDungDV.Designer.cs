namespace QuanLyThuePhongNhaNghi
{
    partial class SuDungDV
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
            System.Windows.Forms.Label label2;
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sDDVDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.txtmap = new System.Windows.Forms.TextBox();
            this.txtcmt = new System.Windows.Forms.TextBox();
            this.txtmadv = new System.Windows.Forms.TextBox();
            this.btnthoatsddv = new System.Windows.Forms.Button();
            this.btnxoasddv = new System.Windows.Forms.Button();
            this.btnsuasddv = new System.Windows.Forms.Button();
            this.btnthemsddv = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtngaysd = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            dVTLabel = new System.Windows.Forms.Label();
            txtgiadv = new System.Windows.Forms.Label();
            maDVLabel = new System.Windows.Forms.Label();
            tenDVLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sDDVDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sDDVDataGridView);
            this.groupBox2.Font = new System.Drawing.Font("Times", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(18, 372);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1097, 317);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sử dụng";
            // 
            // sDDVDataGridView
            // 
            this.sDDVDataGridView.AllowUserToAddRows = false;
            this.sDDVDataGridView.AllowUserToDeleteRows = false;
            this.sDDVDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sDDVDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.sDDVDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sDDVDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sDDVDataGridView.Location = new System.Drawing.Point(4, 34);
            this.sDDVDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sDDVDataGridView.Name = "sDDVDataGridView";
            this.sDDVDataGridView.RowHeadersWidth = 62;
            this.sDDVDataGridView.Size = new System.Drawing.Size(1089, 278);
            this.sDDVDataGridView.TabIndex = 0;
            this.sDDVDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sDDVDataGridView_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtngaysd);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(dVTLabel);
            this.groupBox1.Controls.Add(this.txtsoluong);
            this.groupBox1.Controls.Add(txtgiadv);
            this.groupBox1.Controls.Add(this.txtmap);
            this.groupBox1.Controls.Add(maDVLabel);
            this.groupBox1.Controls.Add(this.txtcmt);
            this.groupBox1.Controls.Add(tenDVLabel);
            this.groupBox1.Controls.Add(this.txtmadv);
            this.groupBox1.Controls.Add(this.btnthoatsddv);
            this.groupBox1.Controls.Add(this.btnxoasddv);
            this.groupBox1.Controls.Add(this.btnsuasddv);
            this.groupBox1.Controls.Add(this.btnthemsddv);
            this.groupBox1.Font = new System.Drawing.Font("Times", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 85);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1097, 287);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin dịch vụ";
            // 
            // dVTLabel
            // 
            dVTLabel.AutoSize = true;
            dVTLabel.Location = new System.Drawing.Point(634, 38);
            dVTLabel.Name = "dVTLabel";
            dVTLabel.Size = new System.Drawing.Size(100, 29);
            dVTLabel.TabIndex = 8;
            dVTLabel.Text = "Số lượng";
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(765, 35);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(238, 36);
            this.txtsoluong.TabIndex = 9;
            // 
            // txtgiadv
            // 
            txtgiadv.AutoSize = true;
            txtgiadv.Location = new System.Drawing.Point(634, 90);
            txtgiadv.Name = "txtgiadv";
            txtgiadv.Size = new System.Drawing.Size(112, 29);
            txtgiadv.TabIndex = 10;
            txtgiadv.Text = "Mã phòng";
            // 
            // txtmap
            // 
            this.txtmap.Location = new System.Drawing.Point(765, 87);
            this.txtmap.Name = "txtmap";
            this.txtmap.Size = new System.Drawing.Size(238, 36);
            this.txtmap.TabIndex = 11;
            // 
            // maDVLabel
            // 
            maDVLabel.AutoSize = true;
            maDVLabel.Location = new System.Drawing.Point(74, 42);
            maDVLabel.Name = "maDVLabel";
            maDVLabel.Size = new System.Drawing.Size(103, 29);
            maDVLabel.TabIndex = 12;
            maDVLabel.Text = "Số CMT ";
            // 
            // txtcmt
            // 
            this.txtcmt.Location = new System.Drawing.Point(229, 36);
            this.txtcmt.Name = "txtcmt";
            this.txtcmt.Size = new System.Drawing.Size(238, 36);
            this.txtcmt.TabIndex = 13;
            // 
            // tenDVLabel
            // 
            tenDVLabel.AutoSize = true;
            tenDVLabel.Location = new System.Drawing.Point(74, 94);
            tenDVLabel.Name = "tenDVLabel";
            tenDVLabel.Size = new System.Drawing.Size(125, 29);
            tenDVLabel.TabIndex = 14;
            tenDVLabel.Text = "Mã dịch vụ";
            // 
            // txtmadv
            // 
            this.txtmadv.Location = new System.Drawing.Point(229, 90);
            this.txtmadv.Name = "txtmadv";
            this.txtmadv.Size = new System.Drawing.Size(238, 36);
            this.txtmadv.TabIndex = 15;
            // 
            // btnthoatsddv
            // 
            this.btnthoatsddv.BackColor = System.Drawing.SystemColors.Info;
            this.btnthoatsddv.Location = new System.Drawing.Point(666, 209);
            this.btnthoatsddv.Name = "btnthoatsddv";
            this.btnthoatsddv.Size = new System.Drawing.Size(144, 51);
            this.btnthoatsddv.TabIndex = 8;
            this.btnthoatsddv.Text = "Thoát";
            this.btnthoatsddv.UseVisualStyleBackColor = false;
            this.btnthoatsddv.Click += new System.EventHandler(this.btnthoatsddv_Click);
            // 
            // btnxoasddv
            // 
            this.btnxoasddv.BackColor = System.Drawing.SystemColors.Info;
            this.btnxoasddv.Location = new System.Drawing.Point(466, 209);
            this.btnxoasddv.Name = "btnxoasddv";
            this.btnxoasddv.Size = new System.Drawing.Size(144, 51);
            this.btnxoasddv.TabIndex = 8;
            this.btnxoasddv.Text = "Xóa";
            this.btnxoasddv.UseVisualStyleBackColor = false;
            this.btnxoasddv.Click += new System.EventHandler(this.btnxoasddv_Click);
            // 
            // btnsuasddv
            // 
            this.btnsuasddv.BackColor = System.Drawing.SystemColors.Info;
            this.btnsuasddv.Location = new System.Drawing.Point(276, 209);
            this.btnsuasddv.Name = "btnsuasddv";
            this.btnsuasddv.Size = new System.Drawing.Size(144, 51);
            this.btnsuasddv.TabIndex = 8;
            this.btnsuasddv.Text = "Sửa";
            this.btnsuasddv.UseVisualStyleBackColor = false;
            this.btnsuasddv.Click += new System.EventHandler(this.btnsuasddv_Click);
            // 
            // btnthemsddv
            // 
            this.btnthemsddv.BackColor = System.Drawing.SystemColors.Info;
            this.btnthemsddv.Location = new System.Drawing.Point(79, 209);
            this.btnthemsddv.Name = "btnthemsddv";
            this.btnthemsddv.Size = new System.Drawing.Size(144, 51);
            this.btnthemsddv.TabIndex = 8;
            this.btnthemsddv.Text = "Thêm";
            this.btnthemsddv.UseVisualStyleBackColor = false;
            this.btnthemsddv.Click += new System.EventHandler(this.btnthemsddv_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 51);
            this.label1.TabIndex = 20;
            this.label1.Text = "SỬ DỤNG DỊCH VỤ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(74, 148);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(149, 29);
            label2.TabIndex = 16;
            label2.Text = "Ngày sử dụng";
            // 
            // txtngaysd
            // 
            this.txtngaysd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtngaysd.Location = new System.Drawing.Point(229, 142);
            this.txtngaysd.Name = "txtngaysd";
            this.txtngaysd.Size = new System.Drawing.Size(238, 36);
            this.txtngaysd.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(859, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 51);
            this.button1.TabIndex = 19;
            this.button1.Text = "Thêm DV";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SuDungDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1135, 703);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "SuDungDV";
            this.Text = "Sử dụng dịch vụ";
            this.Load += new System.EventHandler(this.SuDungDV_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sDDVDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView sDDVDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.TextBox txtmap;
        private System.Windows.Forms.TextBox txtcmt;
        private System.Windows.Forms.TextBox txtmadv;
        private System.Windows.Forms.Button btnthoatsddv;
        private System.Windows.Forms.Button btnxoasddv;
        private System.Windows.Forms.Button btnsuasddv;
        private System.Windows.Forms.Button btnthemsddv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txtngaysd;
        private System.Windows.Forms.Button button1;
    }
}