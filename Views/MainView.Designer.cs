namespace SportCv.Views
{
    partial class MainView
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
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.CvListbox = new System.Windows.Forms.ListBox();
            this.NewCvButton = new System.Windows.Forms.Button();
            this.ExportToPdfButton = new System.Windows.Forms.Button();
            this.EditCVButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Location = new System.Drawing.Point(53, 176);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(75, 45);
            this.OpenFileButton.TabIndex = 0;
            this.OpenFileButton.Text = "Abrir Ficheiro";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // CvListbox
            // 
            this.CvListbox.FormattingEnabled = true;
            this.CvListbox.Location = new System.Drawing.Point(134, 176);
            this.CvListbox.Name = "CvListbox";
            this.CvListbox.Size = new System.Drawing.Size(120, 95);
            this.CvListbox.TabIndex = 1;
            // 
            // NewCvButton
            // 
            this.NewCvButton.Location = new System.Drawing.Point(260, 248);
            this.NewCvButton.Name = "NewCvButton";
            this.NewCvButton.Size = new System.Drawing.Size(75, 23);
            this.NewCvButton.TabIndex = 2;
            this.NewCvButton.Text = "Novo CV";
            this.NewCvButton.UseVisualStyleBackColor = true;
            this.NewCvButton.Click += new System.EventHandler(this.NewCvButton_Click);
            // 
            // ExportToPdfButton
            // 
            this.ExportToPdfButton.Location = new System.Drawing.Point(134, 277);
            this.ExportToPdfButton.Name = "ExportToPdfButton";
            this.ExportToPdfButton.Size = new System.Drawing.Size(75, 40);
            this.ExportToPdfButton.TabIndex = 3;
            this.ExportToPdfButton.Text = "Exportar todos";
            this.ExportToPdfButton.UseVisualStyleBackColor = true;
            this.ExportToPdfButton.Click += new System.EventHandler(this.ExportToPdfButton_Click);
            // 
            // EditCVButton
            // 
            this.EditCVButton.Location = new System.Drawing.Point(260, 176);
            this.EditCVButton.Name = "EditCVButton";
            this.EditCVButton.Size = new System.Drawing.Size(75, 23);
            this.EditCVButton.TabIndex = 4;
            this.EditCVButton.Text = "Abrir CV";
            this.EditCVButton.UseVisualStyleBackColor = true;
            this.EditCVButton.Click += new System.EventHandler(this.EditCVButton_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EditCVButton);
            this.Controls.Add(this.ExportToPdfButton);
            this.Controls.Add(this.NewCvButton);
            this.Controls.Add(this.CvListbox);
            this.Controls.Add(this.OpenFileButton);
            this.Name = "MainView";
            this.Text = "MainView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.ListBox CvListbox;
        private System.Windows.Forms.Button NewCvButton;
        private System.Windows.Forms.Button ExportToPdfButton;
        private System.Windows.Forms.Button EditCVButton;
    }
}