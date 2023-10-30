using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using System.IO;

namespace GUI
{
    public partial class AddStudent : Form
    {
        string imagePath = "";
        public AddStudent()
        {
            InitializeComponent();
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Image";
            dlg.Filter = "Image Files (*.jpg;*.png)|*.jpg;*.png|JPEG files (*.jpg)|*.jpg|PNG files (*.png)|*.png";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                FileInfo fileInfo = new FileInfo(dlg.FileName);
                long fileSizeInBytes = fileInfo.Length;
                long fileSizeInKB = fileSizeInBytes / 1024;

                if (fileSizeInKB <= 1024)
                {
                    imagePath = dlg.FileName;
                }
                else
                {
                    MessageBox.Show("File size exceeds 1MB limit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StudentBLL studentBLL = new StudentBLL();
            int validationCode = studentBLL.isValidStudentAdd(txtId.Text, txtName.Text, txtEnroll.Text, txtSemester.SelectedItem != null ? txtSemester.SelectedItem.ToString() : "", txtMajor.Text, txtContact.Text,txtEmail.Text, imagePath);
            // Check validation result
            switch (validationCode)
            {
                case 1:
                    MessageBox.Show("Student ID must be a positive integer  with 10 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 2:
                    MessageBox.Show("Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 3:
                    MessageBox.Show("Enrollment cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 4:
                    MessageBox.Show("Major cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 5:
                    MessageBox.Show("Contact must be a positive integer and less than 10 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 6:
                    MessageBox.Show("Email cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 7:
                    MessageBox.Show("Image is empty, please upload image.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 8:
                    MessageBox.Show("Name cannot be digit.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 9:
                    MessageBox.Show("Major cannot be digit.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 10:
                    MessageBox.Show("Contact cannot be more than 10 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 11:
                    MessageBox.Show("Email must have @.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 12:
                    MessageBox.Show("Semester cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 0:
                    Student newStudent = new Student
                    {
                        id = int.Parse(txtId.Text),
                        Name = txtName.Text,
                        Enroll = txtEnroll.Text,
                        Major = txtMajor.Text,
                        Semester = int.Parse(txtSemester.SelectedItem.ToString()),
                        Contact = int.Parse(txtContact.Text),
                        Email = txtEmail.Text,
                        imgPath = imagePath
                    };

                    if (studentBLL.DoesStudentExistAdd(newStudent.id.ToString()))
                    {
                        MessageBox.Show("The student id already exists.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    studentBLL.addStudent(newStudent);
                    MessageBox.Show("Student added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Refresh(); // Ensure the grid view is updated                       
                    break;
            }
        }

        private void btnImportExcel_Click(object sender, EventArgs e)
        {

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
