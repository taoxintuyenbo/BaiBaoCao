using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI
{
    public partial class Returnbook : Form
    {
        StudentBLL studentBLL = new StudentBLL();
        SachBLL sachBLL = new SachBLL();
        BookIssueBLL bookIssueBLL = new BLL.BookIssueBLL();
        public Returnbook()
        {
            InitializeComponent();
        }

   
        private void btnSearch_Click(object sender, EventArgs e)
        {
         
            int validationStudentID = studentBLL.validationStudentID(txtSearch.Text);
            switch (validationStudentID)
            {
                case 1:
                    MessageBox.Show("Student ID must be a positive integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 2:
                    MessageBox.Show("Student ID has 10 digit.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 0:
                    int selectedId = Convert.ToInt32(txtSearch.Text);
                    List<Issue> dsis = bookIssueBLL.studentIssue(selectedId);
                    if (dsis.Count == 0)
                    {
                        label12.Visible = true;
                        panelReturn.Visible = false;
                        gvDSBI.DataSource = null;
                    }
                    else
                    {
                        gvDSBI.DataSource = dsis;
                        label12.Visible = false;
                    }
                    break;
            }
        }



        private void Returnbook_Load(object sender, EventArgs e)
        {
            label12.Visible = false;
            panelReturn.Visible = false;
        }

        private void gvDSBI_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panelReturn.Visible = true;
            if (gvDSBI.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(gvDSBI.SelectedRows[0].Cells["StudentID"].Value);
                string selectedName = gvDSBI.SelectedRows[0].Cells["BookName"].Value.ToString();
                Issue selectedIssue = bookIssueBLL.BookIssueById(selectedId, selectedName);
                if (selectedIssue != null)
                {
                    txtName.Text = selectedIssue.BookName;
                    txtDateIssue.Text = selectedIssue.IssueDate.ToString("yyyy-MM-dd");
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            label12.Visible = false;
            panelReturn.Visible = false;
            gvDSBI.DataSource = null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This will delete your unsaved data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to return this book?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                bookIssueBLL.ReturnBook(int.Parse(txtSearch.Text), txtName.Text, dataDate.Value.Date);
                MessageBox.Show("Book returned successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSearch_Click(sender, e);
            }
          

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This will delete your unsaved data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
