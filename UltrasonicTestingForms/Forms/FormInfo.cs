using System.Windows.Forms;

namespace UltrasonicTestingForms.Forms
{
    public partial class FormInfo : Form
    {
        public FormInfo()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, System.EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ThisTrick/UltrasonicTesting");
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://ela.kpi.ua/handle/123456789/27002");
        }
    }
}
