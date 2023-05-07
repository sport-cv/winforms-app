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
            this.ClubNameTextbox = new System.Windows.Forms.TextBox();
            this.ClubNameLabel = new System.Windows.Forms.Label();
            this.ExportButton = new System.Windows.Forms.Button();
            this.SeasonTextbox = new System.Windows.Forms.TextBox();
            this.SeasonLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClubNameTextbox
            // 
            this.ClubNameTextbox.Location = new System.Drawing.Point(43, 53);
            this.ClubNameTextbox.Name = "ClubNameTextbox";
            this.ClubNameTextbox.Size = new System.Drawing.Size(100, 20);
            this.ClubNameTextbox.TabIndex = 0;
            // 
            // ClubNameLabel
            // 
            this.ClubNameLabel.AutoSize = true;
            this.ClubNameLabel.Location = new System.Drawing.Point(40, 26);
            this.ClubNameLabel.Name = "ClubNameLabel";
            this.ClubNameLabel.Size = new System.Drawing.Size(83, 13);
            this.ClubNameLabel.TabIndex = 1;
            this.ClubNameLabel.Text = "Nome do Clube:";
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(43, 159);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(100, 35);
            this.ExportButton.TabIndex = 2;
            this.ExportButton.Text = "Exportar";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // SeasonTextbox
            // 
            this.SeasonTextbox.Location = new System.Drawing.Point(43, 117);
            this.SeasonTextbox.Name = "SeasonTextbox";
            this.SeasonTextbox.Size = new System.Drawing.Size(100, 20);
            this.SeasonTextbox.TabIndex = 3;
            // 
            // SeasonLabel
            // 
            this.SeasonLabel.AutoSize = true;
            this.SeasonLabel.Location = new System.Drawing.Point(40, 91);
            this.SeasonLabel.Name = "SeasonLabel";
            this.SeasonLabel.Size = new System.Drawing.Size(41, 13);
            this.SeasonLabel.TabIndex = 4;
            this.SeasonLabel.Text = "Época:";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(43, 200);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(100, 34);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Voltar";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // PdfView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 258);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SeasonLabel);
            this.Controls.Add(this.SeasonTextbox);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.ClubNameLabel);
            this.Controls.Add(this.ClubNameTextbox);
            this.Name = "PdfView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar Pdf";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ClubNameTextbox;
        private System.Windows.Forms.Label ClubNameLabel;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.TextBox SeasonTextbox;
        private System.Windows.Forms.Label SeasonLabel;
        private System.Windows.Forms.Button ExitButton;
    }
}