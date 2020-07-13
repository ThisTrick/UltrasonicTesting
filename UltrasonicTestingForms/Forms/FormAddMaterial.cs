using System;
using System.ComponentModel;
using System.Windows.Forms;
using UltrasonicTesting.Controllers;
using UltrasonicTesting.Models;

namespace UltrasonicTestingForms.Forms
{
    public partial class FormAddMaterial : Form
    {
        private XMLMaterialsController materialsController;
        public FormAddMaterial()
        {
            InitializeComponent();
            var path = "MaterialsBD.xml";
            materialsController = new XMLMaterialsController(path);
        }

        private void bPush_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            string message = "The field cannot be empty";

            if (string.IsNullOrEmpty(txtName.Text))
            {
                errorProvider.SetError(txtName, message);
                return;
            }
            if (string.IsNullOrEmpty(txtSpeedOfSound.Text))
            {
                errorProvider.SetError(txtSpeedOfSound, message);
                return;
            }
            if (string.IsNullOrEmpty(txtDensity.Text))
            {
                errorProvider.SetError(txtDensity, message);
                return;
            }
            if (string.IsNullOrEmpty(txtFSPL.Text))
            {
                errorProvider.SetError(txtFSPL, message);
                return;
            }

            double.TryParse(txtSpeedOfSound.Text, out double speedOfSound);
            double.TryParse(txtDensity.Text, out double density);
            double.TryParse(txtFSPL.Text, out double fspl);

            var material = new Material(txtName.Text, speedOfSound, density, fspl);

            materialsController.SetMaterial(material);
            MessageBox.Show("Material added.");
            this.Close();
        }
        private void ValidatingDouble(object sender, CancelEventArgs e)
        {
            errorProvider.Clear();
            TextBox textBox = (TextBox)sender;
            if (!double.TryParse(textBox.Text, out double result))
            {
                e.Cancel = true;
                errorProvider.SetError(textBox, "Please enter a number!");
                return;
            }
            if (result <= 0)
            {
                e.Cancel = true;
                errorProvider.SetError(textBox, "Please enter a number greater than zero!");
                return;
            }
        }
    }
}
