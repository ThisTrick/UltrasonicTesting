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
        }
        private void btnPush_Click(object sender, EventArgs e)
        {
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
            configController.SetValue("amplitude", txtAmplitude.Text);
            configController.SetValue("frequency", txtFrequency.Text);
            configController.SetValue("radiusPEC", txtRadius.Text);
            configController.SetValue("thicknessTO", txtThickness.Text);

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
