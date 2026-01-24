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
            TournamentValue = new TextBox();
            TournamentNameText = new Label();
            entreFeeValue = new TextBox();
            entreFeeLabel = new Label();
            SelectTeamDropDown = new ComboBox();
            SelectTeamLabel = new Label();
            createNewTeamLink = new LinkLabel();
            AddTeamButton = new Button();
            CreatePrizeBotton = new Button();
            TournamentPlayersListBox = new ListBox();
            TournamentPlayersLabel = new Label();
            prizesLabel = new Label();
            prizeslistBox1 = new ListBox();
            deleteSelectedPlayersButton = new Button();
            deleteSelecterdPrizeButton = new Button();
            CreateTournamentBotton = new Button();
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
            // TournamentValue
            // 
            TournamentValue.Location = new Point(32, 145);
            TournamentValue.Name = "TournamentValue";
            TournamentValue.Size = new Size(371, 31);
            TournamentValue.TabIndex = 14;
            TournamentValue.TextChanged += TournamentValue_TextChanged;
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
            // entreFeeValue
            // 
            entreFeeValue.Location = new Point(188, 227);
            entreFeeValue.Name = "entreFeeValue";
            entreFeeValue.Size = new Size(150, 31);
            entreFeeValue.TabIndex = 16;
            entreFeeValue.Text = "0";
            entreFeeValue.TextChanged += TeamTwoScoreText_TextChanged;
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
            // SelectTeamDropDown
            // 
            SelectTeamDropDown.FormattingEnabled = true;
            SelectTeamDropDown.Location = new Point(32, 332);
            SelectTeamDropDown.Name = "SelectTeamDropDown";
            SelectTeamDropDown.Size = new Size(324, 33);
            SelectTeamDropDown.TabIndex = 18;
            SelectTeamDropDown.SelectedIndexChanged += SelectTeamDropDown_SelectedIndexChanged;
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
            // AddTeamButton
            // 
            AddTeamButton.FlatAppearance.BorderColor = Color.Silver;
            AddTeamButton.FlatAppearance.MouseDownBackColor = Color.Silver;
            AddTeamButton.FlatAppearance.MouseOverBackColor = Color.White;
            AddTeamButton.FlatStyle = FlatStyle.Flat;
            AddTeamButton.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddTeamButton.ForeColor = Color.DeepSkyBlue;
            AddTeamButton.Location = new Point(96, 381);
            AddTeamButton.Name = "AddTeamButton";
            AddTeamButton.Size = new Size(170, 54);
            AddTeamButton.TabIndex = 20;
            AddTeamButton.Text = "Add Team";
            AddTeamButton.UseVisualStyleBackColor = true;
            AddTeamButton.Click += AddTeamButton_Click;
            // 
            // CreatePrizeBotton
            // 
            CreatePrizeBotton.FlatAppearance.BorderColor = Color.Silver;
            CreatePrizeBotton.FlatAppearance.MouseDownBackColor = Color.Silver;
            CreatePrizeBotton.FlatAppearance.MouseOverBackColor = Color.White;
            CreatePrizeBotton.FlatStyle = FlatStyle.Flat;
            CreatePrizeBotton.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreatePrizeBotton.ForeColor = Color.DeepSkyBlue;
            CreatePrizeBotton.Location = new Point(85, 447);
            CreatePrizeBotton.Name = "CreatePrizeBotton";
            CreatePrizeBotton.Size = new Size(200, 50);
            CreatePrizeBotton.TabIndex = 21;
            CreatePrizeBotton.Text = "Create Prize";
            CreatePrizeBotton.UseVisualStyleBackColor = true;
            CreatePrizeBotton.Click += CreatePrizeBotton_Click;
            // 
            // TournamentPlayersListBox
            // 
            TournamentPlayersListBox.BorderStyle = BorderStyle.FixedSingle;
            TournamentPlayersListBox.FormattingEnabled = true;
            TournamentPlayersListBox.ItemHeight = 25;
            TournamentPlayersListBox.Location = new Point(430, 135);
            TournamentPlayersListBox.Name = "TournamentPlayersListBox";
            TournamentPlayersListBox.Size = new Size(318, 152);
            TournamentPlayersListBox.TabIndex = 22;
            TournamentPlayersListBox.SelectedIndexChanged += TournamentPlayersListBox_SelectedIndexChanged;
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
            // prizeslistBox1
            // 
            prizeslistBox1.BorderStyle = BorderStyle.FixedSingle;
            prizeslistBox1.FormattingEnabled = true;
            prizeslistBox1.ItemHeight = 25;
            prizeslistBox1.Location = new Point(430, 366);
            prizeslistBox1.Name = "prizeslistBox1";
            prizeslistBox1.Size = new Size(318, 127);
            prizeslistBox1.TabIndex = 24;
            prizeslistBox1.SelectedIndexChanged += prizeslistBox1_SelectedIndexChanged;
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
            // CreateTournamentBotton
            // 
            CreateTournamentBotton.FlatAppearance.BorderColor = Color.Silver;
            CreateTournamentBotton.FlatAppearance.MouseDownBackColor = Color.Silver;
            CreateTournamentBotton.FlatAppearance.MouseOverBackColor = Color.White;
            CreateTournamentBotton.FlatStyle = FlatStyle.Flat;
            CreateTournamentBotton.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreateTournamentBotton.ForeColor = Color.DeepSkyBlue;
            CreateTournamentBotton.Location = new Point(275, 512);
            CreateTournamentBotton.Name = "CreateTournamentBotton";
            CreateTournamentBotton.Size = new Size(281, 50);
            CreateTournamentBotton.TabIndex = 28;
            CreateTournamentBotton.Text = "Create Tournament";
            CreateTournamentBotton.UseVisualStyleBackColor = true;
            CreateTournamentBotton.Click += CreateTournamentBotton_Click;
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(935, 574);
            Controls.Add(CreateTournamentBotton);
            Controls.Add(deleteSelecterdPrizeButton);
            Controls.Add(deleteSelectedPlayersButton);
            Controls.Add(prizesLabel);
            Controls.Add(prizeslistBox1);
            Controls.Add(TournamentPlayersLabel);
            Controls.Add(TournamentPlayersListBox);
            Controls.Add(CreatePrizeBotton);
            Controls.Add(AddTeamButton);
            Controls.Add(createNewTeamLink);
            Controls.Add(SelectTeamDropDown);
            Controls.Add(SelectTeamLabel);
            Controls.Add(entreFeeValue);
            Controls.Add(entreFeeLabel);
            Controls.Add(TournamentValue);
            Controls.Add(TournamentNameText);
            Controls.Add(headerLabel);
            Name = "CreateTournamentForm";
            Text = "Create Tournament";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private TextBox TournamentValue;
        private Label TournamentNameText;
        private TextBox entreFeeValue;
        private Label entreFeeLabel;
        private ComboBox SelectTeamDropDown;
        private Label SelectTeamLabel;
        private LinkLabel createNewTeamLink;
        private Button AddTeamButton;
        private Button CreatePrizeBotton;
        private ListBox TournamentPlayersListBox;
        private Label TournamentPlayersLabel;
        private Label prizesLabel;
        private ListBox prizeslistBox1;
        private Button deleteSelectedPlayersButton;
        private Button deleteSelecterdPrizeButton;
        private Button CreateTournamentBotton;
    }
}