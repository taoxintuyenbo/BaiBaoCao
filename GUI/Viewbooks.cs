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
    public partial class Viewbooks : Form
    {
        string imagePath = "";
        public Viewbooks()
        {
            InitializeComponent();
        }
        public void Refresh()
        {
            SachBLL sachbll = new SachBLL();
            List<Sach> dssachbll = sachbll.laytoanbosach();
            gvDSSach.DataSource = dssachbll;
        }
        private void Viewbooks_Load(object sender, EventArgs e)
        {
            SachBLL sachbll = new SachBLL();
            List<Sach> dssachbll = sachbll.laytoanbosach();
            gvDSSach.DataSource = dssachbll;
            pnChangeInfo.Visible = false;

        }

        //private void gvDSSach_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    SachBLL sachBLL = new SachBLL();
        //    if (e.RowIndex >= 0)
        //    {
        //        int selectedId = Convert.ToInt32(gvDSSach.Rows[e.RowIndex].Cells["id"].Value);
        //        Sach selectedSach = sachBLL.LaySachTheoId(selectedId);

        //        if (selectedSach != null)
        //        {
        //            // Display the selected book information in TextBoxes or other controls
        //            txtName.Text = selectedSach.Name;
        //            txtAuthor.Text = selectedSach.Author;
        //        }
        //    }
        //}

        private void gvDSSach_Click(object sender, EventArgs e)
        {
            pnChangeInfo.Visible = true;
            SachBLL sachBLL = new SachBLL();
            if (gvDSSach.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(gvDSSach.SelectedRows[0].Cells["id"].Value);
                Sach selectedSach = sachBLL.LaySachTheoId(selectedId);
                if (selectedSach != null)
                {
                    
                    txtName.Text = selectedSach.Name;
                    txtAuthor.Text = selectedSach.Author;
                    txtPublic.Text = selectedSach.Publication;
                    dataDate.Value = selectedSach.bDate;
                    txtPrice.Text = selectedSach.Price.ToString();
                    txtQuantity.Text = selectedSach.Quantity.ToString();
                    pbImage.Image = Image.FromFile(selectedSach.imgPath);
                    imagePath = selectedSach.imgPath;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gvDSSach.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(gvDSSach.SelectedRows[0].Cells["id"].Value);

                SachBLL sach = new SachBLL();
                sach.xoasach(selectedId);
                // Refresh the grid view after deletion
                Refresh();
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SachBLL sachBLL = new SachBLL();
            int selectedId = Convert.ToInt32(gvDSSach.SelectedRows[0].Cells["id"].Value);
            //string selectedImgPath = (string)gvDSSach.SelectedRows[0].Cells["imgPath"].Value;

            if (selectedId == -1)
            {
                MessageBox.Show("Please select a book to update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Sach existingSach = sachBLL.LaySachTheoId(selectedId);
            int validationCode = sachBLL.isValidBookUpdate(txtName.Text,txtAuthor.Text,txtPublic.Text, txtPrice.Text, txtQuantity.Text,imagePath);
            // Check validation result
            switch (validationCode)
            {
                case 1:
                    MessageBox.Show("Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 2:
                    MessageBox.Show("Author cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 3:
                    MessageBox.Show("Publication cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 4:
                    MessageBox.Show("Price must be a positive integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 5:
                    MessageBox.Show("Quantity must be a positive integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 6:
                    MessageBox.Show("Name cannot be digit.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 7:
                    MessageBox.Show("Author cannot be digit.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 8:
                    MessageBox.Show("Publication cannot be digit.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 9:
                    MessageBox.Show("Image is empty, please upload your image.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 10:
                    MessageBox.Show("Book ID must be a positive integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 0:
                    Sach newSach = new Sach
                    {
                       
                        Name = txtName.Text,
                        Author = txtAuthor.Text,
                        Publication = txtPublic.Text,
                        bDate = dataDate.Value,
                        Price = int.Parse(txtPrice.Text),
                        Quantity = int.Parse(txtQuantity.Text),
                        imgPath = imagePath
                    };
                    if (!sachBLL.AreEqual(existingSach, newSach))
                    {
                        if (sachBLL.DoesBookExistUpdate(txtName.Text, txtAuthor.Text))
                        {
                            MessageBox.Show("The book already exists.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        DialogResult result = MessageBox.Show("Are you sure you want to update this book?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            sachBLL.updateBook(selectedId, newSach);
                            MessageBox.Show("Book updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Refresh(); // Ensure the grid view is updated
                        }
                    }
                    break;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            pnChangeInfo.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This will delete your unsaved data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text!=null)
            {
                SachBLL sach = new SachBLL();
                gvDSSach.DataSource = sach.searchBook(txtSearch.Text);
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
                    pbImage.ImageLocation = dlg.FileName;
                }
                else
                {
                    MessageBox.Show("File size exceeds 1MB limit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
