namespace TrackerUI
{
    partial class orLabel
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
            placeNumberValue = new TextBox();
            placeNumberLabel = new Label();
            PrizeLabel = new Label();
            placeNameValues = new TextBox();
            placeNameLabel = new Label();
            prizeAmountValue = new TextBox();
            prizeAmountLabel = new Label();
            prizePercentageValue = new TextBox();
            prizePercentageLabel = new Label();
            label1 = new Label();
            createPrizeBotton = new Button();
            SuspendLayout();
            // 
            // placeNumberValue
            // 
            placeNumberValue.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            placeNumberValue.Location = new Point(296, 88);
            placeNumberValue.Name = "placeNumberValue";
            placeNumberValue.Size = new Size(276, 29);
            placeNumberValue.TabIndex = 17;
            placeNumberValue.TextChanged += placeNumberValue_TextChanged;
            // 
            // placeNumberLabel
            // 
            placeNumberLabel.AutoSize = true;
            placeNumberLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            placeNumberLabel.ForeColor = Color.DeepSkyBlue;
            placeNumberLabel.Location = new Point(72, 77);
            placeNumberLabel.Name = "placeNumberLabel";
            placeNumberLabel.Size = new Size(192, 38);
            placeNumberLabel.TabIndex = 16;
            placeNumberLabel.Text = "Place Number";
            // 
            // PrizeLabel
            // 
            PrizeLabel.AutoSize = true;
            PrizeLabel.FlatStyle = FlatStyle.Flat;
            PrizeLabel.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PrizeLabel.ForeColor = SystemColors.MenuHighlight;
            PrizeLabel.Location = new Point(12, 9);
            PrizeLabel.Name = "PrizeLabel";
            PrizeLabel.Size = new Size(274, 60);
            PrizeLabel.TabIndex = 18;
            PrizeLabel.Text = "Create Prize";
            // 
            // placeNameValues
            // 
            placeNameValues.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            placeNameValues.Location = new Point(296, 142);
            placeNameValues.Name = "placeNameValues";
            placeNameValues.Size = new Size(276, 29);
            placeNameValues.TabIndex = 20;
            placeNameValues.TextChanged += placeNameValues_TextChanged;
            // 
            // placeNameLabel
            // 
            placeNameLabel.AutoSize = true;
            placeNameLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            placeNameLabel.ForeColor = Color.DeepSkyBlue;
            placeNameLabel.Location = new Point(90, 133);
            placeNameLabel.Name = "placeNameLabel";
            placeNameLabel.Size = new Size(164, 38);
            placeNameLabel.TabIndex = 19;
            placeNameLabel.Text = "Place Name";
            // 
            // prizeAmountValue
            // 
            prizeAmountValue.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prizeAmountValue.Location = new Point(296, 186);
            prizeAmountValue.Name = "prizeAmountValue";
            prizeAmountValue.Size = new Size(276, 29);
            prizeAmountValue.TabIndex = 22;
            prizeAmountValue.TextChanged += prizeAmountValue_TextChanged;
            // 
            // prizeAmountLabel
            // 
            prizeAmountLabel.AutoSize = true;
            prizeAmountLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prizeAmountLabel.ForeColor = Color.DeepSkyBlue;
            prizeAmountLabel.Location = new Point(69, 186);
            prizeAmountLabel.Name = "prizeAmountLabel";
            prizeAmountLabel.Size = new Size(185, 38);
            prizeAmountLabel.TabIndex = 21;
            prizeAmountLabel.Text = "Prize Amount";
            // 
            // prizePercentageValue
            // 
            prizePercentageValue.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prizePercentageValue.Location = new Point(296, 276);
            prizePercentageValue.Name = "prizePercentageValue";
            prizePercentageValue.Size = new Size(276, 29);
            prizePercentageValue.TabIndex = 24;
            prizePercentageValue.TextChanged += prizePercentageValue_TextChanged;
            // 
            // prizePercentageLabel
            // 
            prizePercentageLabel.AutoSize = true;
            prizePercentageLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prizePercentageLabel.ForeColor = Color.DeepSkyBlue;
            prizePercentageLabel.Location = new Point(40, 267);
            prizePercentageLabel.Name = "prizePercentageLabel";
            prizePercentageLabel.Size = new Size(224, 38);
            prizePercentageLabel.TabIndex = 23;
            prizePercentageLabel.Text = "Prize Percentage";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DeepSkyBlue;
            label1.Location = new Point(236, 229);
            label1.Name = "label1";
            label1.Size = new Size(65, 38);
            label1.TabIndex = 25;
            label1.Text = "-or-";
            // 
            // createPrizeBotton
            // 
            createPrizeBotton.FlatAppearance.BorderColor = Color.Silver;
            createPrizeBotton.FlatAppearance.MouseDownBackColor = Color.Silver;
            createPrizeBotton.FlatAppearance.MouseOverBackColor = Color.White;
            createPrizeBotton.FlatStyle = FlatStyle.Flat;
            createPrizeBotton.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createPrizeBotton.ForeColor = Color.DeepSkyBlue;
            createPrizeBotton.Location = new Point(185, 350);
            createPrizeBotton.Name = "createPrizeBotton";
            createPrizeBotton.Size = new Size(273, 63);
            createPrizeBotton.TabIndex = 29;
            createPrizeBotton.Text = "Create Prize";
            createPrizeBotton.UseVisualStyleBackColor = true;
            createPrizeBotton.Click += createPrizeBotton_Click;
            // 
            // orLabel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(662, 437);
            Controls.Add(createPrizeBotton);
            Controls.Add(label1);
            Controls.Add(prizePercentageValue);
            Controls.Add(prizePercentageLabel);
            Controls.Add(prizeAmountValue);
            Controls.Add(prizeAmountLabel);
            Controls.Add(placeNameValues);
            Controls.Add(placeNameLabel);
            Controls.Add(placeNumberValue);
            Controls.Add(placeNumberLabel);
            Controls.Add(PrizeLabel);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "orLabel";
            Text = "Create Prize";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox placeNumberValue;
        private Label placeNumberLabel;
        private Label PrizeLabel;
        private TextBox placeNameValues;
        private Label placeNameLabel;
        private TextBox prizeAmountValue;
        private Label prizeAmountLabel;
        private TextBox prizePercentageValue;
        private Label prizePercentageLabel;
        private Label label1;
        private Button createPrizeBotton;
    }
}