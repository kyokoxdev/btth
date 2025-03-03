namespace WindowsFormsApp1
{
    partial class form
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgSach = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.timeTra = new System.Windows.Forms.DateTimePicker();
            this.timeMuon = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTenSach = new System.Windows.Forms.ComboBox();
            this.cbTenSV = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pnlSapXep = new System.Windows.Forms.Panel();
            this.rbGiamDan = new System.Windows.Forms.RadioButton();
            this.rbTangDan = new System.Windows.Forms.RadioButton();
            this.lblSapXep = new System.Windows.Forms.Label();
            this.pnlThongKeOptions = new System.Windows.Forms.Panel();
            this.btnThongKeLuotMuon = new System.Windows.Forms.Button();
            this.btnThongKeSVQuaHan = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSach)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.pnlSapXep.SuspendLayout();
            this.pnlThongKeOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(595, 361);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.tb2);
            this.tabPage1.Controls.Add(this.tb1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dtgSach);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(587, 335);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = " Quản lý sách";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(429, 34);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 53);
            this.button1.TabIndex = 7;
            this.button1.Text = "Thêm sách";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(85, 74);
            this.tb2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(266, 20);
            this.tb2.TabIndex = 6;
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(85, 24);
            this.tb1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(266, 20);
            this.tb1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã sách";
            // 
            // dtgSach
            // 
            this.dtgSach.AllowUserToAddRows = false;
            this.dtgSach.AllowUserToDeleteRows = false;
            this.dtgSach.AllowUserToOrderColumns = true;
            this.dtgSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3});
            this.dtgSach.Location = new System.Drawing.Point(2, 124);
            this.dtgSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgSach.Name = "dtgSach";
            this.dtgSach.ReadOnly = true;
            this.dtgSach.RowHeadersWidth = 62;
            this.dtgSach.RowTemplate.Height = 28;
            this.dtgSach.Size = new System.Drawing.Size(585, 213);
            this.dtgSach.TabIndex = 2;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mã sách";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tên sách";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.timeTra);
            this.tabPage2.Controls.Add(this.timeMuon);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.cbTenSach);
            this.tabPage2.Controls.Add(this.cbTenSV);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(587, 335);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mượn/Trả sách";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // timeTra
            // 
            this.timeTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.timeTra.Location = new System.Drawing.Point(339, 70);
            this.timeTra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.timeTra.Name = "timeTra";
            this.timeTra.Size = new System.Drawing.Size(135, 20);
            this.timeTra.TabIndex = 16;
            // 
            // timeMuon
            // 
            this.timeMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.timeMuon.Location = new System.Drawing.Point(339, 10);
            this.timeMuon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.timeMuon.MaxDate = new System.DateTime(2388, 7, 28, 0, 0, 0, 0);
            this.timeMuon.MinDate = new System.DateTime(2025, 3, 3, 10, 34, 7, 0);
            this.timeMuon.Name = "timeMuon";
            this.timeMuon.Size = new System.Drawing.Size(135, 20);
            this.timeMuon.TabIndex = 15;
            this.timeMuon.Value = new System.DateTime(2025, 3, 4, 0, 0, 0, 0);
            this.timeMuon.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.button3.Location = new System.Drawing.Point(518, 60);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Trả sách";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.button2.Location = new System.Drawing.Point(518, 12);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Mượn sách";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(280, 102);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Số ngày mượn: ";
            // 
            // cbTenSach
            // 
            this.cbTenSach.FormattingEnabled = true;
            this.cbTenSach.Location = new System.Drawing.Point(96, 68);
            this.cbTenSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbTenSach.Name = "cbTenSach";
            this.cbTenSach.Size = new System.Drawing.Size(136, 21);
            this.cbTenSach.TabIndex = 9;
            // 
            // cbTenSV
            // 
            this.cbTenSV.FormattingEnabled = true;
            this.cbTenSV.Location = new System.Drawing.Point(96, 10);
            this.cbTenSV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbTenSV.Name = "cbTenSV";
            this.cbTenSV.Size = new System.Drawing.Size(136, 21);
            this.cbTenSV.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 70);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ngày trả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ngày mượn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tên sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên sinh viên";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column1,
            this.Column4,
            this.Column5,
            this.Column6,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView2.Location = new System.Drawing.Point(2, 124);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(585, 213);
            this.dataGridView2.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "STT";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Họ tên sinh viên";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tên sách";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ngày mượn";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Ngày trả";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Thành tiền";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Controls.Add(this.pnlSapXep);
            this.tabPage3.Controls.Add(this.lblSapXep);
            this.tabPage3.Controls.Add(this.pnlThongKeOptions);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Size = new System.Drawing.Size(587, 335);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Thống kê";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pnlSapXep
            // 
            this.pnlSapXep.Controls.Add(this.rbGiamDan);
            this.pnlSapXep.Controls.Add(this.rbTangDan);
            this.pnlSapXep.Location = new System.Drawing.Point(113, 60);
            this.pnlSapXep.Name = "pnlSapXep";
            this.pnlSapXep.Size = new System.Drawing.Size(200, 30);
            this.pnlSapXep.TabIndex = 5;
            // 
            // rbGiamDan
            // 
            this.rbGiamDan.AutoSize = true;
            this.rbGiamDan.Location = new System.Drawing.Point(100, 5);
            this.rbGiamDan.Name = "rbGiamDan";
            this.rbGiamDan.Size = new System.Drawing.Size(70, 17);
            this.rbGiamDan.TabIndex = 1;
            this.rbGiamDan.Text = "Giảm dần";
            this.rbGiamDan.UseVisualStyleBackColor = true;
            // 
            // rbTangDan
            // 
            this.rbTangDan.AutoSize = true;
            this.rbTangDan.Checked = true;
            this.rbTangDan.Location = new System.Drawing.Point(10, 5);
            this.rbTangDan.Name = "rbTangDan";
            this.rbTangDan.Size = new System.Drawing.Size(71, 17);
            this.rbTangDan.TabIndex = 0;
            this.rbTangDan.TabStop = true;
            this.rbTangDan.Text = "Tăng dần";
            this.rbTangDan.UseVisualStyleBackColor = true;
            // 
            // lblSapXep
            // 
            this.lblSapXep.AutoSize = true;
            this.lblSapXep.Location = new System.Drawing.Point(8, 65);
            this.lblSapXep.Name = "lblSapXep";
            this.lblSapXep.Size = new System.Drawing.Size(49, 13);
            this.lblSapXep.TabIndex = 4;
            this.lblSapXep.Text = "Sắp xếp:";
            // 
            // pnlThongKeOptions
            // 
            this.pnlThongKeOptions.Controls.Add(this.btnThongKeLuotMuon);
            this.pnlThongKeOptions.Controls.Add(this.btnThongKeSVQuaHan);
            this.pnlThongKeOptions.Location = new System.Drawing.Point(8, 5);
            this.pnlThongKeOptions.Name = "pnlThongKeOptions";
            this.pnlThongKeOptions.Size = new System.Drawing.Size(400, 50);
            this.pnlThongKeOptions.TabIndex = 3;
            // 
            // btnThongKeLuotMuon
            // 
            this.btnThongKeLuotMuon.Location = new System.Drawing.Point(210, 10);
            this.btnThongKeLuotMuon.Name = "btnThongKeLuotMuon";
            this.btnThongKeLuotMuon.Size = new System.Drawing.Size(180, 30);
            this.btnThongKeLuotMuon.TabIndex = 1;
            this.btnThongKeLuotMuon.Text = "Thống kê lượt mượn sách";
            this.btnThongKeLuotMuon.UseVisualStyleBackColor = true;
            // 
            // btnThongKeSVQuaHan
            // 
            this.btnThongKeSVQuaHan.Location = new System.Drawing.Point(10, 10);
            this.btnThongKeSVQuaHan.Name = "btnThongKeSVQuaHan";
            this.btnThongKeSVQuaHan.Size = new System.Drawing.Size(180, 30);
            this.btnThongKeSVQuaHan.TabIndex = 0;
            this.btnThongKeSVQuaHan.Text = "Sinh viên mượn quá hạn";
            this.btnThongKeSVQuaHan.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(2, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(583, 215);
            this.dataGridView1.TabIndex = 6;
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 361);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý mượn sách (Ngô Đức Nam Khánh – 2351060452)";
            this.Load += new System.EventHandler(this.form_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSach)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.pnlSapXep.ResumeLayout(false);
            this.pnlSapXep.PerformLayout();
            this.pnlThongKeOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dtgSach;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbTenSach;
        private System.Windows.Forms.ComboBox cbTenSV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DateTimePicker timeTra;
        private System.Windows.Forms.DateTimePicker timeMuon;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pnlSapXep;
        private System.Windows.Forms.RadioButton rbGiamDan;
        private System.Windows.Forms.RadioButton rbTangDan;
        private System.Windows.Forms.Label lblSapXep;
        private System.Windows.Forms.Panel pnlThongKeOptions;
        private System.Windows.Forms.Button btnThongKeLuotMuon;
        private System.Windows.Forms.Button btnThongKeSVQuaHan;
    }
}

