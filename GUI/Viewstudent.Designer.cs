
namespace GUI
{
    partial class Viewstudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Viewstudent));
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnImage = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtMajor = new System.Windows.Forms.TextBox();
            this.txtEnroll = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.gvDSSINHVIEN = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnChangeInfo = new System.Windows.Forms.Panel();
            this.txtSemester = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSSINHVIEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnChangeInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(1027, 154);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(167, 201);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 23;
            this.pbImage.TabStop = false;
            // 
            // btnImage
            // 
            this.btnImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImage.Location = new System.Drawing.Point(910, 155);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(75, 36);
            this.btnImage.TabIndex = 22;
            this.btnImage.Text = "Image";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(776, 309);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 36);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(668, 309);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(80, 36);
            this.btnExport.TabIndex = 20;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(560, 309);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(81, 36);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(438, 309);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 36);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(861, 88);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(333, 26);
            this.txtEmail.TabIndex = 16;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(861, 29);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(333, 26);
            this.txtContact.TabIndex = 15;
            // 
            // txtMajor
            // 
            this.txtMajor.Location = new System.Drawing.Point(257, 145);
            this.txtMajor.Name = "txtMajor";
            this.txtMajor.Size = new System.Drawing.Size(333, 26);
            this.txtMajor.TabIndex = 14;
            // 
            // txtEnroll
            // 
            this.txtEnroll.Location = new System.Drawing.Point(257, 89);
            this.txtEnroll.Name = "txtEnroll";
            this.txtEnroll.Size = new System.Drawing.Size(333, 26);
            this.txtEnroll.TabIndex = 13;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(257, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(333, 26);
            this.txtName.TabIndex = 12;
            // 
            // gvDSSINHVIEN
            // 
            this.gvDSSINHVIEN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDSSINHVIEN.Location = new System.Drawing.Point(24, 246);
            this.gvDSSINHVIEN.Name = "gvDSSINHVIEN";
            this.gvDSSINHVIEN.RowHeadersWidth = 62;
            this.gvDSSINHVIEN.RowTemplate.Height = 28;
            this.gvDSSINHVIEN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvDSSINHVIEN.Size = new System.Drawing.Size(1226, 323);
            this.gvDSSINHVIEN.TabIndex = 10;
            this.gvDSSINHVIEN.Click += new System.EventHandler(this.gvDSSINHVIEN_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(833, 181);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(113, 40);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(512, 188);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(294, 28);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(369, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Student ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(713, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Students";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(508, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnChangeInfo
            // 
            this.pnChangeInfo.AutoScroll = true;
            this.pnChangeInfo.BackColor = System.Drawing.Color.DarkGray;
            this.pnChangeInfo.Controls.Add(this.txtSemester);
            this.pnChangeInfo.Controls.Add(this.label10);
            this.pnChangeInfo.Controls.Add(this.label11);
            this.pnChangeInfo.Controls.Add(this.label12);
            this.pnChangeInfo.Controls.Add(this.label13);
            this.pnChangeInfo.Controls.Add(this.label14);
            this.pnChangeInfo.Controls.Add(this.label15);
            this.pnChangeInfo.Controls.Add(this.pbImage);
            this.pnChangeInfo.Controls.Add(this.btnImage);
            this.pnChangeInfo.Controls.Add(this.btnCancel);
            this.pnChangeInfo.Controls.Add(this.btnExport);
            this.pnChangeInfo.Controls.Add(this.btnDelete);
            this.pnChangeInfo.Controls.Add(this.btnUpdate);
            this.pnChangeInfo.Controls.Add(this.txtEmail);
            this.pnChangeInfo.Controls.Add(this.txtContact);
            this.pnChangeInfo.Controls.Add(this.txtMajor);
            this.pnChangeInfo.Controls.Add(this.txtEnroll);
            this.pnChangeInfo.Controls.Add(this.txtName);
            this.pnChangeInfo.Location = new System.Drawing.Point(24, 588);
            this.pnChangeInfo.Name = "pnChangeInfo";
            this.pnChangeInfo.Size = new System.Drawing.Size(1226, 387);
            this.pnChangeInfo.TabIndex = 11;
            // 
            // txtSemester
            // 
            this.txtSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtSemester.FormattingEnabled = true;
            this.txtSemester.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.txtSemester.Location = new System.Drawing.Point(257, 208);
            this.txtSemester.Name = "txtSemester";
            this.txtSemester.Size = new System.Drawing.Size(333, 28);
            this.txtSemester.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(688, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 20);
            this.label10.TabIndex = 29;
            this.label10.Text = "Student Email";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(688, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(141, 20);
            this.label11.TabIndex = 28;
            this.label11.Text = "Student Contact";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(78, 208);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(155, 20);
            this.label12.TabIndex = 27;
            this.label12.Text = "Student Semester";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(80, 155);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 20);
            this.label13.TabIndex = 26;
            this.label13.Text = "Student Major";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(80, 95);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(122, 20);
            this.label14.TabIndex = 25;
            this.label14.Text = "Enrollment No";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(78, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(124, 20);
            this.label15.TabIndex = 24;
            this.label15.Text = "Student Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(23, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1226, 150);
            this.panel1.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(713, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 32);
            this.label9.TabIndex = 2;
            this.label9.Text = "View";
            // 
            // Viewstudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1275, 997);
            this.Controls.Add(this.gvDSSINHVIEN);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnChangeInfo);
            this.Controls.Add(this.panel1);
            this.Name = "Viewstudent";
            this.Text = "Viewstudent";
            this.Load += new System.EventHandler(this.Viewstudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSSINHVIEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnChangeInfo.ResumeLayout(false);
            this.pnChangeInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtMajor;
        private System.Windows.Forms.TextBox txtEnroll;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView gvDSSINHVIEN;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnChangeInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox txtSemester;
    }
}