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
using DTO;
using BLL;

namespace GUI
{
    public partial class Addbooks : Form
    {
        string imagePath = "";
        public Addbooks()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            SachBLL sachBLL = new SachBLL();
            int validationCode = sachBLL.isValidBookAdd(txtId.Text,txtName.Text, txtAuthor.Text, txtPublic.Text, txtPrice.Text, txtQuantity.Text, imagePath);
            // Check validation result
            switch (validationCode)
            {
                case 1:
                    MessageBox.Show("Book ID must be a positive integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 2:
                    MessageBox.Show("Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 3:
                    MessageBox.Show("Author cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 4:
                    MessageBox.Show("Publication cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 5:
                    MessageBox.Show("Price must be a positive integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 6:
                    MessageBox.Show("Quantity must be a positive integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 7:
                    MessageBox.Show("Name cannot be digit.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 8:
                    MessageBox.Show("Author cannot be digit.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 9:
                    MessageBox.Show("Publication cannot be digit.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 10:
                    MessageBox.Show("Image is empty, please upload image.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 0:
                    Sach newSach = new Sach
                    {
                        id = int.Parse(txtId.Text),
                        Name = txtName.Text,
                        Author = txtAuthor.Text,
                        Publication = txtPublic.Text,
                        bDate = dataDate.Value,
                        Price = int.Parse(txtPrice.Text),
                        Quantity = int.Parse(txtQuantity.Text),
                        imgPath = imagePath
                    };
                    if (sachBLL.DoesBookExistAdd(newSach.id.ToString(),txtName.Text,txtAuthor.Text))
                    {
                        MessageBox.Show("The book id already exists.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    sachBLL.addBook(newSach);
                    MessageBox.Show("Book added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Refresh(); // Ensure the grid view is updated                       
                    break;
            }

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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This will delete your unsaved data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Addbooks_Load(object sender, EventArgs e)
        {

        }

    
    }
}

