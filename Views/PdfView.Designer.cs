namespace SportCv.Views
{
    partial class PdfView
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
            this.ClubNameTextBox = new System.Windows.Forms.TextBox();
            this.ClubNameLabel = new System.Windows.Forms.Label();
            this.ExportButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClubNameTextBox
            // 
            this.ClubNameTextBox.Location = new System.Drawing.Point(304, 149);
            this.ClubNameTextBox.Name = "ClubNameTextBox";
            this.ClubNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClubNameTextBox.TabIndex = 0;
            // 
            // ClubNameLabel
            // 
            this.ClubNameLabel.AutoSize = true;
            this.ClubNameLabel.Location = new System.Drawing.Point(314, 110);
            this.ClubNameLabel.Name = "ClubNameLabel";
            this.ClubNameLabel.Size = new System.Drawing.Size(80, 13);
            this.ClubNameLabel.TabIndex = 1;
            this.ClubNameLabel.Text = "Nome do Clube";
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(304, 227);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(75, 23);
            this.ExportButton.TabIndex = 2;
            this.ExportButton.Text = "Exportar";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // PdfView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.ClubNameLabel);
            this.Controls.Add(this.ClubNameTextBox);
            this.Name = "PdfView";
            this.Text = "PdfView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ClubNameTextBox;
        private System.Windows.Forms.Label ClubNameLabel;
        private System.Windows.Forms.Button ExportButton;
    }
}