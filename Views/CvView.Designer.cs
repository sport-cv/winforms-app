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
            this.ExitButton = new System.Windows.Forms.Button();
            this.SaveCvButton = new System.Windows.Forms.Button();
            this.AlertLabel = new System.Windows.Forms.Label();
            this.ExportToPdfButton = new System.Windows.Forms.Button();
            this.HistoryListView = new System.Windows.Forms.ListView();
            this.Season = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Club = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Role = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.AddHistoryButton = new System.Windows.Forms.Button();
            this.PlayerRadioButton = new System.Windows.Forms.RadioButton();
            this.CoachRadioButton = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(37, 46);
            this.NameTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(363, 22);
            this.NameTextbox.TabIndex = 0;
            // 
            // EmailTextbox
            // 
            this.EmailTextbox.Location = new System.Drawing.Point(37, 105);
            this.EmailTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.EmailTextbox.Name = "EmailTextbox";
            this.EmailTextbox.Size = new System.Drawing.Size(363, 22);
            this.EmailTextbox.TabIndex = 1;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(33, 26);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(47, 16);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Nome:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(33, 85);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(44, 16);
            this.EmailLabel.TabIndex = 3;
            this.EmailLabel.Text = "Email:";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(34, 537);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(366, 48);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Voltar";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveCvButton
            // 
            this.SaveCvButton.Location = new System.Drawing.Point(34, 482);
            this.SaveCvButton.Margin = new System.Windows.Forms.Padding(4);
            this.SaveCvButton.Name = "SaveCvButton";
            this.SaveCvButton.Size = new System.Drawing.Size(366, 48);
            this.SaveCvButton.TabIndex = 5;
            this.SaveCvButton.Text = "Gravar CV";
            this.SaveCvButton.UseVisualStyleBackColor = true;
            this.SaveCvButton.Click += new System.EventHandler(this.SaveCvButton_Click);
            // 
            // AlertLabel
            // 
            this.AlertLabel.AutoSize = true;
            this.AlertLabel.Location = new System.Drawing.Point(792, 2);
            this.AlertLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AlertLabel.Name = "AlertLabel";
            this.AlertLabel.Size = new System.Drawing.Size(0, 16);
            this.AlertLabel.TabIndex = 6;
            // 
            // ExportToPdfButton
            // 
            this.ExportToPdfButton.Location = new System.Drawing.Point(34, 428);
            this.ExportToPdfButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExportToPdfButton.Name = "ExportToPdfButton";
            this.ExportToPdfButton.Size = new System.Drawing.Size(366, 47);
            this.ExportToPdfButton.TabIndex = 7;
            this.ExportToPdfButton.Text = "Exportar";
            this.ExportToPdfButton.UseVisualStyleBackColor = true;
            this.ExportToPdfButton.Click += new System.EventHandler(this.ExportToPdfButton_Click);
            // 
            // HistoryListView
            // 
            this.HistoryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Season,
            this.Club,
            this.Role});
            this.HistoryListView.HideSelection = false;
            this.HistoryListView.Location = new System.Drawing.Point(34, 154);
            this.HistoryListView.Name = "HistoryListView";
            this.HistoryListView.Size = new System.Drawing.Size(366, 210);
            this.HistoryListView.TabIndex = 8;
            this.HistoryListView.UseCompatibleStateImageBehavior = false;
            this.HistoryListView.View = System.Windows.Forms.View.Details;
            this.HistoryListView.SelectedIndexChanged += new System.EventHandler(this.HistoryListView_SelectedIndexChanged);
            // 
            // Season
            // 
            this.Season.Text = "Época";
            this.Season.Width = 88;
            // 
            // Club
            // 
            this.Club.Text = "Clube";
            this.Club.Width = 120;
            // 
            // Role
            // 
            this.Role.Text = "Função";
            this.Role.Width = 92;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Histórico Desportivo";
            // 
            // AddHistoryButton
            // 
            this.AddHistoryButton.Location = new System.Drawing.Point(281, 366);
            this.AddHistoryButton.Name = "AddHistoryButton";
            this.AddHistoryButton.Size = new System.Drawing.Size(119, 30);
            this.AddHistoryButton.TabIndex = 10;
            this.AddHistoryButton.Text = "Adicionar";
            this.AddHistoryButton.UseVisualStyleBackColor = true;
            // 
            // PlayerRadioButton
            // 
            this.PlayerRadioButton.AutoSize = true;
            this.PlayerRadioButton.Location = new System.Drawing.Point(34, 371);
            this.PlayerRadioButton.Name = "PlayerRadioButton";
            this.PlayerRadioButton.Size = new System.Drawing.Size(74, 21);
            this.PlayerRadioButton.TabIndex = 11;
            this.PlayerRadioButton.TabStop = true;
            this.PlayerRadioButton.Text = "Jogador";
            this.PlayerRadioButton.UseCompatibleTextRendering = true;
            this.PlayerRadioButton.UseVisualStyleBackColor = true;
            // 
            // CoachRadioButton
            // 
            this.CoachRadioButton.AutoSize = true;
            this.CoachRadioButton.Location = new System.Drawing.Point(114, 372);
            this.CoachRadioButton.Name = "CoachRadioButton";
            this.CoachRadioButton.Size = new System.Drawing.Size(87, 20);
            this.CoachRadioButton.TabIndex = 12;
            this.CoachRadioButton.TabStop = true;
            this.CoachRadioButton.Text = "Treinador";
            this.CoachRadioButton.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(207, 372);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(68, 20);
            this.radioButton3.TabIndex = 13;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Diretor";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // CvView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 596);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.CoachRadioButton);
            this.Controls.Add(this.PlayerRadioButton);
            this.Controls.Add(this.AddHistoryButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HistoryListView);
            this.Controls.Add(this.ExportToPdfButton);
            this.Controls.Add(this.AlertLabel);
            this.Controls.Add(this.SaveCvButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.EmailTextbox);
            this.Controls.Add(this.NameTextbox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CvView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cv";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.TextBox EmailTextbox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SaveCvButton;
        private System.Windows.Forms.Label AlertLabel;
        private System.Windows.Forms.Button ExportToPdfButton;
        private System.Windows.Forms.ListView HistoryListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader Season;
        private System.Windows.Forms.ColumnHeader Club;
        private System.Windows.Forms.ColumnHeader Role;
        private System.Windows.Forms.Button AddHistoryButton;
        private System.Windows.Forms.RadioButton PlayerRadioButton;
        private System.Windows.Forms.RadioButton CoachRadioButton;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}