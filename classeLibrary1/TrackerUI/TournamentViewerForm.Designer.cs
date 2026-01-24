
namespace TrackerUI
{
    partial class TournamentViewerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            headerLabel = new Label();
            TournamentName = new Label();
            roundLabel = new Label();
            roundDropDown = new ComboBox();
            UnplayedOnlyCheckBox = new CheckBox();
            matchupListBox = new ListBox();
            teamOneName = new Label();
            teamOneScoreLabel = new Label();
            TeamOneScoreValue = new TextBox();
            TeamTwoScoreText = new TextBox();
            TeamTwoScoreLabel = new Label();
            teamTwoName = new Label();
            versusLabel = new Label();
            scoreButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Arial Narrow", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headerLabel.ForeColor = Color.DeepSkyBlue;
            headerLabel.Location = new Point(-5, 19);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(288, 62);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Tournament:";
            // 
            // TournamentName
            // 
            TournamentName.AutoSize = true;
            TournamentName.Font = new Font("Segoe UI Semibold", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TournamentName.ForeColor = Color.DeepSkyBlue;
            TournamentName.Location = new Point(289, 9);
            TournamentName.Name = "TournamentName";
            TournamentName.Size = new Size(239, 74);
            TournamentName.TabIndex = 1;
            TournamentName.Text = "<none>";
            // 
            // roundLabel
            // 
            roundLabel.AutoSize = true;
            roundLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundLabel.ForeColor = Color.DeepSkyBlue;
            roundLabel.Location = new Point(41, 140);
            roundLabel.Name = "roundLabel";
            roundLabel.Size = new Size(139, 54);
            roundLabel.TabIndex = 2;
            roundLabel.Text = "Round";
            // 
            // roundDropDown
            // 
            roundDropDown.FormattingEnabled = true;
            roundDropDown.Location = new Point(186, 140);
            roundDropDown.Name = "roundDropDown";
            roundDropDown.Size = new Size(338, 40);
            roundDropDown.TabIndex = 3;
            roundDropDown.SelectedIndexChanged += this.roundDropDown_SelectedIndexChanged;
            // 
            // UnplayedOnlyCheckBox
            // 
            UnplayedOnlyCheckBox.AutoSize = true;
            UnplayedOnlyCheckBox.FlatStyle = FlatStyle.Flat;
            UnplayedOnlyCheckBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UnplayedOnlyCheckBox.ForeColor = Color.DeepSkyBlue;
            UnplayedOnlyCheckBox.Location = new Point(219, 198);
            UnplayedOnlyCheckBox.Name = "UnplayedOnlyCheckBox";
            UnplayedOnlyCheckBox.Size = new Size(305, 58);
            UnplayedOnlyCheckBox.TabIndex = 4;
            UnplayedOnlyCheckBox.Text = "Unplayed Only";
            UnplayedOnlyCheckBox.UseVisualStyleBackColor = true;
            UnplayedOnlyCheckBox.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // matchupListBox
            // 
            matchupListBox.BorderStyle = BorderStyle.FixedSingle;
            matchupListBox.FormattingEnabled = true;
            matchupListBox.ItemHeight = 32;
            matchupListBox.Location = new Point(68, 262);
            matchupListBox.Name = "matchupListBox";
            matchupListBox.Size = new Size(456, 258);
            matchupListBox.TabIndex = 5;
            matchupListBox.SelectedIndexChanged += this.matchupListBox_SelectedIndexChanged;
            // 
            // teamOneName
            // 
            teamOneName.AutoSize = true;
            teamOneName.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            teamOneName.ForeColor = Color.DeepSkyBlue;
            teamOneName.Location = new Point(576, 262);
            teamOneName.Name = "teamOneName";
            teamOneName.Size = new Size(199, 45);
            teamOneName.TabIndex = 6;
            teamOneName.Text = "<team one>";
            // 
            // teamOneScoreLabel
            // 
            teamOneScoreLabel.AutoSize = true;
            teamOneScoreLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            teamOneScoreLabel.ForeColor = Color.DeepSkyBlue;
            teamOneScoreLabel.Location = new Point(576, 316);
            teamOneScoreLabel.Name = "teamOneScoreLabel";
            teamOneScoreLabel.Size = new Size(143, 45);
            teamOneScoreLabel.TabIndex = 7;
            teamOneScoreLabel.Text = "<Score>";
            // 
            // TeamOneScoreValue
            // 
            TeamOneScoreValue.Location = new Point(714, 316);
            TeamOneScoreValue.Name = "TeamOneScoreValue";
            TeamOneScoreValue.Size = new Size(150, 39);
            TeamOneScoreValue.TabIndex = 8;
            // 
            // TeamTwoScoreText
            // 
            TeamTwoScoreText.Location = new Point(749, 473);
            TeamTwoScoreText.Name = "TeamTwoScoreText";
            TeamTwoScoreText.Size = new Size(150, 39);
            TeamTwoScoreText.TabIndex = 11;
            // 
            // TeamTwoScoreLabel
            // 
            TeamTwoScoreLabel.AutoSize = true;
            TeamTwoScoreLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TeamTwoScoreLabel.ForeColor = Color.DeepSkyBlue;
            TeamTwoScoreLabel.Location = new Point(590, 467);
            TeamTwoScoreLabel.Name = "TeamTwoScoreLabel";
            TeamTwoScoreLabel.Size = new Size(143, 45);
            TeamTwoScoreLabel.TabIndex = 10;
            TeamTwoScoreLabel.Text = "<Score>";
            // 
            // teamTwoName
            // 
            teamTwoName.AutoSize = true;
            teamTwoName.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            teamTwoName.ForeColor = Color.DeepSkyBlue;
            teamTwoName.Location = new Point(590, 413);
            teamTwoName.Name = "teamTwoName";
            teamTwoName.Size = new Size(198, 45);
            teamTwoName.TabIndex = 9;
            teamTwoName.Text = "<team two>";
            // 
            // versusLabel
            // 
            versusLabel.AutoSize = true;
            versusLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            versusLabel.ForeColor = Color.DeepSkyBlue;
            versusLabel.Location = new Point(692, 368);
            versusLabel.Name = "versusLabel";
            versusLabel.Size = new Size(83, 45);
            versusLabel.TabIndex = 12;
            versusLabel.Text = "-VS-";
            // 
            // scoreButton
            // 
            scoreButton.FlatAppearance.BorderColor = Color.Silver;
            scoreButton.FlatAppearance.MouseDownBackColor = Color.Silver;
            scoreButton.FlatAppearance.MouseOverBackColor = Color.White;
            scoreButton.FlatStyle = FlatStyle.Flat;
            scoreButton.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scoreButton.ForeColor = Color.DeepSkyBlue;
            scoreButton.Location = new Point(848, 379);
            scoreButton.Name = "scoreButton";
            scoreButton.Size = new Size(130, 54);
            scoreButton.TabIndex = 13;
            scoreButton.Text = "Score";
            scoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1040, 576);
            Controls.Add(scoreButton);
            Controls.Add(versusLabel);
            Controls.Add(TeamTwoScoreText);
            Controls.Add(TeamTwoScoreLabel);
            Controls.Add(teamTwoName);
            Controls.Add(TeamOneScoreValue);
            Controls.Add(teamOneScoreLabel);
            Controls.Add(teamOneName);
            Controls.Add(matchupListBox);
            Controls.Add(UnplayedOnlyCheckBox);
            Controls.Add(roundDropDown);
            Controls.Add(roundLabel);
            Controls.Add(TournamentName);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "TournamentViewerForm";
            Text = "TournamentViewer";
            Load += TournamentViewerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        private void roundDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            // código quando o round mudar
        }
        private void matchupListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // código quando o usuário selecionar um matchup
        }


        private void TournamentViewerForm_Load(object sender, EventArgs e)
        {
            // código que roda quando o formulário abre
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // código que você quiser quando marcar/desmarcar o checkbox
        }

        #endregion

        private Label headerLabel;
        private Label TournamentName;
        private Label roundLabel;
        private ComboBox roundDropDown;
        private CheckBox UnplayedOnlyCheckBox;
        private ListBox matchupListBox;
        private Label teamOneName;
        private Label teamOneScoreLabel;
        private TextBox TeamOneScoreValue;
        private TextBox TeamTwoScoreText;
        private Label TeamTwoScoreLabel;
        private Label teamTwoName;
        private Label versusLabel;
        private Button scoreButton;
    }
}
