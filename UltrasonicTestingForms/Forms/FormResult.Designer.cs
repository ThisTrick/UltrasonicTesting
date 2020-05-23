namespace UltrasonicTestingForms
{
    partial class FormResult
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnStart = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ChartPanel = new System.Windows.Forms.Panel();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ModelPanel = new System.Windows.Forms.Panel();
            this.TestObjeckPanel = new System.Windows.Forms.Panel();
            this.pictureWave = new System.Windows.Forms.PictureBox();
            this.PECPanel = new System.Windows.Forms.Panel();
            this.picturePEC = new System.Windows.Forms.PictureBox();
            this.timerAction = new System.Windows.Forms.Timer(this.components);
            this.MainPanel.SuspendLayout();
            this.ChartPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.ModelPanel.SuspendLayout();
            this.TestObjeckPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWave)).BeginInit();
            this.PECPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePEC)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Sienna;
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Nirmala UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(0, 530);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(1149, 87);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.ChartPanel);
            this.MainPanel.Controls.Add(this.ModelPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1149, 530);
            this.MainPanel.TabIndex = 1;
            // 
            // ChartPanel
            // 
            this.ChartPanel.Controls.Add(this.Chart);
            this.ChartPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChartPanel.Location = new System.Drawing.Point(516, 0);
            this.ChartPanel.Name = "ChartPanel";
            this.ChartPanel.Size = new System.Drawing.Size(633, 530);
            this.ChartPanel.TabIndex = 1;
            // 
            // Chart
            // 
            chartArea3.Name = "ChartArea1";
            this.Chart.ChartAreas.Add(chartArea3);
            this.Chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.Chart.Legends.Add(legend3);
            this.Chart.Location = new System.Drawing.Point(0, 0);
            this.Chart.Name = "Chart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.Chart.Series.Add(series3);
            this.Chart.Size = new System.Drawing.Size(633, 530);
            this.Chart.TabIndex = 0;
            // 
            // ModelPanel
            // 
            this.ModelPanel.Controls.Add(this.TestObjeckPanel);
            this.ModelPanel.Controls.Add(this.PECPanel);
            this.ModelPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ModelPanel.Location = new System.Drawing.Point(0, 0);
            this.ModelPanel.Name = "ModelPanel";
            this.ModelPanel.Size = new System.Drawing.Size(516, 530);
            this.ModelPanel.TabIndex = 0;
            // 
            // TestObjeckPanel
            // 
            this.TestObjeckPanel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.TestObjeckPanel.Controls.Add(this.pictureWave);
            this.TestObjeckPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TestObjeckPanel.Location = new System.Drawing.Point(0, 172);
            this.TestObjeckPanel.Name = "TestObjeckPanel";
            this.TestObjeckPanel.Size = new System.Drawing.Size(516, 358);
            this.TestObjeckPanel.TabIndex = 1;
            // 
            // pictureWave
            // 
            this.pictureWave.Location = new System.Drawing.Point(169, 6);
            this.pictureWave.Name = "pictureWave";
            this.pictureWave.Size = new System.Drawing.Size(173, 35);
            this.pictureWave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureWave.TabIndex = 0;
            this.pictureWave.TabStop = false;
            // 
            // PECPanel
            // 
            this.PECPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.PECPanel.Controls.Add(this.picturePEC);
            this.PECPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.PECPanel.Location = new System.Drawing.Point(0, 0);
            this.PECPanel.Name = "PECPanel";
            this.PECPanel.Size = new System.Drawing.Size(516, 172);
            this.PECPanel.TabIndex = 0;
            // 
            // picturePEC
            // 
            this.picturePEC.Image = global::UltrasonicTestingForms.Properties.Resources.PEC;
            this.picturePEC.Location = new System.Drawing.Point(186, 44);
            this.picturePEC.Name = "picturePEC";
            this.picturePEC.Size = new System.Drawing.Size(137, 128);
            this.picturePEC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePEC.TabIndex = 0;
            this.picturePEC.TabStop = false;
            // 
            // timerAction
            // 
            this.timerAction.Tick += new System.EventHandler(this.timerAction_Tick);
            // 
            // FormResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1149, 617);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.btnStart);
            this.Name = "FormResult";
            this.Text = "FormResult";
            this.MainPanel.ResumeLayout(false);
            this.ChartPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            this.ModelPanel.ResumeLayout(false);
            this.TestObjeckPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureWave)).EndInit();
            this.PECPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturePEC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel ChartPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private System.Windows.Forms.Panel ModelPanel;
        private System.Windows.Forms.Panel TestObjeckPanel;
        private System.Windows.Forms.Panel PECPanel;
        private System.Windows.Forms.PictureBox picturePEC;
        private System.Windows.Forms.Timer timerAction;
        private System.Windows.Forms.PictureBox pictureWave;
    }
}