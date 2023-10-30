using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BLL;
using DTO;

namespace GUI
{
    public partial class Viewstudent : Form
    {
        string imagePath="";
        public Viewstudent()
        {
            InitializeComponent();
        }
        public void Refresh()
        {
            StudentBLL studentBLL = new StudentBLL();
            List<Student> dssinhVienBLL = studentBLL.laytoanbosinhvien();
            gvDSSINHVIEN.DataSource = dssinhVienBLL;
        }
        private void Viewstudent_Load(object sender, EventArgs e)
        {
            StudentBLL studentBLL = new StudentBLL();
            List<Student> dssinhVienBLL = studentBLL.laytoanbosinhvien();
            gvDSSINHVIEN.DataSource = dssinhVienBLL;
            pnChangeInfo.Visible = false;
            Image image = Image.FromFile("E:\\BaiBaoCao\\Liberay Management System\\icons8-student-male-100.png");
            pbImage.Image = image;
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
                    pbImage.ImageLocation = dlg.FileName;
                }
                else
                {
                    MessageBox.Show("File size exceeds 1MB limit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            StudentBLL studentBLL = new StudentBLL();
            int selectedId = Convert.ToInt32(gvDSSINHVIEN.SelectedRows[0].Cells["id"].Value);
            if (selectedId == -1)
            {
                MessageBox.Show("Please select a book to update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Student existingStudent = studentBLL.GetStudentById(selectedId);

            int validationCode = studentBLL.isValidStudentUpdate(txtName.Text, txtEnroll.Text, txtSemester.SelectedItem != null ? txtSemester.SelectedItem.ToString() : "", txtMajor.Text, txtContact.Text, txtEmail.Text, imagePath);
            // Check validation result
            switch (validationCode)
            {
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
                        Name = txtName.Text,
                        Enroll = txtEnroll.Text,
                        Major = txtMajor.Text,
                        Semester = int.Parse(txtSemester.SelectedItem.ToString()),
                        Contact = int.Parse(txtContact.Text),
                        Email = txtEmail.Text,
                        imgPath = imagePath
                    };

                    if (!studentBLL.AreEqual(existingStudent, newStudent))
                    {                       
                        DialogResult result = MessageBox.Show("Are you sure you want to update this student?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            studentBLL.updateStudent(selectedId, newStudent);
                            MessageBox.Show("Book updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Refresh(); // Ensure the grid view is updated
                        }
                    }
                    break;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gvDSSINHVIEN.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(gvDSSINHVIEN.SelectedRows[0].Cells["id"].Value);

                StudentBLL student = new StudentBLL();
                student.deleteStudent(selectedId);
                // Refresh the grid view after deletion
                Refresh();
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
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

        private void btnExport_Click(object sender, EventArgs e)
        {

        }

        private void gvDSSINHVIEN_Click(object sender, EventArgs e)
        {
            pnChangeInfo.Visible = true;
            StudentBLL studentBLL = new StudentBLL();

            if (gvDSSINHVIEN.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(gvDSSINHVIEN.SelectedRows[0].Cells["id"].Value);
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
                    imagePath = selectedStudent.imgPath;
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            pnChangeInfo.Visible = false;
        }
      
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != null)
            {
                Image image = Image.FromFile("E:\\BaiBaoCao\\Liberay Management System\\search1.gif");
                pictureBox1.Image = image;
                label9.Visible = false;
                StudentBLL student = new StudentBLL();
                gvDSSINHVIEN.DataSource = student.searchStudent(txtSearch.Text);
            }
            if(txtSearch.Text == null|| txtSearch.Text == "")
            {
                Image image = Image.FromFile("E:\\BaiBaoCao\\Liberay Management System\\search.gif");
                pictureBox1.Image = image;
                label9.Visible = true;
            }
        }
    }
}
