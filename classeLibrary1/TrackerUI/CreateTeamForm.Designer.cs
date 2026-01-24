namespace TrackerUI
{
    partial class CreateTeamForm
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
            TeamNameValue = new TextBox();
            TeamNameLabel = new Label();
            headerLabel = new Label();
            AddTeamMemberButton = new Button();
            SelectTeamMemberDropDown = new ComboBox();
            SelectTeamMemberLabel = new Label();
            groupBox1 = new GroupBox();
            FirstNameValue = new TextBox();
            firstNameLabel = new Label();
            lastNameValue = new TextBox();
            lastNameLabel = new Label();
            emailValue = new TextBox();
            emailLabel = new Label();
            cellphoneValue = new TextBox();
            cellphoneLabel = new Label();
            createMemberBotton = new Button();
            teamMembersListBox = new ListBox();
            deleteMemberPlayersButton = new Button();
            createTeamBotton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // TeamNameValue
            // 
            TeamNameValue.Location = new Point(23, 114);
            TeamNameValue.Name = "TeamNameValue";
            TeamNameValue.Size = new Size(371, 31);
            TeamNameValue.TabIndex = 17;
            TeamNameValue.TextChanged += TeamNameValue_TextChanged;
            // 
            // TeamNameLabel
            // 
            TeamNameLabel.AutoSize = true;
            TeamNameLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TeamNameLabel.ForeColor = Color.DeepSkyBlue;
            TeamNameLabel.Location = new Point(23, 66);
            TeamNameLabel.Name = "TeamNameLabel";
            TeamNameLabel.Size = new Size(189, 45);
            TeamNameLabel.TabIndex = 16;
            TeamNameLabel.Text = "Team Name";
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.FlatStyle = FlatStyle.Flat;
            headerLabel.Font = new Font("Arial Narrow", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headerLabel.ForeColor = Color.DeepSkyBlue;
            headerLabel.Location = new Point(12, 9);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(261, 57);
            headerLabel.TabIndex = 15;
            headerLabel.Text = "Create Team";
            // 
            // AddTeamMemberButton
            // 
            AddTeamMemberButton.FlatAppearance.BorderColor = Color.Silver;
            AddTeamMemberButton.FlatAppearance.MouseDownBackColor = Color.Silver;
            AddTeamMemberButton.FlatAppearance.MouseOverBackColor = Color.White;
            AddTeamMemberButton.FlatStyle = FlatStyle.Flat;
            AddTeamMemberButton.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddTeamMemberButton.ForeColor = Color.DeepSkyBlue;
            AddTeamMemberButton.Location = new Point(59, 249);
            AddTeamMemberButton.Name = "AddTeamMemberButton";
            AddTeamMemberButton.Size = new Size(197, 54);
            AddTeamMemberButton.TabIndex = 23;
            AddTeamMemberButton.Text = "Add Member";
            AddTeamMemberButton.UseVisualStyleBackColor = true;
            // 
            // SelectTeamMemberDropDown
            // 
            SelectTeamMemberDropDown.FormattingEnabled = true;
            SelectTeamMemberDropDown.Location = new Point(23, 210);
            SelectTeamMemberDropDown.Name = "SelectTeamMemberDropDown";
            SelectTeamMemberDropDown.Size = new Size(324, 33);
            SelectTeamMemberDropDown.TabIndex = 22;
            SelectTeamMemberDropDown.SelectedIndexChanged += SelectTeamMemberDropDown_SelectedIndexChanged;
            // 
            // SelectTeamMemberLabel
            // 
            SelectTeamMemberLabel.AutoSize = true;
            SelectTeamMemberLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SelectTeamMemberLabel.ForeColor = Color.DeepSkyBlue;
            SelectTeamMemberLabel.Location = new Point(23, 157);
            SelectTeamMemberLabel.Name = "SelectTeamMemberLabel";
            SelectTeamMemberLabel.Size = new Size(319, 45);
            SelectTeamMemberLabel.TabIndex = 21;
            SelectTeamMemberLabel.Text = "Select Team Member";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(createMemberBotton);
            groupBox1.Controls.Add(cellphoneValue);
            groupBox1.Controls.Add(cellphoneLabel);
            groupBox1.Controls.Add(emailValue);
            groupBox1.Controls.Add(emailLabel);
            groupBox1.Controls.Add(lastNameValue);
            groupBox1.Controls.Add(lastNameLabel);
            groupBox1.Controls.Add(FirstNameValue);
            groupBox1.Controls.Add(firstNameLabel);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.MenuHighlight;
            groupBox1.Location = new Point(23, 330);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(469, 268);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add New Member";
            // 
            // FirstNameValue
            // 
            FirstNameValue.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FirstNameValue.Location = new Point(174, 44);
            FirstNameValue.Name = "FirstNameValue";
            FirstNameValue.Size = new Size(237, 29);
            FirstNameValue.TabIndex = 10;
            FirstNameValue.TextChanged += FirstNameValue_TextChanged;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstNameLabel.ForeColor = Color.DeepSkyBlue;
            firstNameLabel.Location = new Point(13, 45);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(151, 38);
            firstNameLabel.TabIndex = 9;
            firstNameLabel.Text = "Frist Name";
            // 
            // lastNameValue
            // 
            lastNameValue.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastNameValue.Location = new Point(174, 87);
            lastNameValue.Name = "lastNameValue";
            lastNameValue.Size = new Size(237, 29);
            lastNameValue.TabIndex = 12;
            lastNameValue.TextChanged += lastNameValue_TextChanged;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastNameLabel.ForeColor = Color.DeepSkyBlue;
            lastNameLabel.Location = new Point(17, 83);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(147, 38);
            lastNameLabel.TabIndex = 11;
            lastNameLabel.Text = "Last Name";
            // 
            // emailValue
            // 
            emailValue.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailValue.Location = new Point(174, 125);
            emailValue.Name = "emailValue";
            emailValue.Size = new Size(237, 29);
            emailValue.TabIndex = 14;
            emailValue.TextChanged += emailValue_TextChanged;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailLabel.ForeColor = Color.DeepSkyBlue;
            emailLabel.Location = new Point(17, 121);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(83, 38);
            emailLabel.TabIndex = 13;
            emailLabel.Text = "Email";
            // 
            // cellphoneValue
            // 
            cellphoneValue.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cellphoneValue.Location = new Point(174, 163);
            cellphoneValue.Name = "cellphoneValue";
            cellphoneValue.Size = new Size(237, 29);
            cellphoneValue.TabIndex = 16;
            cellphoneValue.TextChanged += textBox3_TextChanged;
            // 
            // cellphoneLabel
            // 
            cellphoneLabel.AutoSize = true;
            cellphoneLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cellphoneLabel.ForeColor = Color.DeepSkyBlue;
            cellphoneLabel.Location = new Point(17, 159);
            cellphoneLabel.Name = "cellphoneLabel";
            cellphoneLabel.Size = new Size(142, 38);
            cellphoneLabel.TabIndex = 15;
            cellphoneLabel.Text = "Cellphone";
            // 
            // createMemberBotton
            // 
            createMemberBotton.FlatAppearance.BorderColor = Color.Silver;
            createMemberBotton.FlatAppearance.MouseDownBackColor = Color.Silver;
            createMemberBotton.FlatAppearance.MouseOverBackColor = Color.White;
            createMemberBotton.FlatStyle = FlatStyle.Flat;
            createMemberBotton.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createMemberBotton.ForeColor = Color.DeepSkyBlue;
            createMemberBotton.Location = new Point(143, 200);
            createMemberBotton.Name = "createMemberBotton";
            createMemberBotton.Size = new Size(197, 54);
            createMemberBotton.TabIndex = 25;
            createMemberBotton.Text = "Create Member";
            createMemberBotton.UseVisualStyleBackColor = true;
            createMemberBotton.Click += createMemberBotton_Click;
            // 
            // teamMembersListBox
            // 
            teamMembersListBox.BorderStyle = BorderStyle.FixedSingle;
            teamMembersListBox.FormattingEnabled = true;
            teamMembersListBox.ItemHeight = 25;
            teamMembersListBox.Location = new Point(536, 114);
            teamMembersListBox.Name = "teamMembersListBox";
            teamMembersListBox.Size = new Size(349, 477);
            teamMembersListBox.TabIndex = 25;
            teamMembersListBox.SelectedIndexChanged += teamMembersListBox_SelectedIndexChanged;
            // 
            // deleteMemberPlayersButton
            // 
            deleteMemberPlayersButton.FlatAppearance.BorderColor = Color.Silver;
            deleteMemberPlayersButton.FlatAppearance.MouseDownBackColor = Color.Silver;
            deleteMemberPlayersButton.FlatAppearance.MouseOverBackColor = Color.White;
            deleteMemberPlayersButton.FlatStyle = FlatStyle.Flat;
            deleteMemberPlayersButton.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteMemberPlayersButton.ForeColor = Color.DeepSkyBlue;
            deleteMemberPlayersButton.Location = new Point(898, 313);
            deleteMemberPlayersButton.Name = "deleteMemberPlayersButton";
            deleteMemberPlayersButton.Size = new Size(135, 90);
            deleteMemberPlayersButton.TabIndex = 27;
            deleteMemberPlayersButton.Text = "Delete Member";
            deleteMemberPlayersButton.UseVisualStyleBackColor = true;
            // 
            // createTeamBotton
            // 
            createTeamBotton.FlatAppearance.BorderColor = Color.Silver;
            createTeamBotton.FlatAppearance.MouseDownBackColor = Color.Silver;
            createTeamBotton.FlatAppearance.MouseOverBackColor = Color.White;
            createTeamBotton.FlatStyle = FlatStyle.Flat;
            createTeamBotton.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createTeamBotton.ForeColor = Color.DeepSkyBlue;
            createTeamBotton.Location = new Point(348, 620);
            createTeamBotton.Name = "createTeamBotton";
            createTeamBotton.Size = new Size(371, 63);
            createTeamBotton.TabIndex = 28;
            createTeamBotton.Text = "Create Team";
            createTeamBotton.UseVisualStyleBackColor = true;
            createTeamBotton.Click += createTeamBotton_Click;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1045, 695);
            Controls.Add(createTeamBotton);
            Controls.Add(deleteMemberPlayersButton);
            Controls.Add(teamMembersListBox);
            Controls.Add(groupBox1);
            Controls.Add(AddTeamMemberButton);
            Controls.Add(SelectTeamMemberDropDown);
            Controls.Add(SelectTeamMemberLabel);
            Controls.Add(TeamNameValue);
            Controls.Add(TeamNameLabel);
            Controls.Add(headerLabel);
            Name = "CreateTeamForm";
            Text = "Create Team";
            Load += CreateTeamForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TeamNameValue;
        private Label TeamNameLabel;
        private Label headerLabel;
        private Button AddTeamMemberButton;
        private ComboBox SelectTeamMemberDropDown;
        private Label SelectTeamMemberLabel;
        private GroupBox groupBox1;
        private TextBox FirstNameValue;
        private Label firstNameLabel;
        private TextBox lastNameValue;
        private Label lastNameLabel;
        private TextBox cellphoneValue;
        private Label cellphoneLabel;
        private TextBox emailValue;
        private Label emailLabel;
        private Button createMemberBotton;
        private ListBox teamMembersListBox;
        private Button deleteMemberPlayersButton;
        private Button createTeamBotton;
    }
}