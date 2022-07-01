using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Project project = new Project();
            project.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Parents parents = new Parents();
            parents.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            School school = new School();
            school.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Students students = new Students();
            students.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Specialities specialities = new Specialities();
            specialities.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            ReportCard reportCard = new ReportCard();
            reportCard.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            UploadFiles uploadFiles = new UploadFiles();
            uploadFiles.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
