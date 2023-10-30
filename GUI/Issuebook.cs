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
    public partial class Issuebook : Form
    {
        StudentBLL studentBLL = new StudentBLL();
        SachBLL sachBLL = new SachBLL();
        BookIssueBLL bookIssueBLL = new BLL.BookIssueBLL();
        public Issuebook()
        {
            InitializeComponent();
            label12.Visible = false;
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
                    Student selectedStudent = studentBLL.GetStudentById(selectedId);
                    if (selectedStudent != null)
                    {
                        txtName.Text = selectedStudent.Name;
                        txtEnroll.Text = selectedStudent.Enroll;
                        txtMajor.Text = selectedStudent.Major;
                        txtSemester.Text = selectedStudent.Semester.ToString();
                        txtContact.Text = selectedStudent.Contact.ToString();
                        txtEmail.Text = selectedStudent.Email;
                        pbImage.Image = Image.FromFile(selectedStudent.imgPath);
                        List<string> bookNames = sachBLL.GetBookNames();
                        comboBookName.Items.AddRange(bookNames.ToArray());
                        label12.Visible = false;
                        comboBookName.Enabled = true;
                    }
                    else
                    {
                        label12.Visible = true;
                        txtName.Clear();
                        txtEnroll.Clear();
                        txtMajor.Clear();
                        txtSemester.Clear();
                        txtContact.Clear();
                        txtEmail.Clear();
                        Image image = Image.FromFile("E:\\BaiBaoCao\\Liberay Management System\\icons8-student-male-100.png");
                        pbImage.Image = image;
                      
                    }
                    break;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            txtName.Clear();
            txtEnroll.Clear();
            txtMajor.Clear();
            txtSemester.Clear();
            txtContact.Clear();
            txtEmail.Clear();
            Image image = Image.FromFile("E:\\BaiBaoCao\\Liberay Management System\\icons8-student-male-100.png");
            pbImage.Image = image;
            label12.Visible = false;
            comboBookName.Items.Clear();
            comboBookName.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This will delete your unsaved data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            int validationStudentID = studentBLL.validationStudentID(txtSearch.Text);
            string id = txtSearch.Text;
        
            switch (validationStudentID)
            {
                case 1:
                    MessageBox.Show("Student ID must be a positive integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 2:
                    MessageBox.Show("Student ID has 10 digit.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 0:
                    int validationBookIssue = bookIssueBLL.validationBookIssue(id, comboBookName.SelectedItem != null ? comboBookName.SelectedItem.ToString() : "");
                    switch (validationBookIssue)
                    {
                        case 1:
                            MessageBox.Show("You have issued 3 books.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case 2:
                            MessageBox.Show("Please choose a book.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case 3:
                            MessageBox.Show("You have already issued this book.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case 0:
                            Issue newIssue = new Issue
                            {
                                StudentID = int.Parse(txtSearch.Text),                           
                                StudentName = txtName.Text,
                                Enrollment = txtEnroll.Text,
                                Major = txtMajor.Text,
                                Semestor =  int.Parse(txtSemester.Text),
                                Contact = int.Parse(txtContact.Text),
                                Email = txtEmail.Text,
                                BookName = comboBookName.SelectedItem.ToString(), 
                                IssueDate = DateTime.Now,
                                
                            };
                            bookIssueBLL.issueBook(newIssue);
                            MessageBox.Show("Book issued successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                    }
                    break;
            }    
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

