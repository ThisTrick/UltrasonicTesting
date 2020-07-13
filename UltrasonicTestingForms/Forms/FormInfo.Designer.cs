namespace UltrasonicTestingForms.Forms
{
    partial class FormInfo
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
            this.lbReferences = new System.Windows.Forms.Label();
            this.pReferences = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pContacts = new System.Windows.Forms.Panel();
            this.lbContacts = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pReferences.SuspendLayout();
            this.pContacts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbReferences
            // 
            this.lbReferences.AutoSize = true;
            this.lbReferences.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReferences.Location = new System.Drawing.Point(265, 13);
            this.lbReferences.Name = "lbReferences";
            this.lbReferences.Size = new System.Drawing.Size(192, 46);
            this.lbReferences.TabIndex = 1;
            this.lbReferences.Text = "References";
            this.lbReferences.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pReferences
            // 
            this.pReferences.Controls.Add(this.linkLabel1);
            this.pReferences.Controls.Add(this.lbReferences);
            this.pReferences.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pReferences.Location = new System.Drawing.Point(0, 264);
            this.pReferences.Name = "pReferences";
            this.pReferences.Size = new System.Drawing.Size(728, 230);
            this.pReferences.TabIndex = 2;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(12, 68);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(698, 96);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Галаган Р.М. Теоретичні основи ультразвукового неруйнівного контролю: підручник /" +
    " Р. М. Галаган. – Київ: КПІ ім. Ігоря Сікорського, 2019. – 263 с.";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pContacts
            // 
            this.pContacts.Controls.Add(this.pictureBox1);
            this.pContacts.Controls.Add(this.label1);
            this.pContacts.Controls.Add(this.lbContacts);
            this.pContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContacts.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.pContacts.Location = new System.Drawing.Point(0, 0);
            this.pContacts.Name = "pContacts";
            this.pContacts.Size = new System.Drawing.Size(728, 264);
            this.pContacts.TabIndex = 3;
            // 
            // lbContacts
            // 
            this.lbContacts.AutoSize = true;
            this.lbContacts.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContacts.Location = new System.Drawing.Point(279, 9);
            this.lbContacts.Name = "lbContacts";
            this.lbContacts.Size = new System.Drawing.Size(158, 46);
            this.lbContacts.TabIndex = 1;
            this.lbContacts.Text = "Contacts";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "way.trickster@gmail.com";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UltrasonicTestingForms.Properties.Resources.github;
            this.pictureBox1.Location = new System.Drawing.Point(500, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(728, 494);
            this.Controls.Add(this.pContacts);
            this.Controls.Add(this.pReferences);
            this.Name = "FormInfo";
            this.Text = "FormInfo";
            this.pReferences.ResumeLayout(false);
            this.pReferences.PerformLayout();
            this.pContacts.ResumeLayout(false);
            this.pContacts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbReferences;
        private System.Windows.Forms.Panel pReferences;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel pContacts;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbContacts;
    }
}