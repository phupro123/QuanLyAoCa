
namespace QLAoCa
{
    partial class Feed
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
            this.label4 = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvChoAn = new System.Windows.Forms.DataGridView();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.txtMaLua = new System.Windows.Forms.TextBox();
            this.txtMaThucAn = new System.Windows.Forms.TextBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimeThoiGian = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAdvance = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChoAn)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(35, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 37);
            this.label4.TabIndex = 104;
            this.label4.Text = "Ghi Chú Cho Ăn";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonRefresh.Location = new System.Drawing.Point(42, 309);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(117, 36);
            this.buttonRefresh.TabIndex = 101;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(42, 16);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 25);
            this.label12.TabIndex = 97;
            this.label12.Text = "Mã Lứa:";
            // 
            // dgvChoAn
            // 
            this.dgvChoAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChoAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChoAn.Location = new System.Drawing.Point(382, 13);
            this.dgvChoAn.Margin = new System.Windows.Forms.Padding(4);
            this.dgvChoAn.Name = "dgvChoAn";
            this.dgvChoAn.RowHeadersWidth = 51;
            this.dgvChoAn.Size = new System.Drawing.Size(1091, 496);
            this.dgvChoAn.TabIndex = 62;
            this.dgvChoAn.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChoAn_RowEnter);
            // 
            // txtSL
            // 
            this.txtSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSL.Location = new System.Drawing.Point(208, 161);
            this.txtSL.Margin = new System.Windows.Forms.Padding(2);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(126, 30);
            this.txtSL.TabIndex = 95;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonAdd.ForeColor = System.Drawing.Color.Black;
            this.buttonAdd.Location = new System.Drawing.Point(208, 389);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(126, 36);
            this.buttonAdd.TabIndex = 73;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // txtMaLua
            // 
            this.txtMaLua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaLua.Location = new System.Drawing.Point(208, 13);
            this.txtMaLua.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaLua.Name = "txtMaLua";
            this.txtMaLua.Size = new System.Drawing.Size(126, 30);
            this.txtMaLua.TabIndex = 96;
            // 
            // txtMaThucAn
            // 
            this.txtMaThucAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaThucAn.Location = new System.Drawing.Point(208, 87);
            this.txtMaThucAn.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaThucAn.Name = "txtMaThucAn";
            this.txtMaThucAn.Size = new System.Drawing.Size(126, 30);
            this.txtMaThucAn.TabIndex = 96;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonEdit.ForeColor = System.Drawing.Color.Black;
            this.buttonEdit.Location = new System.Drawing.Point(42, 389);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(126, 36);
            this.buttonEdit.TabIndex = 75;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(42, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 93;
            this.label3.Text = "Số Lượng:";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonDelete.ForeColor = System.Drawing.Color.Black;
            this.buttonDelete.Location = new System.Drawing.Point(208, 309);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(126, 36);
            this.buttonDelete.TabIndex = 74;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(42, 90);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 25);
            this.label7.TabIndex = 94;
            this.label7.Text = "Mã Thức Ăn:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.buttonRefresh);
            this.panel1.Controls.Add(this.dateTimeThoiGian);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.dgvChoAn);
            this.panel1.Controls.Add(this.txtSL);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.txtMaLua);
            this.panel1.Controls.Add(this.txtMaThucAn);
            this.panel1.Controls.Add(this.buttonEdit);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.buttonAdvance);
            this.panel1.Location = new System.Drawing.Point(11, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1491, 526);
            this.panel1.TabIndex = 105;
            // 
            // dateTimeThoiGian
            // 
            this.dateTimeThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimeThoiGian.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeThoiGian.Location = new System.Drawing.Point(184, 235);
            this.dateTimeThoiGian.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimeThoiGian.Name = "dateTimeThoiGian";
            this.dateTimeThoiGian.Size = new System.Drawing.Size(150, 30);
            this.dateTimeThoiGian.TabIndex = 100;
            this.dateTimeThoiGian.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(42, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 99;
            this.label2.Text = "Thời Gian:";
            this.label2.Visible = false;
            // 
            // buttonAdvance
            // 
            this.buttonAdvance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonAdvance.Location = new System.Drawing.Point(206, 469);
            this.buttonAdvance.Name = "buttonAdvance";
            this.buttonAdvance.Size = new System.Drawing.Size(128, 40);
            this.buttonAdvance.TabIndex = 64;
            this.buttonAdvance.Text = "Advance";
            this.buttonAdvance.UseVisualStyleBackColor = true;
            this.buttonAdvance.Click += new System.EventHandler(this.buttonAdvance_Click);
            // 
            // Feed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1508, 582);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Name = "Feed";
            this.Text = "Feed";
            this.Load += new System.EventHandler(this.Feed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChoAn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvChoAn;
        public System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Button buttonAdd;
        public System.Windows.Forms.TextBox txtMaLua;
        public System.Windows.Forms.TextBox txtMaThucAn;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAdvance;
        public System.Windows.Forms.DateTimePicker dateTimeThoiGian;
        public System.Windows.Forms.Label label2;
    }
}