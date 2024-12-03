namespace QuanLyThuePhongNhaNghi
{
    partial class ThanhToan
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.thanhtoandataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnthoattt = new System.Windows.Forms.Button();
            this.btnthanhtoan = new System.Windows.Forms.Button();
            this.btnthanhtien = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thanhtoandataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(420, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 51);
            this.label1.TabIndex = 8;
            this.label1.Text = "THANH TOÁN";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnthanhtien);
            this.groupBox3.Controls.Add(this.btnthanhtoan);
            this.groupBox3.Controls.Add(this.btnthoattt);
            this.groupBox3.Controls.Add(this.thanhtoandataGridView2);
            this.groupBox3.Font = new System.Drawing.Font("Times", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(21, 104);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1066, 431);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách thanh toán";
            // 
            // thanhtoandataGridView2
            // 
            this.thanhtoandataGridView2.BackgroundColor = System.Drawing.SystemColors.Window;
            this.thanhtoandataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.thanhtoandataGridView2.Location = new System.Drawing.Point(6, 35);
            this.thanhtoandataGridView2.Name = "thanhtoandataGridView2";
            this.thanhtoandataGridView2.RowHeadersWidth = 62;
            this.thanhtoandataGridView2.RowTemplate.Height = 28;
            this.thanhtoandataGridView2.Size = new System.Drawing.Size(1054, 317);
            this.thanhtoandataGridView2.TabIndex = 1;
            this.thanhtoandataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.thanhtoandataGridView2_CellContentClick);
            // 
            // btnthoattt
            // 
            this.btnthoattt.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoattt.Location = new System.Drawing.Point(773, 367);
            this.btnthoattt.Name = "btnthoattt";
            this.btnthoattt.Size = new System.Drawing.Size(176, 48);
            this.btnthoattt.TabIndex = 12;
            this.btnthoattt.Text = "Thoát";
            this.btnthoattt.UseVisualStyleBackColor = true;
            // 
            // btnthanhtoan
            // 
            this.btnthanhtoan.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthanhtoan.Location = new System.Drawing.Point(454, 367);
            this.btnthanhtoan.Name = "btnthanhtoan";
            this.btnthanhtoan.Size = new System.Drawing.Size(176, 48);
            this.btnthanhtoan.TabIndex = 13;
            this.btnthanhtoan.Text = "Thanh toán";
            this.btnthanhtoan.UseVisualStyleBackColor = true;
            this.btnthanhtoan.Click += new System.EventHandler(this.btnthanhtoan_Click);
            // 
            // btnthanhtien
            // 
            this.btnthanhtien.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthanhtien.Location = new System.Drawing.Point(135, 367);
            this.btnthanhtien.Name = "btnthanhtien";
            this.btnthanhtien.Size = new System.Drawing.Size(176, 48);
            this.btnthanhtien.TabIndex = 14;
            this.btnthanhtien.Text = "Thành tiền";
            this.btnthanhtien.UseVisualStyleBackColor = true;
            // 
            // ThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1116, 598);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Name = "ThanhToan";
            this.Text = "ThanhToan";
            this.Load += new System.EventHandler(this.ThanhToan_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.thanhtoandataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView thanhtoandataGridView2;
        private System.Windows.Forms.Button btnthanhtoan;
        private System.Windows.Forms.Button btnthoattt;
        private System.Windows.Forms.Button btnthanhtien;
    }
}