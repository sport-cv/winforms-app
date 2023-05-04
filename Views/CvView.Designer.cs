namespace SportCv.Views
{
    partial class CvView
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
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.EmailTextbox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveCvButton = new System.Windows.Forms.Button();
            this.AlertLabel = new System.Windows.Forms.Label();
            this.ExportToPdfButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(196, 135);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(100, 20);
            this.NameTextbox.TabIndex = 0;
            // 
            // EmailTextbox
            // 
            this.EmailTextbox.Location = new System.Drawing.Point(196, 171);
            this.EmailTextbox.Name = "EmailTextbox";
            this.EmailTextbox.Size = new System.Drawing.Size(100, 20);
            this.EmailTextbox.TabIndex = 1;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(155, 141);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Nome";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(155, 177);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(32, 13);
            this.EmailLabel.TabIndex = 3;
            this.EmailLabel.Text = "Email";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(675, 413);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancelar";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveCvButton
            // 
            this.SaveCvButton.Location = new System.Drawing.Point(594, 413);
            this.SaveCvButton.Name = "SaveCvButton";
            this.SaveCvButton.Size = new System.Drawing.Size(75, 23);
            this.SaveCvButton.TabIndex = 5;
            this.SaveCvButton.Text = "Gravar CV";
            this.SaveCvButton.UseVisualStyleBackColor = true;
            this.SaveCvButton.Click += new System.EventHandler(this.SaveCvButton_Click);
            // 
            // AlertLabel
            // 
            this.AlertLabel.AutoSize = true;
            this.AlertLabel.Location = new System.Drawing.Point(594, 2);
            this.AlertLabel.Name = "AlertLabel";
            this.AlertLabel.Size = new System.Drawing.Size(0, 13);
            this.AlertLabel.TabIndex = 6;
            // 
            // ExportToPdfButton
            // 
            this.ExportToPdfButton.Location = new System.Drawing.Point(491, 413);
            this.ExportToPdfButton.Name = "ExportToPdfButton";
            this.ExportToPdfButton.Size = new System.Drawing.Size(75, 23);
            this.ExportToPdfButton.TabIndex = 7;
            this.ExportToPdfButton.Text = "Exportar";
            this.ExportToPdfButton.UseVisualStyleBackColor = true;
            this.ExportToPdfButton.Click += new System.EventHandler(this.ExportToPdfButton_Click);
            // 
            // CvView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExportToPdfButton);
            this.Controls.Add(this.AlertLabel);
            this.Controls.Add(this.SaveCvButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.EmailTextbox);
            this.Controls.Add(this.NameTextbox);
            this.Name = "CvView";
            this.Text = "CvView";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClose);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.TextBox EmailTextbox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveCvButton;
        private System.Windows.Forms.Label AlertLabel;
        private System.Windows.Forms.Button ExportToPdfButton;
    }
}