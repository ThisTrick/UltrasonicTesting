namespace UltrasonicTestingForms.Forms
{
    partial class FormAddMaterial
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
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSpeedOfSound = new System.Windows.Forms.TextBox();
            this.lSpeedOfSound = new System.Windows.Forms.Label();
            this.txtDensity = new System.Windows.Forms.TextBox();
            this.lDensity = new System.Windows.Forms.Label();
            this.txtFSPL = new System.Windows.Forms.TextBox();
            this.lFSPL = new System.Windows.Forms.Label();
            this.bPush = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lName.ForeColor = System.Drawing.Color.White;
            this.lName.Location = new System.Drawing.Point(165, 75);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(101, 41);
            this.lName.TabIndex = 0;
            this.lName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(366, 72);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(224, 47);
            this.txtName.TabIndex = 1;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSpeedOfSound
            // 
            this.txtSpeedOfSound.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpeedOfSound.Location = new System.Drawing.Point(366, 139);
            this.txtSpeedOfSound.Name = "txtSpeedOfSound";
            this.txtSpeedOfSound.Size = new System.Drawing.Size(224, 47);
            this.txtSpeedOfSound.TabIndex = 3;
            this.txtSpeedOfSound.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSpeedOfSound.Validating += new System.ComponentModel.CancelEventHandler(this.ValidatingDouble);
            // 
            // lSpeedOfSound
            // 
            this.lSpeedOfSound.AutoSize = true;
            this.lSpeedOfSound.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSpeedOfSound.ForeColor = System.Drawing.Color.White;
            this.lSpeedOfSound.Location = new System.Drawing.Point(92, 142);
            this.lSpeedOfSound.Name = "lSpeedOfSound";
            this.lSpeedOfSound.Size = new System.Drawing.Size(246, 41);
            this.lSpeedOfSound.TabIndex = 2;
            this.lSpeedOfSound.Text = "Speed Of Sound";
            // 
            // txtDensity
            // 
            this.txtDensity.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDensity.Location = new System.Drawing.Point(366, 213);
            this.txtDensity.Name = "txtDensity";
            this.txtDensity.Size = new System.Drawing.Size(224, 47);
            this.txtDensity.TabIndex = 5;
            this.txtDensity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDensity.Validating += new System.ComponentModel.CancelEventHandler(this.ValidatingDouble);
            // 
            // lDensity
            // 
            this.lDensity.AutoSize = true;
            this.lDensity.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDensity.ForeColor = System.Drawing.Color.White;
            this.lDensity.Location = new System.Drawing.Point(153, 216);
            this.lDensity.Name = "lDensity";
            this.lDensity.Size = new System.Drawing.Size(124, 41);
            this.lDensity.TabIndex = 4;
            this.lDensity.Text = "Density";
            // 
            // txtFSPL
            // 
            this.txtFSPL.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFSPL.Location = new System.Drawing.Point(366, 281);
            this.txtFSPL.Name = "txtFSPL";
            this.txtFSPL.Size = new System.Drawing.Size(224, 47);
            this.txtFSPL.TabIndex = 7;
            this.txtFSPL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFSPL.Validating += new System.ComponentModel.CancelEventHandler(this.ValidatingDouble);
            // 
            // lFSPL
            // 
            this.lFSPL.AutoSize = true;
            this.lFSPL.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFSPL.ForeColor = System.Drawing.Color.White;
            this.lFSPL.Location = new System.Drawing.Point(173, 284);
            this.lFSPL.Name = "lFSPL";
            this.lFSPL.Size = new System.Drawing.Size(84, 41);
            this.lFSPL.TabIndex = 6;
            this.lFSPL.Text = "FSPL";
            // 
            // bPush
            // 
            this.bPush.BackColor = System.Drawing.Color.SaddleBrown;
            this.bPush.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bPush.FlatAppearance.BorderSize = 0;
            this.bPush.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPush.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPush.ForeColor = System.Drawing.Color.White;
            this.bPush.Location = new System.Drawing.Point(0, 409);
            this.bPush.Name = "bPush";
            this.bPush.Size = new System.Drawing.Size(746, 66);
            this.bPush.TabIndex = 8;
            this.bPush.Text = "Add Material";
            this.bPush.UseVisualStyleBackColor = false;
            this.bPush.Click += new System.EventHandler(this.bPush_Click);
            // 
            // FormAddMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(746, 475);
            this.Controls.Add(this.bPush);
            this.Controls.Add(this.txtFSPL);
            this.Controls.Add(this.lFSPL);
            this.Controls.Add(this.txtDensity);
            this.Controls.Add(this.lDensity);
            this.Controls.Add(this.txtSpeedOfSound);
            this.Controls.Add(this.lSpeedOfSound);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lName);
            this.Name = "FormAddMaterial";
            this.Text = "FormAddMaterial";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button bPush;
        private System.Windows.Forms.TextBox txtFSPL;
        private System.Windows.Forms.Label lFSPL;
        private System.Windows.Forms.TextBox txtDensity;
        private System.Windows.Forms.Label lDensity;
        private System.Windows.Forms.TextBox txtSpeedOfSound;
        private System.Windows.Forms.Label lSpeedOfSound;
    }
}