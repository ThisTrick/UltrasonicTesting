using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UltrasonicTesting.Models;
using UltrasonicTestingForms.Controllers;

namespace UltrasonicTestingForms.Forms
{
    public partial class FormAddMaterial : Form
    {
        public string NameMaterial;
        public FormAddMaterial()
        {
            InitializeComponent();
            XMLMaterialsController materialsController = new XMLMaterialsController();
            var names = materialsController.GetNameMaterials();
        }

        private void bPush_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            string message = "Поле не может быть пустым";
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
            var material = new Material(speedOfSound, density, fspl);
            var materialsController = new XMLMaterialsController();
            materialsController.SetMaterial(material, txtName.Text);
            MessageBox.Show("Материал добавлен.");
            this.Text = txtName.Text;
            this.Close();
        }
        private void ValidatingDouble(object sender, CancelEventArgs e)
        {
            errorProvider.Clear();
            TextBox textBox = (TextBox)sender;
            if (!double.TryParse(textBox.Text, out double result))
            {
                e.Cancel = true;
                errorProvider.SetError(textBox, "Пожалуйста, введите число!");
                return;
            }
            if (result <= 0)
            {
                e.Cancel = true;
                errorProvider.SetError(textBox, "Пожалуйста, введите число  больше нуля!");
                return;
            }
        }
    }
}
