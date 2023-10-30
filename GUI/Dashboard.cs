using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Addbooks addbook = new Addbooks();
            addbook.ShowDialog();
        }

        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Viewbooks viewbooks = new Viewbooks();
            viewbooks.ShowDialog();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.ShowDialog();
        }

        private void viewStudentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Viewstudent viewstudent = new Viewstudent();
            viewstudent.ShowDialog();
        }

        private void returnBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Returnbook returnbook = new Returnbook();
            returnbook.ShowDialog();
        }

        private void issueBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Issuebook issuebook = new Issuebook();
            issuebook.ShowDialog();
        }
    }
}
