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
            this.SaveFileButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Location = new System.Drawing.Point(55, 37);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(108, 45);
            this.OpenFileButton.TabIndex = 0;
            this.OpenFileButton.Text = "Abrir Ficheiro";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // CvListbox
            // 
            this.CvListbox.FormattingEnabled = true;
            this.CvListbox.Location = new System.Drawing.Point(12, 66);
            this.CvListbox.Name = "CvListbox";
            this.CvListbox.Size = new System.Drawing.Size(141, 173);
            this.CvListbox.TabIndex = 1;
            // 
            // NewCvButton
            // 
            this.NewCvButton.Location = new System.Drawing.Point(12, 296);
            this.NewCvButton.Name = "NewCvButton";
            this.NewCvButton.Size = new System.Drawing.Size(141, 47);
            this.NewCvButton.TabIndex = 2;
            this.NewCvButton.Text = "Novo CV";
            this.NewCvButton.UseVisualStyleBackColor = true;
            this.NewCvButton.Click += new System.EventHandler(this.NewCvButton_Click);
            // 
            // ExportToPdfButton
            // 
            this.ExportToPdfButton.Location = new System.Drawing.Point(12, 391);
            this.ExportToPdfButton.Name = "ExportToPdfButton";
            this.ExportToPdfButton.Size = new System.Drawing.Size(141, 47);
            this.ExportToPdfButton.TabIndex = 3;
            this.ExportToPdfButton.Text = "Exportar PDF (todos)";
            this.ExportToPdfButton.UseVisualStyleBackColor = true;
            this.ExportToPdfButton.Click += new System.EventHandler(this.ExportToPdfButton_Click);
            // 
            // EditCVButton
            // 
            this.EditCVButton.Location = new System.Drawing.Point(12, 245);
            this.EditCVButton.Name = "EditCVButton";
            this.EditCVButton.Size = new System.Drawing.Size(141, 45);
            this.EditCVButton.TabIndex = 4;
            this.EditCVButton.Text = "Abrir CV";
            this.EditCVButton.UseVisualStyleBackColor = true;
            this.EditCVButton.Click += new System.EventHandler(this.EditCVButton_Click);
            // 
            // SaveFileButton
            // 
            this.SaveFileButton.Location = new System.Drawing.Point(55, 88);
            this.SaveFileButton.Name = "SaveFileButton";
            this.SaveFileButton.Size = new System.Drawing.Size(108, 46);
            this.SaveFileButton.TabIndex = 5;
            this.SaveFileButton.Text = "Guardar Ficheiro";
            this.SaveFileButton.UseVisualStyleBackColor = true;
            this.SaveFileButton.Click += new System.EventHandler(this.SaveFileButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lista de Cv\'s";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OpenFileButton);
            this.groupBox1.Controls.Add(this.SaveFileButton);
            this.groupBox1.Location = new System.Drawing.Point(253, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 172);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Json Files";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EditCVButton);
            this.Controls.Add(this.ExportToPdfButton);
            this.Controls.Add(this.NewCvButton);
            this.Controls.Add(this.CvListbox);
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SportCV";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.ListBox CvListbox;
        private System.Windows.Forms.Button NewCvButton;
        private System.Windows.Forms.Button ExportToPdfButton;
        private System.Windows.Forms.Button EditCVButton;
        private System.Windows.Forms.Button SaveFileButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}