namespace SportCv.Views
{
    partial class ExperienceView
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
            this.ClubTextbox = new System.Windows.Forms.TextBox();
            this.SeasonCombobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ClubLabel = new System.Windows.Forms.Label();
            this.RoleLabel = new System.Windows.Forms.Label();
            this.RoleTextbox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SpecificFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // ClubTextbox
            // 
            this.ClubTextbox.Location = new System.Drawing.Point(12, 133);
            this.ClubTextbox.Name = "ClubTextbox";
            this.ClubTextbox.Size = new System.Drawing.Size(204, 22);
            this.ClubTextbox.TabIndex = 0;
            // 
            // SeasonCombobox
            // 
            this.SeasonCombobox.FormattingEnabled = true;
            this.SeasonCombobox.Location = new System.Drawing.Point(12, 78);
            this.SeasonCombobox.Name = "SeasonCombobox";
            this.SeasonCombobox.Size = new System.Drawing.Size(204, 24);
            this.SeasonCombobox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Época";
            // 
            // ClubLabel
            // 
            this.ClubLabel.AutoSize = true;
            this.ClubLabel.Location = new System.Drawing.Point(9, 114);
            this.ClubLabel.Name = "ClubLabel";
            this.ClubLabel.Size = new System.Drawing.Size(42, 16);
            this.ClubLabel.TabIndex = 3;
            this.ClubLabel.Text = "Clube";
            // 
            // RoleLabel
            // 
            this.RoleLabel.AutoSize = true;
            this.RoleLabel.Location = new System.Drawing.Point(12, 9);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(52, 16);
            this.RoleLabel.TabIndex = 4;
            this.RoleLabel.Text = "Função";
            // 
            // RoleTextbox
            // 
            this.RoleTextbox.Enabled = false;
            this.RoleTextbox.Location = new System.Drawing.Point(12, 28);
            this.RoleTextbox.Name = "RoleTextbox";
            this.RoleTextbox.Size = new System.Drawing.Size(204, 22);
            this.RoleTextbox.TabIndex = 5;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(12, 386);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(204, 23);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Guardar";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(12, 415);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(204, 23);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Sair";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SpecificFlowLayout
            // 
            this.SpecificFlowLayout.Location = new System.Drawing.Point(12, 161);
            this.SpecificFlowLayout.Name = "SpecificFlowLayout";
            this.SpecificFlowLayout.Size = new System.Drawing.Size(200, 219);
            this.SpecificFlowLayout.TabIndex = 8;
            // 
            // ExperienceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 450);
            this.Controls.Add(this.SpecificFlowLayout);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.RoleTextbox);
            this.Controls.Add(this.RoleLabel);
            this.Controls.Add(this.ClubLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SeasonCombobox);
            this.Controls.Add(this.ClubTextbox);
            this.Name = "ExperienceView";
            this.Text = "ExperienceView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ClubTextbox;
        private System.Windows.Forms.ComboBox SeasonCombobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ClubLabel;
        private System.Windows.Forms.Label RoleLabel;
        private System.Windows.Forms.TextBox RoleTextbox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.FlowLayoutPanel SpecificFlowLayout;
    }
}