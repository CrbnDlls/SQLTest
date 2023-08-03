using SQLTest.Forms;
using SQLTest.Interfaces;

namespace SQLTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sourcesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSource formSources = new FormSource();
            this.IsMdiContainer = true;
            formSources.MdiParent = this;
            formSources.WindowState = FormWindowState.Maximized;
            formSources.Show();
        }

        private void emissionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmission formEmissions = new FormEmission();
            this.IsMdiContainer = true;
            formEmissions.MdiParent = this;
            formEmissions.WindowState = FormWindowState.Maximized;
            formEmissions.Show();
        }
    }
}