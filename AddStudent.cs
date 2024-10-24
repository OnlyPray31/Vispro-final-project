using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm?", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtStudentName.Clear();
            txtStudentID.Clear();
            txtFaculty.Clear();
            txtStudentSmster.Clear();
            txtStudentContact.Clear();
            txtStudentEmail.Clear();

            //txtStudentEmail.text = "";

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String name = txtStudentName.Text;
            String ID = txtStudentID.Text;
            String faculty = txtFaculty.Text;
            String smster = txtStudentSmster.Text;
            Int64 contact = Int64.Parse(txtStudentContact.Text);
            Int64 email = txtStudentEmail.Text;
        }
    }
}
