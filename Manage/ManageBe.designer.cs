namespace QLAoCa
{
    partial class ManageBe
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
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvBe = new System.Windows.Forms.DataGridView();
            this.txtDoSau = new System.Windows.Forms.TextBox();
            this.txtDienTich = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btEditBe = new System.Windows.Forms.Button();
            this.btDeleteBe = new System.Windows.Forms.Button();
            this.btAddBe = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonMoiTruong = new System.Windows.Forms.Button();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.txtMaBe = new System.Windows.Forms.TextBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBe)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(13, 103);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 25);
            this.label9.TabIndex = 31;
            this.label9.Text = "Độ Sâu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(13, 53);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 25);
            this.label7.TabIndex = 32;
            this.label7.Text = "Diện Tích:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(13, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 34;
            this.label4.Text = "Mã Bể:";
            // 
            // dgvBe
            // 
            this.dgvBe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBe.Location = new System.Drawing.Point(356, 5);
            this.dgvBe.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dgvBe.Name = "dgvBe";
            this.dgvBe.RowHeadersWidth = 51;
            this.dgvBe.Size = new System.Drawing.Size(901, 354);
            this.dgvBe.TabIndex = 60;
            this.dgvBe.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBe_RowEnter);
            // 
            // txtDoSau
            // 
            this.txtDoSau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDoSau.Location = new System.Drawing.Point(146, 100);
            this.txtDoSau.Margin = new System.Windows.Forms.Padding(2);
            this.txtDoSau.Name = "txtDoSau";
            this.txtDoSau.Size = new System.Drawing.Size(177, 30);
            this.txtDoSau.TabIndex = 63;
            // 
            // txtDienTich
            // 
            this.txtDienTich.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDienTich.Location = new System.Drawing.Point(146, 50);
            this.txtDienTich.Margin = new System.Windows.Forms.Padding(2);
            this.txtDienTich.Name = "txtDienTich";
            this.txtDienTich.Size = new System.Drawing.Size(177, 30);
            this.txtDienTich.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 37);
            this.label1.TabIndex = 64;
            this.label1.Text = "Quản Lý Bể Cá";
            // 
            // btEditBe
            // 
            this.btEditBe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btEditBe.ForeColor = System.Drawing.Color.Black;
            this.btEditBe.Location = new System.Drawing.Point(18, 254);
            this.btEditBe.Margin = new System.Windows.Forms.Padding(4);
            this.btEditBe.Name = "btEditBe";
            this.btEditBe.Size = new System.Drawing.Size(115, 38);
            this.btEditBe.TabIndex = 68;
            this.btEditBe.Text = "Edit";
            this.btEditBe.UseVisualStyleBackColor = true;
            this.btEditBe.Click += new System.EventHandler(this.btEditBe_Click);
            // 
            // btDeleteBe
            // 
            this.btDeleteBe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btDeleteBe.ForeColor = System.Drawing.Color.Black;
            this.btDeleteBe.Location = new System.Drawing.Point(208, 254);
            this.btDeleteBe.Margin = new System.Windows.Forms.Padding(4);
            this.btDeleteBe.Name = "btDeleteBe";
            this.btDeleteBe.Size = new System.Drawing.Size(115, 38);
            this.btDeleteBe.TabIndex = 67;
            this.btDeleteBe.Text = "Delete";
            this.btDeleteBe.UseVisualStyleBackColor = true;
            this.btDeleteBe.Click += new System.EventHandler(this.btDeleteBe_Click);
            // 
            // btAddBe
            // 
            this.btAddBe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btAddBe.ForeColor = System.Drawing.Color.Black;
            this.btAddBe.Location = new System.Drawing.Point(208, 193);
            this.btAddBe.Margin = new System.Windows.Forms.Padding(4);
            this.btAddBe.Name = "btAddBe";
            this.btAddBe.Size = new System.Drawing.Size(115, 38);
            this.btAddBe.TabIndex = 66;
            this.btAddBe.Text = "Add";
            this.btAddBe.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.buttonMoiTruong);
            this.panel1.Controls.Add(this.txtTrangThai);
            this.panel1.Controls.Add(this.txtMaBe);
            this.panel1.Controls.Add(this.btEditBe);
            this.panel1.Controls.Add(this.txtDienTich);
            this.panel1.Controls.Add(this.txtDoSau);
            this.panel1.Controls.Add(this.buttonRefresh);
            this.panel1.Controls.Add(this.btDeleteBe);
            this.panel1.Controls.Add(this.dgvBe);
            this.panel1.Controls.Add(this.btAddBe);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1267, 368);
            this.panel1.TabIndex = 69;
            // 
            // buttonMoiTruong
            // 
            this.buttonMoiTruong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonMoiTruong.Location = new System.Drawing.Point(95, 312);
            this.buttonMoiTruong.Name = "buttonMoiTruong";
            this.buttonMoiTruong.Size = new System.Drawing.Size(157, 39);
            this.buttonMoiTruong.TabIndex = 69;
            this.buttonMoiTruong.Text = "Môi trường";
            this.buttonMoiTruong.UseVisualStyleBackColor = true;
            this.buttonMoiTruong.Click += new System.EventHandler(this.buttonMoiTruong_Click);
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTrangThai.Location = new System.Drawing.Point(146, 148);
            this.txtTrangThai.Margin = new System.Windows.Forms.Padding(2);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(177, 30);
            this.txtTrangThai.TabIndex = 63;
            // 
            // txtMaBe
            // 
            this.txtMaBe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaBe.Location = new System.Drawing.Point(146, 5);
            this.txtMaBe.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaBe.Name = "txtMaBe";
            this.txtMaBe.Size = new System.Drawing.Size(177, 30);
            this.txtMaBe.TabIndex = 63;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonRefresh.ForeColor = System.Drawing.Color.Black;
            this.buttonRefresh.Location = new System.Drawing.Point(18, 193);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(115, 38);
            this.buttonRefresh.TabIndex = 67;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(13, 151);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 25);
            this.label12.TabIndex = 32;
            this.label12.Text = "Trạng Thái:";
            // 
            // ManageBe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1286, 428);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManageBe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage";
            this.Load += new System.EventHandler(this.ManageBe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBe)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvBe;
        public System.Windows.Forms.TextBox txtDoSau;
        public System.Windows.Forms.TextBox txtDienTich;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btEditBe;
        private System.Windows.Forms.Button btDeleteBe;
        private System.Windows.Forms.Button btAddBe;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txtMaBe;
        private System.Windows.Forms.Button buttonMoiTruong;
        private System.Windows.Forms.Button buttonRefresh;
    }
}