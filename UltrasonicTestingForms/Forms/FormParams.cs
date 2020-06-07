using System;
using System.ComponentModel;
using System.Windows.Forms;
using UltrasonicTestingForms.Controllers;

namespace UltrasonicTestingForms.Forms
{
    public partial class FormParams : Form
    {
        private AppConfigController configController;
        public FormParams()
        {
            InitializeComponent();
            configController = new AppConfigController();
            XMLMaterialsController materialsController = new XMLMaterialsController();
            var names = materialsController.GetNameMaterials();
            cmbMaterialPEC.Items.Clear();
            cmbMaterialTO.Items.Clear();
            cmbMaterialPEC.Items.AddRange(names);
            cmbMaterialTO.Items.AddRange(names);
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
            configController.SetValue("amplitude", txtAmplitude.Text);
            configController.SetValue("frequency", txtFrequency.Text);
            configController.SetValue("radiusPEC", txtRadius.Text);
            configController.SetValue("thicknessTO", txtThickness.Text);
            configController.SetValue("materialTO", cmbMaterialTO.SelectedItem as string);
            configController.SetValue("materialPEC", cmbMaterialPEC.SelectedItem as string);
            MessageBox.Show("Данные записаны");
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
            var nameMaterial = formAddMaterial.Text;
            cmbMaterialPEC.Items.Add(nameMaterial);
            cmbMaterialTO.Items.Add(nameMaterial);
        }
    }
}
