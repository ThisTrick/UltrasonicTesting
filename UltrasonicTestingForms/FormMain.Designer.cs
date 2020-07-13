namespace UltrasonicTestingForms
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnParams = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MenuTitle = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.DesktopPanel = new System.Windows.Forms.Panel();
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.TitlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnInfo);
            this.panelMenu.Controls.Add(this.btnResult);
            this.panelMenu.Controls.Add(this.btnParams);
            this.panelMenu.Controls.Add(this.panel1);
            resources.ApplyResources(this.panelMenu, "panelMenu");
            this.panelMenu.Name = "panelMenu";
            // 
            // btnInfo
            // 
            resources.ApplyResources(this.btnInfo, "btnInfo");
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnInfo.Image = global::UltrasonicTestingForms.Properties.Resources.icon_info_white;
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnResult
            // 
            resources.ApplyResources(this.btnResult, "btnResult");
            this.btnResult.FlatAppearance.BorderSize = 0;
            this.btnResult.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnResult.Image = global::UltrasonicTestingForms.Properties.Resources.icon_calc_white;
            this.btnResult.Name = "btnResult";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnParams
            // 
            resources.ApplyResources(this.btnParams, "btnParams");
            this.btnParams.FlatAppearance.BorderSize = 0;
            this.btnParams.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnParams.Image = global::UltrasonicTestingForms.Properties.Resources.icon_property_white;
            this.btnParams.Name = "btnParams";
            this.btnParams.UseVisualStyleBackColor = true;
            this.btnParams.Click += new System.EventHandler(this.btnParams_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.MenuTitle);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // MenuTitle
            // 
            resources.ApplyResources(this.MenuTitle, "MenuTitle");
            this.MenuTitle.ForeColor = System.Drawing.Color.White;
            this.MenuTitle.Name = "MenuTitle";
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.DesktopPanel);
            this.MainPanel.Controls.Add(this.TitlePanel);
            resources.ApplyResources(this.MainPanel, "MainPanel");
            this.MainPanel.Name = "MainPanel";
            // 
            // DesktopPanel
            // 
            resources.ApplyResources(this.DesktopPanel, "DesktopPanel");
            this.DesktopPanel.Name = "DesktopPanel";
            // 
            // TitlePanel
            // 
            this.TitlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.TitlePanel.Controls.Add(this.TitleLabel);
            resources.ApplyResources(this.TitlePanel, "TitlePanel");
            this.TitlePanel.Name = "TitlePanel";
            // 
            // TitleLabel
            // 
            resources.ApplyResources(this.TitleLabel, "TitleLabel");
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Name = "TitleLabel";
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormMain";
            this.TransparencyKey = System.Drawing.Color.DarkOrange;
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label MenuTitle;
        private System.Windows.Forms.Button btnParams;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel DesktopPanel;
        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.Label TitleLabel;
    }
}

