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
            PrizeLabel = new Label();
            loadExistingTournamentDropDown = new ComboBox();
            loadExistingTournamentLabel = new Label();
            createTournamentBotton = new Button();
            loadTournamentBotton = new Button();
            SuspendLayout();
            // 
            // PrizeLabel
            // 
            PrizeLabel.AutoSize = true;
            PrizeLabel.FlatStyle = FlatStyle.Flat;
            PrizeLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PrizeLabel.ForeColor = SystemColors.MenuHighlight;
            PrizeLabel.Location = new Point(154, 67);
            PrizeLabel.Name = "PrizeLabel";
            PrizeLabel.Size = new Size(468, 54);
            PrizeLabel.TabIndex = 19;
            PrizeLabel.Text = "Tournament Dashboard";
            // 
            // loadExistingTournamentDropDown
            // 
            loadExistingTournamentDropDown.FormattingEnabled = true;
            loadExistingTournamentDropDown.Location = new Point(169, 210);
            loadExistingTournamentDropDown.Name = "loadExistingTournamentDropDown";
            loadExistingTournamentDropDown.Size = new Size(453, 33);
            loadExistingTournamentDropDown.TabIndex = 21;
            loadExistingTournamentDropDown.SelectedIndexChanged += loadExistingTournamentDropDown_SelectedIndexChanged;
            // 
            // loadExistingTournamentLabel
            // 
            loadExistingTournamentLabel.AutoSize = true;
            loadExistingTournamentLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loadExistingTournamentLabel.ForeColor = SystemColors.MenuHighlight;
            loadExistingTournamentLabel.Location = new Point(209, 152);
            loadExistingTournamentLabel.Name = "loadExistingTournamentLabel";
            loadExistingTournamentLabel.Size = new Size(334, 38);
            loadExistingTournamentLabel.TabIndex = 20;
            loadExistingTournamentLabel.Text = "Load Existing Tournament";
            // 
            // createTournamentBotton
            // 
            createTournamentBotton.FlatAppearance.BorderColor = Color.Silver;
            createTournamentBotton.FlatAppearance.MouseDownBackColor = Color.Silver;
            createTournamentBotton.FlatAppearance.MouseOverBackColor = Color.White;
            createTournamentBotton.FlatStyle = FlatStyle.Flat;
            createTournamentBotton.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createTournamentBotton.ForeColor = Color.DeepSkyBlue;
            createTournamentBotton.Location = new Point(270, 354);
            createTournamentBotton.Name = "createTournamentBotton";
            createTournamentBotton.Size = new Size(273, 63);
            createTournamentBotton.TabIndex = 30;
            createTournamentBotton.Text = "Create Tournament";
            createTournamentBotton.UseVisualStyleBackColor = true;
            createTournamentBotton.Click += createTournamentBotton_Click;
            // 
            // loadTournamentBotton
            // 
            loadTournamentBotton.FlatAppearance.BorderColor = Color.Silver;
            loadTournamentBotton.FlatAppearance.MouseDownBackColor = Color.Silver;
            loadTournamentBotton.FlatAppearance.MouseOverBackColor = Color.White;
            loadTournamentBotton.FlatStyle = FlatStyle.Flat;
            loadTournamentBotton.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loadTournamentBotton.ForeColor = Color.DeepSkyBlue;
            loadTournamentBotton.Location = new Point(226, 281);
            loadTournamentBotton.Name = "loadTournamentBotton";
            loadTournamentBotton.Size = new Size(346, 46);
            loadTournamentBotton.TabIndex = 31;
            loadTournamentBotton.Text = "Load Tournament";
            loadTournamentBotton.UseVisualStyleBackColor = true;
            loadTournamentBotton.Click += loadTournamentBotton_Click;
            // 
            // TournamentDashboardForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(loadTournamentBotton);
            Controls.Add(createTournamentBotton);
            Controls.Add(loadExistingTournamentDropDown);
            Controls.Add(loadExistingTournamentLabel);
            Controls.Add(PrizeLabel);
            Name = "TournamentDashboardForm";
            Text = "Tournament Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PrizeLabel;
        private ComboBox loadExistingTournamentDropDown;
        private Label loadExistingTournamentLabel;
        private Button createTournamentBotton;
        private Button loadTournamentBotton;
    }
}