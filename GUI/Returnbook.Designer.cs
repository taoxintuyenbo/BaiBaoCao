
namespace GUI
{
    partial class Returnbook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Returnbook));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gvDSBI = new System.Windows.Forms.DataGridView();
            this.panelReturn = new System.Windows.Forms.Panel();
            this.txtDateIssue = new System.Windows.Forms.TextBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataDate = new System.Windows.Forms.DateTimePicker();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSBI)).BeginInit();
            this.panelReturn.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.pbImage);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 462);
            this.panel1.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(68, 279);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(224, 20);
            this.label12.TabIndex = 46;
            this.label12.Text = "Student has not issued yet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label2.Location = new System.Drawing.Point(82, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 29);
            this.label2.TabIndex = 40;
            this.label2.Text = "Enter Student ID";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(193, 391);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(105, 50);
            this.btnExit.TabIndex = 45;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pbImage
            // 
            this.pbImage.Image = ((System.Drawing.Image)(resources.GetObject("pbImage.Image")));
            this.pbImage.Location = new System.Drawing.Point(103, 1);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(168, 150);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 41;
            this.pbImage.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(57, 390);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(105, 50);
            this.btnRefresh.TabIndex = 44;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(64, 237);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(234, 26);
            this.txtSearch.TabIndex = 42;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(78, 317);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(207, 60);
            this.btnSearch.TabIndex = 43;
            this.btnSearch.Text = "Search Student";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gvDSBI
            // 
            this.gvDSBI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDSBI.Location = new System.Drawing.Point(431, 12);
            this.gvDSBI.Name = "gvDSBI";
            this.gvDSBI.RowHeadersWidth = 62;
            this.gvDSBI.RowTemplate.Height = 28;
            this.gvDSBI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvDSBI.Size = new System.Drawing.Size(778, 462);
            this.gvDSBI.TabIndex = 1;
            this.gvDSBI.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDSBI_CellClick);
            // 
            // panelReturn
            // 
            this.panelReturn.BackColor = System.Drawing.Color.Bisque;
            this.panelReturn.Controls.Add(this.txtDateIssue);
            this.panelReturn.Controls.Add(this.btnExcel);
            this.panelReturn.Controls.Add(this.btnCancel);
            this.panelReturn.Controls.Add(this.txtName);
            this.panelReturn.Controls.Add(this.label1);
            this.panelReturn.Controls.Add(this.dataDate);
            this.panelReturn.Controls.Add(this.btnReturn);
            this.panelReturn.Controls.Add(this.label9);
            this.panelReturn.Controls.Add(this.label10);
            this.panelReturn.Location = new System.Drawing.Point(431, 492);
            this.panelReturn.Name = "panelReturn";
            this.panelReturn.Size = new System.Drawing.Size(778, 255);
            this.panelReturn.TabIndex = 2;
            // 
            // txtDateIssue
            // 
            this.txtDateIssue.Enabled = false;
            this.txtDateIssue.Location = new System.Drawing.Point(282, 115);
            this.txtDateIssue.Name = "txtDateIssue";
            this.txtDateIssue.Size = new System.Drawing.Size(278, 26);
            this.txtDateIssue.TabIndex = 49;
            // 
            // btnExcel
            // 
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Location = new System.Drawing.Point(606, 56);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(105, 37);
            this.btnExcel.TabIndex = 48;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(606, 110);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 37);
            this.btnCancel.TabIndex = 47;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(282, 56);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(278, 26);
            this.txtName.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Date Return";
            // 
            // dataDate
            // 
            this.dataDate.Enabled = false;
            this.dataDate.Location = new System.Drawing.Point(282, 171);
            this.dataDate.Name = "dataDate";
            this.dataDate.Size = new System.Drawing.Size(278, 26);
            this.dataDate.TabIndex = 41;
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(606, 160);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(105, 37);
            this.btnReturn.TabIndex = 39;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(84, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 20);
            this.label9.TabIndex = 40;
            this.label9.Text = "Book Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(84, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 20);
            this.label10.TabIndex = 42;
            this.label10.Text = "Date Issue";
            // 
            // Returnbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1221, 772);
            this.Controls.Add(this.panelReturn);
            this.Controls.Add(this.gvDSBI);
            this.Controls.Add(this.panel1);
            this.Name = "Returnbook";
            this.Text = "Returnbook";
            this.Load += new System.EventHandler(this.Returnbook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSBI)).EndInit();
            this.panelReturn.ResumeLayout(false);
            this.panelReturn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gvDSBI;
        private System.Windows.Forms.Panel panelReturn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dataDate;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtDateIssue;
    }
}