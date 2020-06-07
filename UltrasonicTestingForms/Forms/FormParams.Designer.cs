namespace UltrasonicTestingForms.Forms
{
    partial class FormParams
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.lbRadius = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmplitude = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFrequency = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtThickness = new System.Windows.Forms.TextBox();
            this.cmbMaterialTO = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMaterialPEC = new System.Windows.Forms.ComboBox();
            this.btnPush = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.bAddMaterial = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRadius
            // 
            this.txtRadius.BackColor = System.Drawing.Color.White;
            this.txtRadius.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRadius.ForeColor = System.Drawing.Color.Black;
            this.txtRadius.Location = new System.Drawing.Point(372, 29);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRadius.Size = new System.Drawing.Size(269, 43);
            this.txtRadius.TabIndex = 0;
            this.txtRadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRadius.Validating += new System.ComponentModel.CancelEventHandler(this.ValidatingDouble);
            // 
            // lbRadius
            // 
            this.lbRadius.AutoSize = true;
            this.lbRadius.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRadius.ForeColor = System.Drawing.Color.Black;
            this.lbRadius.Location = new System.Drawing.Point(67, 30);
            this.lbRadius.Name = "lbRadius";
            this.lbRadius.Size = new System.Drawing.Size(211, 41);
            this.lbRadius.TabIndex = 1;
            this.lbRadius.Text = "Радиус ПЕП:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(67, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Амплитуда:";
            // 
            // txtAmplitude
            // 
            this.txtAmplitude.BackColor = System.Drawing.Color.White;
            this.txtAmplitude.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmplitude.ForeColor = System.Drawing.Color.Black;
            this.txtAmplitude.Location = new System.Drawing.Point(372, 78);
            this.txtAmplitude.Name = "txtAmplitude";
            this.txtAmplitude.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAmplitude.Size = new System.Drawing.Size(269, 43);
            this.txtAmplitude.TabIndex = 2;
            this.txtAmplitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAmplitude.Validating += new System.ComponentModel.CancelEventHandler(this.ValidatingDouble);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(67, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 41);
            this.label2.TabIndex = 5;
            this.label2.Text = "Частота:";
            // 
            // txtFrequency
            // 
            this.txtFrequency.BackColor = System.Drawing.Color.White;
            this.txtFrequency.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrequency.ForeColor = System.Drawing.Color.Black;
            this.txtFrequency.Location = new System.Drawing.Point(372, 127);
            this.txtFrequency.Name = "txtFrequency";
            this.txtFrequency.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFrequency.Size = new System.Drawing.Size(269, 43);
            this.txtFrequency.TabIndex = 4;
            this.txtFrequency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFrequency.Validating += new System.ComponentModel.CancelEventHandler(this.ValidatingDouble);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(67, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 41);
            this.label3.TabIndex = 7;
            this.label3.Text = "Толщина ОК:";
            // 
            // txtThickness
            // 
            this.txtThickness.BackColor = System.Drawing.Color.White;
            this.txtThickness.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThickness.ForeColor = System.Drawing.Color.Black;
            this.txtThickness.Location = new System.Drawing.Point(372, 176);
            this.txtThickness.Name = "txtThickness";
            this.txtThickness.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtThickness.Size = new System.Drawing.Size(269, 43);
            this.txtThickness.TabIndex = 6;
            this.txtThickness.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtThickness.Validating += new System.ComponentModel.CancelEventHandler(this.ValidatingDouble);
            // 
            // cmbMaterialTO
            // 
            this.cmbMaterialTO.BackColor = System.Drawing.Color.White;
            this.cmbMaterialTO.Font = new System.Drawing.Font("Nirmala UI", 16.2F);
            this.cmbMaterialTO.ForeColor = System.Drawing.Color.Black;
            this.cmbMaterialTO.FormattingEnabled = true;
            this.cmbMaterialTO.Items.AddRange(new object[] {
            "Aluminum",
            "Iron",
            "Magnesium",
            "Copper",
            "Iron",
            "CastIron",
            "ЦТС-19"});
            this.cmbMaterialTO.Location = new System.Drawing.Point(372, 254);
            this.cmbMaterialTO.Name = "cmbMaterialTO";
            this.cmbMaterialTO.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbMaterialTO.Size = new System.Drawing.Size(269, 45);
            this.cmbMaterialTO.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(67, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 41);
            this.label4.TabIndex = 9;
            this.label4.Text = "Материал ОК:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(67, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 41);
            this.label5.TabIndex = 11;
            this.label5.Text = "Материал ПЕП:";
            // 
            // cmbMaterialPEC
            // 
            this.cmbMaterialPEC.BackColor = System.Drawing.Color.White;
            this.cmbMaterialPEC.Font = new System.Drawing.Font("Nirmala UI", 16.2F);
            this.cmbMaterialPEC.ForeColor = System.Drawing.Color.Black;
            this.cmbMaterialPEC.FormattingEnabled = true;
            this.cmbMaterialPEC.Items.AddRange(new object[] {
            "Aluminum",
            "Iron",
            "Magnesium",
            "Copper",
            "Iron",
            "CastIron",
            "ЦТС-19"});
            this.cmbMaterialPEC.Location = new System.Drawing.Point(372, 305);
            this.cmbMaterialPEC.Name = "cmbMaterialPEC";
            this.cmbMaterialPEC.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbMaterialPEC.Size = new System.Drawing.Size(269, 45);
            this.cmbMaterialPEC.TabIndex = 10;
            // 
            // btnPush
            // 
            this.btnPush.Location = new System.Drawing.Point(96, 406);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(150, 33);
            this.btnPush.TabIndex = 12;
            this.btnPush.Text = "Push";
            this.btnPush.UseVisualStyleBackColor = true;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // bAddMaterial
            // 
            this.bAddMaterial.Location = new System.Drawing.Point(392, 395);
            this.bAddMaterial.Name = "bAddMaterial";
            this.bAddMaterial.Size = new System.Drawing.Size(177, 44);
            this.bAddMaterial.TabIndex = 13;
            this.bAddMaterial.Text = "AddMaterial";
            this.bAddMaterial.UseVisualStyleBackColor = true;
            this.bAddMaterial.Click += new System.EventHandler(this.bAddMaterial_Click);
            // 
            // FormParams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(690, 451);
            this.Controls.Add(this.bAddMaterial);
            this.Controls.Add(this.btnPush);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbMaterialPEC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbMaterialTO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtThickness);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFrequency);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAmplitude);
            this.Controls.Add(this.lbRadius);
            this.Controls.Add(this.txtRadius);
            this.Name = "FormParams";
            this.Text = "FormParams";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Label lbRadius;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAmplitude;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFrequency;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtThickness;
        private System.Windows.Forms.ComboBox cmbMaterialTO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbMaterialPEC;
        private System.Windows.Forms.Button btnPush;
        internal System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button bAddMaterial;
    }
}