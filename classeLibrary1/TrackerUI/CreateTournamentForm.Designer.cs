namespace TrackerUI
{
    partial class CreateTournamentForm
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
            headerLabel = new Label();
            tournamentNameValue = new TextBox();
            TournamentNameText = new Label();
            entryFeeValue = new TextBox();
            entreFeeLabel = new Label();
            selectTeamDropDown = new ComboBox();
            SelectTeamLabel = new Label();
            createNewTeamLink = new LinkLabel();
            addTeamButton = new Button();
            createPrizeBotton = new Button();
            tournamentTeamsListBox = new ListBox();
            TournamentPlayersLabel = new Label();
            prizesLabel = new Label();
            prizesListBox = new ListBox();
            deleteSelectedPlayersButton = new Button();
            deleteSelecterdPrizeButton = new Button();
            createTournamentBotton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.FlatStyle = FlatStyle.Flat;
            headerLabel.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headerLabel.ForeColor = Color.DeepSkyBlue;
            headerLabel.Location = new Point(12, 9);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(479, 56);
            headerLabel.TabIndex = 2;
            headerLabel.Text = "Create Tournament:";
            // 
            // tournamentNameValue
            // 
            tournamentNameValue.Location = new Point(32, 145);
            tournamentNameValue.Name = "tournamentNameValue";
            tournamentNameValue.Size = new Size(371, 31);
            tournamentNameValue.TabIndex = 14;
            tournamentNameValue.TextChanged += TournamentValue_TextChanged;
            // 
            // TournamentNameText
            // 
            TournamentNameText.AutoSize = true;
            TournamentNameText.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TournamentNameText.ForeColor = Color.DeepSkyBlue;
            TournamentNameText.Location = new Point(32, 97);
            TournamentNameText.Name = "TournamentNameText";
            TournamentNameText.Size = new Size(284, 45);
            TournamentNameText.TabIndex = 13;
            TournamentNameText.Text = "Tournament Name";
            // 
            // entryFeeValue
            // 
            entryFeeValue.Location = new Point(188, 227);
            entryFeeValue.Name = "entryFeeValue";
            entryFeeValue.Size = new Size(150, 31);
            entryFeeValue.TabIndex = 16;
            entryFeeValue.Text = "0";
            entryFeeValue.TextChanged += TeamTwoScoreText_TextChanged;
            // 
            // entreFeeLabel
            // 
            entreFeeLabel.AutoSize = true;
            entreFeeLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            entreFeeLabel.ForeColor = Color.DeepSkyBlue;
            entreFeeLabel.Location = new Point(32, 213);
            entreFeeLabel.Name = "entreFeeLabel";
            entreFeeLabel.Size = new Size(150, 45);
            entreFeeLabel.TabIndex = 15;
            entreFeeLabel.Text = "Entry Fee";
            // 
            // selectTeamDropDown
            // 
            selectTeamDropDown.FormattingEnabled = true;
            selectTeamDropDown.Location = new Point(32, 332);
            selectTeamDropDown.Name = "selectTeamDropDown";
            selectTeamDropDown.Size = new Size(324, 33);
            selectTeamDropDown.TabIndex = 18;
            selectTeamDropDown.SelectedIndexChanged += SelectTeamDropDown_SelectedIndexChanged;
            // 
            // SelectTeamLabel
            // 
            SelectTeamLabel.AutoSize = true;
            SelectTeamLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SelectTeamLabel.ForeColor = Color.DeepSkyBlue;
            SelectTeamLabel.Location = new Point(32, 284);
            SelectTeamLabel.Name = "SelectTeamLabel";
            SelectTeamLabel.Size = new Size(189, 45);
            SelectTeamLabel.TabIndex = 17;
            SelectTeamLabel.Text = "Select Team";
            // 
            // createNewTeamLink
            // 
            createNewTeamLink.AutoSize = true;
            createNewTeamLink.Location = new Point(257, 300);
            createNewTeamLink.Name = "createNewTeamLink";
            createNewTeamLink.Size = new Size(96, 25);
            createNewTeamLink.TabIndex = 19;
            createNewTeamLink.TabStop = true;
            createNewTeamLink.Text = "create new";
            // 
            // addTeamButton
            // 
            addTeamButton.FlatAppearance.BorderColor = Color.Silver;
            addTeamButton.FlatAppearance.MouseDownBackColor = Color.Silver;
            addTeamButton.FlatAppearance.MouseOverBackColor = Color.White;
            addTeamButton.FlatStyle = FlatStyle.Flat;
            addTeamButton.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addTeamButton.ForeColor = Color.DeepSkyBlue;
            addTeamButton.Location = new Point(96, 381);
            addTeamButton.Name = "addTeamButton";
            addTeamButton.Size = new Size(170, 54);
            addTeamButton.TabIndex = 20;
            addTeamButton.Text = "Add Team";
            addTeamButton.UseVisualStyleBackColor = true;
            addTeamButton.Click += AddTeamButton_Click;
            // 
            // createPrizeBotton
            // 
            createPrizeBotton.FlatAppearance.BorderColor = Color.Silver;
            createPrizeBotton.FlatAppearance.MouseDownBackColor = Color.Silver;
            createPrizeBotton.FlatAppearance.MouseOverBackColor = Color.White;
            createPrizeBotton.FlatStyle = FlatStyle.Flat;
            createPrizeBotton.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createPrizeBotton.ForeColor = Color.DeepSkyBlue;
            createPrizeBotton.Location = new Point(85, 447);
            createPrizeBotton.Name = "createPrizeBotton";
            createPrizeBotton.Size = new Size(200, 50);
            createPrizeBotton.TabIndex = 21;
            createPrizeBotton.Text = "Create Prize";
            createPrizeBotton.UseVisualStyleBackColor = true;
            createPrizeBotton.Click += CreatePrizeBotton_Click;
            // 
            // tournamentTeamsListBox
            // 
            tournamentTeamsListBox.BorderStyle = BorderStyle.FixedSingle;
            tournamentTeamsListBox.FormattingEnabled = true;
            tournamentTeamsListBox.ItemHeight = 25;
            tournamentTeamsListBox.Location = new Point(430, 135);
            tournamentTeamsListBox.Name = "tournamentTeamsListBox";
            tournamentTeamsListBox.Size = new Size(318, 152);
            tournamentTeamsListBox.TabIndex = 22;
            tournamentTeamsListBox.SelectedIndexChanged += TournamentPlayersListBox_SelectedIndexChanged;
            // 
            // TournamentPlayersLabel
            // 
            TournamentPlayersLabel.AutoSize = true;
            TournamentPlayersLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TournamentPlayersLabel.ForeColor = Color.DeepSkyBlue;
            TournamentPlayersLabel.Location = new Point(443, 83);
            TournamentPlayersLabel.Name = "TournamentPlayersLabel";
            TournamentPlayersLabel.Size = new Size(238, 45);
            TournamentPlayersLabel.TabIndex = 23;
            TournamentPlayersLabel.Text = "Teams / Players";
            // 
            // prizesLabel
            // 
            prizesLabel.AutoSize = true;
            prizesLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prizesLabel.ForeColor = Color.DeepSkyBlue;
            prizesLabel.Location = new Point(443, 300);
            prizesLabel.Name = "prizesLabel";
            prizesLabel.Size = new Size(238, 45);
            prizesLabel.TabIndex = 25;
            prizesLabel.Text = "Teams / Players";
            // 
            // prizesListBox
            // 
            prizesListBox.BorderStyle = BorderStyle.FixedSingle;
            prizesListBox.FormattingEnabled = true;
            prizesListBox.ItemHeight = 25;
            prizesListBox.Location = new Point(430, 366);
            prizesListBox.Name = "prizesListBox";
            prizesListBox.Size = new Size(318, 127);
            prizesListBox.TabIndex = 24;
            prizesListBox.SelectedIndexChanged += prizeslistBox1_SelectedIndexChanged;
            // 
            // deleteSelectedPlayersButton
            // 
            deleteSelectedPlayersButton.FlatAppearance.BorderColor = Color.Silver;
            deleteSelectedPlayersButton.FlatAppearance.MouseDownBackColor = Color.Silver;
            deleteSelectedPlayersButton.FlatAppearance.MouseOverBackColor = Color.White;
            deleteSelectedPlayersButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedPlayersButton.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteSelectedPlayersButton.ForeColor = Color.DeepSkyBlue;
            deleteSelectedPlayersButton.Location = new Point(777, 176);
            deleteSelectedPlayersButton.Name = "deleteSelectedPlayersButton";
            deleteSelectedPlayersButton.Size = new Size(135, 90);
            deleteSelectedPlayersButton.TabIndex = 26;
            deleteSelectedPlayersButton.Text = "Delete Selcted";
            deleteSelectedPlayersButton.UseVisualStyleBackColor = true;
            deleteSelectedPlayersButton.Click += deleteSelectedPlayersButton_Click;
            // 
            // deleteSelecterdPrizeButton
            // 
            deleteSelecterdPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            deleteSelecterdPrizeButton.FlatAppearance.MouseDownBackColor = Color.Silver;
            deleteSelecterdPrizeButton.FlatAppearance.MouseOverBackColor = Color.White;
            deleteSelecterdPrizeButton.FlatStyle = FlatStyle.Flat;
            deleteSelecterdPrizeButton.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteSelecterdPrizeButton.ForeColor = Color.DeepSkyBlue;
            deleteSelecterdPrizeButton.Location = new Point(777, 392);
            deleteSelecterdPrizeButton.Name = "deleteSelecterdPrizeButton";
            deleteSelecterdPrizeButton.Size = new Size(140, 90);
            deleteSelecterdPrizeButton.TabIndex = 27;
            deleteSelecterdPrizeButton.Text = "Delete Selected";
            deleteSelecterdPrizeButton.UseVisualStyleBackColor = true;
            deleteSelecterdPrizeButton.Click += deleteSelecterdPrizeButton_Click;
            // 
            // createTournamentBotton
            // 
            createTournamentBotton.FlatAppearance.BorderColor = Color.Silver;
            createTournamentBotton.FlatAppearance.MouseDownBackColor = Color.Silver;
            createTournamentBotton.FlatAppearance.MouseOverBackColor = Color.White;
            createTournamentBotton.FlatStyle = FlatStyle.Flat;
            createTournamentBotton.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createTournamentBotton.ForeColor = Color.DeepSkyBlue;
            createTournamentBotton.Location = new Point(275, 512);
            createTournamentBotton.Name = "createTournamentBotton";
            createTournamentBotton.Size = new Size(281, 50);
            createTournamentBotton.TabIndex = 28;
            createTournamentBotton.Text = "Create Tournament";
            createTournamentBotton.UseVisualStyleBackColor = true;
            createTournamentBotton.Click += CreateTournamentBotton_Click;
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(935, 574);
            Controls.Add(createTournamentBotton);
            Controls.Add(deleteSelecterdPrizeButton);
            Controls.Add(deleteSelectedPlayersButton);
            Controls.Add(prizesLabel);
            Controls.Add(prizesListBox);
            Controls.Add(TournamentPlayersLabel);
            Controls.Add(tournamentTeamsListBox);
            Controls.Add(createPrizeBotton);
            Controls.Add(addTeamButton);
            Controls.Add(createNewTeamLink);
            Controls.Add(selectTeamDropDown);
            Controls.Add(SelectTeamLabel);
            Controls.Add(entryFeeValue);
            Controls.Add(entreFeeLabel);
            Controls.Add(tournamentNameValue);
            Controls.Add(TournamentNameText);
            Controls.Add(headerLabel);
            Name = "CreateTournamentForm";
            Text = "Create Tournament";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private TextBox tournamentNameValue;
        private Label TournamentNameText;
        private TextBox entryFeeValue;
        private Label entreFeeLabel;
        private ComboBox selectTeamDropDown;
        private Label SelectTeamLabel;
        private LinkLabel createNewTeamLink;
        private Button addTeamButton;
        private Button createPrizeBotton;
        private ListBox tournamentTeamsListBox;
        private Label TournamentPlayersLabel;
        private Label prizesLabel;
        private ListBox prizesListBox;
        private Button deleteSelectedPlayersButton;
        private Button deleteSelecterdPrizeButton;
        private Button createTournamentBotton;
    }
}