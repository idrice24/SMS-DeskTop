using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SMS
{
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }
        public void loadForm(object Form)
        {
             if (this.mainpanel.Controls.Count > 0)
                 this.mainpanel.Controls.RemoveAt(0);
             Form f = Form as Form;
             f.TopLevel = false;
             f.Dock = DockStyle.Fill;
             this.mainpanel.Controls.Add(f);
             f.Show();
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadForm(new addteachers());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadForm(new listteachers());
        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            loadForm(new dashboardform());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            Teacher tea = new Teacher();
            tea.Close();
        }
    }
}
