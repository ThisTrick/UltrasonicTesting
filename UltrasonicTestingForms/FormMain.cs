using System;
using System.Drawing;
using System.Windows.Forms;

namespace UltrasonicTestingForms
{
    public partial class FormMain : Form
    {
        private Control selectedButton;
        private Form selectedForm;
        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Изменение выбранной кнопки.
        /// </summary>
        /// <param name="btnSender">Нажатая кнопка.</param>
        private void SelectButton(object btnSender)
        {
            if (btnSender is null)
            {
                throw new ArgumentNullException(nameof(btnSender));
            }
            var clickedButtun = btnSender as Control ?? throw new InvalidCastException(nameof(btnSender) + "is not Control");
            if (clickedButtun != selectedButton)
            {
                if (selectedButton != null)
                {
                    selectedButton.BackColor = Color.FromArgb(51, 51, 76);
                }
                clickedButtun.BackColor = Color.FromArgb(30, 150, 195);
                selectedButton = clickedButtun;
                TitleLabel.Text = selectedButton.Text.ToUpper();
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (childForm is null || btnSender is null)
            {
                throw new ArgumentNullException(nameof(childForm));
            }
            if (selectedForm == null || childForm.GetType() != selectedForm.GetType())
            {
                selectedForm?.Close();
                SelectButton(btnSender);
                selectedForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                this.DesktopPanel.Controls.Add(childForm);
                this.DesktopPanel.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
        }
        private void btnParams_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormParams(), sender);
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormResult(), sender);
        }

        private void btnAddMaterial_Click(object sender, EventArgs e)
        {

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormInfo(), sender);
        }
    }
}
