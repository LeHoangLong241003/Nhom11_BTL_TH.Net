namespace QuanLyThuePhongNhaNghi
{
    partial class TraPhong
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dichvudataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.thuedataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.btn_timtenkh = new System.Windows.Forms.Button();
            this.btn_trap = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dichvudataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thuedataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(523, 51);
            this.label1.TabIndex = 7;
            this.label1.Text = "TRẢ PHÒNG NHÀ NGHỈ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_input);
            this.groupBox1.Controls.Add(this.btn_timtenkh);
            this.groupBox1.Controls.Add(this.btn_trap);
            this.groupBox1.Font = new System.Drawing.Font("Times", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1028, 578);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách thuê";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dichvudataGridView2);
            this.groupBox3.Location = new System.Drawing.Point(15, 335);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1006, 229);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách dịch vụ";
            // 
            // dichvudataGridView2
            // 
            this.dichvudataGridView2.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dichvudataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dichvudataGridView2.Location = new System.Drawing.Point(6, 35);
            this.dichvudataGridView2.Name = "dichvudataGridView2";
            this.dichvudataGridView2.RowHeadersWidth = 62;
            this.dichvudataGridView2.RowTemplate.Height = 28;
            this.dichvudataGridView2.Size = new System.Drawing.Size(994, 188);
            this.dichvudataGridView2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.thuedataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(15, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1006, 229);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách thuê phòng";
            // 
            // thuedataGridView1
            // 
            this.thuedataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.thuedataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.thuedataGridView1.Location = new System.Drawing.Point(6, 35);
            this.thuedataGridView1.Name = "thuedataGridView1";
            this.thuedataGridView1.RowHeadersWidth = 62;
            this.thuedataGridView1.RowTemplate.Height = 28;
            this.thuedataGridView1.Size = new System.Drawing.Size(994, 188);
            this.thuedataGridView1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "Số CMT : ";
            // 
            // txt_input
            // 
            this.txt_input.Font = new System.Drawing.Font("Times", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_input.Location = new System.Drawing.Point(175, 38);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(265, 44);
            this.txt_input.TabIndex = 15;
            this.txt_input.TextChanged += new System.EventHandler(this.txt_input_TextChanged);
            // 
            // btn_timtenkh
            // 
            this.btn_timtenkh.FlatAppearance.BorderSize = 2;
            this.btn_timtenkh.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timtenkh.Location = new System.Drawing.Point(482, 34);
            this.btn_timtenkh.Name = "btn_timtenkh";
            this.btn_timtenkh.Size = new System.Drawing.Size(176, 48);
            this.btn_timtenkh.TabIndex = 16;
            this.btn_timtenkh.Text = "Tìm kiếm";
            this.btn_timtenkh.UseVisualStyleBackColor = true;
            this.btn_timtenkh.Click += new System.EventHandler(this.btn_timtenkh_Click);
            // 
            // btn_trap
            // 
            this.btn_trap.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_trap.Location = new System.Drawing.Point(800, 34);
            this.btn_trap.Name = "btn_trap";
            this.btn_trap.Size = new System.Drawing.Size(176, 48);
            this.btn_trap.TabIndex = 11;
            this.btn_trap.Text = "Trả phòng";
            this.btn_trap.UseVisualStyleBackColor = true;
            this.btn_trap.Click += new System.EventHandler(this.btn_trap_Click);
            // 
            // TraPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1085, 775);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "TraPhong";
            this.Text = "TraPhong";
            this.Load += new System.EventHandler(this.TraPhong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dichvudataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.thuedataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_trap;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.Button btn_timtenkh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dichvudataGridView2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView thuedataGridView1;
    }
}