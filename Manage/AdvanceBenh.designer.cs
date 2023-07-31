namespace QLAoCa
{
    partial class AdvanceBenh
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
            this.dgvMacBenh = new System.Windows.Forms.DataGridView();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dateTimeNgayBenh = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimeNgayKhoe = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.txtMaLua = new System.Windows.Forms.TextBox();
            this.txtMaBenh2 = new System.Windows.Forms.TextBox();
            this.txtMaMacBenh = new System.Windows.Forms.TextBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimeNgayBD = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeNgayKT = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMacBenh)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMacBenh
            // 
            this.dgvMacBenh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMacBenh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMacBenh.Location = new System.Drawing.Point(12, 101);
            this.dgvMacBenh.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMacBenh.Name = "dgvMacBenh";
            this.dgvMacBenh.RowHeadersWidth = 51;
            this.dgvMacBenh.Size = new System.Drawing.Size(1131, 317);
            this.dgvMacBenh.TabIndex = 62;
            this.dgvMacBenh.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMacBenh_RowEnter);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonEdit.ForeColor = System.Drawing.Color.Black;
            this.buttonEdit.Location = new System.Drawing.Point(1157, 281);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(117, 43);
            this.buttonEdit.TabIndex = 75;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonDelete.ForeColor = System.Drawing.Color.Black;
            this.buttonDelete.Location = new System.Drawing.Point(1157, 373);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(117, 43);
            this.buttonDelete.TabIndex = 74;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonAdd.ForeColor = System.Drawing.Color.Black;
            this.buttonAdd.Location = new System.Drawing.Point(1157, 189);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(117, 43);
            this.buttonAdd.TabIndex = 73;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dateTimeNgayBenh
            // 
            this.dateTimeNgayBenh.CalendarFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimeNgayBenh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimeNgayBenh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeNgayBenh.Location = new System.Drawing.Point(175, 61);
            this.dateTimeNgayBenh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimeNgayBenh.Name = "dateTimeNgayBenh";
            this.dateTimeNgayBenh.Size = new System.Drawing.Size(145, 30);
            this.dateTimeNgayBenh.TabIndex = 86;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.Location = new System.Drawing.Point(352, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 25);
            this.label13.TabIndex = 81;
            this.label13.Text = "Ngày Khỏe:";
            // 
            // dateTimeNgayKhoe
            // 
            this.dateTimeNgayKhoe.CalendarFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimeNgayKhoe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimeNgayKhoe.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeNgayKhoe.Location = new System.Drawing.Point(500, 61);
            this.dateTimeNgayKhoe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimeNgayKhoe.Name = "dateTimeNgayKhoe";
            this.dateTimeNgayKhoe.Size = new System.Drawing.Size(146, 30);
            this.dateTimeNgayKhoe.TabIndex = 87;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(264, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 79;
            this.label2.Text = "Mã Bệnh:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(28, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 25);
            this.label10.TabIndex = 85;
            this.label10.Text = "Ngày Bệnh:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(467, 8);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 25);
            this.label6.TabIndex = 80;
            this.label6.Text = "Mã Lứa:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGhiChu.Location = new System.Drawing.Point(750, 5);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(2);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(393, 86);
            this.txtGhiChu.TabIndex = 78;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(655, 8);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 25);
            this.label11.TabIndex = 76;
            this.label11.Text = "Ghi Chú:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(25, 8);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 25);
            this.label5.TabIndex = 77;
            this.label5.Text = "Mã Mắc Bệnh:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(526, 16);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 25);
            this.label9.TabIndex = 91;
            this.label9.Text = "Search:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.buttonRefresh);
            this.panel1.Controls.Add(this.txtMaLua);
            this.panel1.Controls.Add(this.txtMaBenh2);
            this.panel1.Controls.Add(this.txtMaMacBenh);
            this.panel1.Controls.Add(this.btSearch);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.buttonEdit);
            this.panel1.Controls.Add(this.dgvMacBenh);
            this.panel1.Controls.Add(this.dateTimeNgayBenh);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dateTimeNgayKhoe);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtGhiChu);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1290, 426);
            this.panel1.TabIndex = 93;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonRefresh.Location = new System.Drawing.Point(1157, 97);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(117, 43);
            this.buttonRefresh.TabIndex = 91;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // txtMaLua
            // 
            this.txtMaLua.BackColor = System.Drawing.Color.White;
            this.txtMaLua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaLua.Location = new System.Drawing.Point(563, 5);
            this.txtMaLua.Name = "txtMaLua";
            this.txtMaLua.ReadOnly = true;
            this.txtMaLua.Size = new System.Drawing.Size(85, 30);
            this.txtMaLua.TabIndex = 90;
            this.txtMaLua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMaBenh2
            // 
            this.txtMaBenh2.BackColor = System.Drawing.Color.White;
            this.txtMaBenh2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaBenh2.Location = new System.Drawing.Point(368, 5);
            this.txtMaBenh2.Name = "txtMaBenh2";
            this.txtMaBenh2.ReadOnly = true;
            this.txtMaBenh2.Size = new System.Drawing.Size(88, 30);
            this.txtMaBenh2.TabIndex = 90;
            this.txtMaBenh2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMaMacBenh
            // 
            this.txtMaMacBenh.BackColor = System.Drawing.Color.White;
            this.txtMaMacBenh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaMacBenh.Location = new System.Drawing.Point(172, 5);
            this.txtMaMacBenh.Name = "txtMaMacBenh";
            this.txtMaMacBenh.ReadOnly = true;
            this.txtMaMacBenh.Size = new System.Drawing.Size(81, 30);
            this.txtMaMacBenh.TabIndex = 90;
            this.txtMaMacBenh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btSearch
            // 
            this.btSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btSearch.ForeColor = System.Drawing.Color.Black;
            this.btSearch.Location = new System.Drawing.Point(1157, 5);
            this.btSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(117, 43);
            this.btSearch.TabIndex = 73;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(37, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 37);
            this.label4.TabIndex = 94;
            this.label4.Text = "Chi Tiết Về Bệnh";
            // 
            // dateTimeNgayBD
            // 
            this.dateTimeNgayBD.CalendarFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimeNgayBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimeNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeNgayBD.Location = new System.Drawing.Point(687, 12);
            this.dateTimeNgayBD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimeNgayBD.Name = "dateTimeNgayBD";
            this.dateTimeNgayBD.Size = new System.Drawing.Size(158, 30);
            this.dateTimeNgayBD.TabIndex = 94;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(863, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 92;
            this.label1.Text = "Ngày KT";
            // 
            // dateTimeNgayKT
            // 
            this.dateTimeNgayKT.CalendarFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimeNgayKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimeNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeNgayKT.Location = new System.Drawing.Point(956, 12);
            this.dateTimeNgayKT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimeNgayKT.Name = "dateTimeNgayKT";
            this.dateTimeNgayKT.Size = new System.Drawing.Size(158, 30);
            this.dateTimeNgayKT.TabIndex = 95;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(599, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 93;
            this.label3.Text = "Ngày BD";
            // 
            // AdvanceBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1314, 487);
            this.Controls.Add(this.dateTimeNgayBD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimeNgayKT);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdvanceBenh";
            this.Text = "Benh";
            this.Load += new System.EventHandler(this.AdvanceBenh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMacBenh)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvMacBenh;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        public System.Windows.Forms.DateTimePicker dateTimeNgayBenh;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.DateTimePicker dateTimeNgayKhoe;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaLua;
        private System.Windows.Forms.TextBox txtMaBenh2;
        private System.Windows.Forms.TextBox txtMaMacBenh;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Button buttonRefresh;
        public System.Windows.Forms.DateTimePicker dateTimeNgayBD;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dateTimeNgayKT;
        public System.Windows.Forms.Label label3;
    }
}