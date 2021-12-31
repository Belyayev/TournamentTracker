
namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentDashboardForm));
            this.loadTournamentButton = new System.Windows.Forms.Button();
            this.loadTournamentDropdown = new System.Windows.Forms.ComboBox();
            this.loadExistingTournamentLabel = new System.Windows.Forms.Label();
            this.tournamentDashboardLabel = new System.Windows.Forms.Label();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loadTournamentButton
            // 
            this.loadTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.loadTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadTournamentButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loadTournamentButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.loadTournamentButton.Location = new System.Drawing.Point(407, 340);
            this.loadTournamentButton.Name = "loadTournamentButton";
            this.loadTournamentButton.Size = new System.Drawing.Size(402, 75);
            this.loadTournamentButton.TabIndex = 32;
            this.loadTournamentButton.Text = "Load Tournament";
            this.loadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // loadTournamentDropdown
            // 
            this.loadTournamentDropdown.FormattingEnabled = true;
            this.loadTournamentDropdown.Location = new System.Drawing.Point(262, 242);
            this.loadTournamentDropdown.Name = "loadTournamentDropdown";
            this.loadTournamentDropdown.Size = new System.Drawing.Size(686, 58);
            this.loadTournamentDropdown.TabIndex = 31;
            // 
            // loadExistingTournamentLabel
            // 
            this.loadExistingTournamentLabel.AutoEllipsis = true;
            this.loadExistingTournamentLabel.AutoSize = true;
            this.loadExistingTournamentLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.loadExistingTournamentLabel.Location = new System.Drawing.Point(407, 177);
            this.loadExistingTournamentLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.loadExistingTournamentLabel.Name = "loadExistingTournamentLabel";
            this.loadExistingTournamentLabel.Size = new System.Drawing.Size(444, 50);
            this.loadExistingTournamentLabel.TabIndex = 30;
            this.loadExistingTournamentLabel.Text = "Load Existing Tournament";
            // 
            // tournamentDashboardLabel
            // 
            this.tournamentDashboardLabel.AutoSize = true;
            this.tournamentDashboardLabel.Font = new System.Drawing.Font("Segoe UI Light", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tournamentDashboardLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.tournamentDashboardLabel.Location = new System.Drawing.Point(262, 54);
            this.tournamentDashboardLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tournamentDashboardLabel.Name = "tournamentDashboardLabel";
            this.tournamentDashboardLabel.Size = new System.Drawing.Size(686, 88);
            this.tournamentDashboardLabel.TabIndex = 29;
            this.tournamentDashboardLabel.Text = "Tournament Dashboard";
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createTournamentButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.createTournamentButton.Location = new System.Drawing.Point(373, 443);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(457, 123);
            this.createTournamentButton.TabIndex = 33;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 50F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1256, 633);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.loadTournamentButton);
            this.Controls.Add(this.loadTournamentDropdown);
            this.Controls.Add(this.loadExistingTournamentLabel);
            this.Controls.Add(this.tournamentDashboardLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "TournamentDashboardForm";
            this.Text = "TournamentDashboardForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadTournamentButton;
        private System.Windows.Forms.ComboBox loadTournamentDropdown;
        private System.Windows.Forms.Label loadExistingTournamentLabel;
        private System.Windows.Forms.Label tournamentDashboardLabel;
        private System.Windows.Forms.Button createTournamentButton;
    }
}