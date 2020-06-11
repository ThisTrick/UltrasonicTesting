using System;
using System.ComponentModel;
using System.Windows.Forms;
using UltrasonicTesting.Controllers;

namespace UltrasonicTestingForms.Forms
{
    public partial class FormParams : Form
    {
        private AppConfigController configController;
        XMLMaterialsController materialsController;
        public FormParams()
        {
            InitializeComponent();
            configController = new AppConfigController();
            var path = "MaterialsBD.xml";
            materialsController = new XMLMaterialsController(path);
            UpdateNames(cmbMaterialTO, cmbMaterialPEC);
        }
        private void btnPush_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            string message = "Пожалуйста, заполните поле!";
            if (string.IsNullOrEmpty(txtAmplitude.Text))
            {
                errorProvider.SetError(txtAmplitude, message);
                return;
            }
            if (string.IsNullOrEmpty(txtFrequency.Text))
            {
                errorProvider.SetError(txtFrequency, message);
                return;
            }
            if (string.IsNullOrEmpty(txtRadius.Text))
            {
                errorProvider.SetError(txtRadius, message);
                return;
            }
            if (string.IsNullOrEmpty(txtThickness.Text))
            {
                errorProvider.SetError(txtThickness, message);
                return;
            }
            if (cmbMaterialTO.SelectedItem is null)
            {
                errorProvider.SetError(cmbMaterialTO, message);
                return;
            }
            if (cmbMaterialPEC.SelectedItem is null)
            {
                errorProvider.SetError(cmbMaterialPEC, message);
                return;
            }
            WriteToXML();
        }

        private void WriteToXML()
        {
            configController.SetValue("amplitude", txtAmplitude.Text);
            configController.SetValue("frequency", txtFrequency.Text);
            configController.SetValue("radiusPEC", txtRadius.Text);
            configController.SetValue("thicknessTO", txtThickness.Text);
            configController.SetValue("materialTO", cmbMaterialTO.SelectedItem as string);
            configController.SetValue("materialPEC", cmbMaterialPEC.SelectedItem as string);
            MessageBox.Show("Данные записаны");
        }

        private void UpdateNames(params ComboBox[] comboBoxes)
        {
            var _names = materialsController.GetNameMaterials();
            foreach(var comboBox in comboBoxes)
            {
                comboBox.Items.Clear();
                comboBox.Items.AddRange(_names);
            }
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

        private void bAddMaterial_Click(object sender, EventArgs e)
        {
            Form formAddMaterial = new FormAddMaterial();
            formAddMaterial.ShowDialog();
            UpdateNames(cmbMaterialTO, cmbMaterialPEC);
        }
    }
}
