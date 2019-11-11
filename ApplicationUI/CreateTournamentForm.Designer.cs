namespace ApplicationUI
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.tournamentNameValue = new System.Windows.Forms.TextBox();
            this.tournamentNameLabel = new System.Windows.Forms.Label();
            this.entryFeeValue = new System.Windows.Forms.TextBox();
            this.entryFeeLabel = new System.Windows.Forms.Label();
            this.selectTeamLabel = new System.Windows.Forms.Label();
            this.creatTeamLinkLabel = new System.Windows.Forms.LinkLabel();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.tournamentPlayersLabel = new System.Windows.Forms.Label();
            this.teamPlayerListBox = new System.Windows.Forms.ListBox();
            this.deleteSelectedPlayersButton = new System.Windows.Forms.Button();
            this.deleteSelectedPrizeButton = new System.Windows.Forms.Button();
            this.prizeListBox = new System.Windows.Forms.ListBox();
            this.prizeLabel = new System.Windows.Forms.Label();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.selectTeamComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.ForeColor = System.Drawing.Color.Green;
            this.headerLabel.Location = new System.Drawing.Point(12, 33);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(319, 33);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Bajnokság Létrehozása";
            // 
            // tournamentNameValue
            // 
            this.tournamentNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tournamentNameValue.ForeColor = System.Drawing.Color.Green;
            this.tournamentNameValue.Location = new System.Drawing.Point(29, 119);
            this.tournamentNameValue.Name = "tournamentNameValue";
            this.tournamentNameValue.Size = new System.Drawing.Size(310, 35);
            this.tournamentNameValue.TabIndex = 10;
            // 
            // tournamentNameLabel
            // 
            this.tournamentNameLabel.AutoSize = true;
            this.tournamentNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tournamentNameLabel.ForeColor = System.Drawing.Color.Green;
            this.tournamentNameLabel.Location = new System.Drawing.Point(24, 87);
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.Size = new System.Drawing.Size(189, 29);
            this.tournamentNameLabel.TabIndex = 9;
            this.tournamentNameLabel.Text = "Bajnokság Neve";
            // 
            // entryFeeValue
            // 
            this.entryFeeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.entryFeeValue.ForeColor = System.Drawing.Color.Green;
            this.entryFeeValue.Location = new System.Drawing.Point(178, 182);
            this.entryFeeValue.Name = "entryFeeValue";
            this.entryFeeValue.Size = new System.Drawing.Size(71, 35);
            this.entryFeeValue.TabIndex = 12;
            this.entryFeeValue.Text = "0";
            // 
            // entryFeeLabel
            // 
            this.entryFeeLabel.AutoSize = true;
            this.entryFeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.entryFeeLabel.ForeColor = System.Drawing.Color.Green;
            this.entryFeeLabel.Location = new System.Drawing.Point(24, 185);
            this.entryFeeLabel.Name = "entryFeeLabel";
            this.entryFeeLabel.Size = new System.Drawing.Size(148, 29);
            this.entryFeeLabel.TabIndex = 11;
            this.entryFeeLabel.Text = "Nevezési Díj";
            // 
            // selectTeamLabel
            // 
            this.selectTeamLabel.AutoSize = true;
            this.selectTeamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectTeamLabel.ForeColor = System.Drawing.Color.Green;
            this.selectTeamLabel.Location = new System.Drawing.Point(24, 237);
            this.selectTeamLabel.Name = "selectTeamLabel";
            this.selectTeamLabel.Size = new System.Drawing.Size(226, 29);
            this.selectTeamLabel.TabIndex = 13;
            this.selectTeamLabel.Text = "Csapat Kiválasztása";
            // 
            // creatTeamLinkLabel
            // 
            this.creatTeamLinkLabel.AutoSize = true;
            this.creatTeamLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.creatTeamLinkLabel.ForeColor = System.Drawing.Color.Green;
            this.creatTeamLinkLabel.LinkColor = System.Drawing.Color.Lime;
            this.creatTeamLinkLabel.Location = new System.Drawing.Point(256, 247);
            this.creatTeamLinkLabel.Name = "creatTeamLinkLabel";
            this.creatTeamLinkLabel.Size = new System.Drawing.Size(83, 16);
            this.creatTeamLinkLabel.TabIndex = 15;
            this.creatTeamLinkLabel.TabStop = true;
            this.creatTeamLinkLabel.Text = "új létrehozás";
            this.creatTeamLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.creatTeamLinkLabel_LinkClicked);
            // 
            // addTeamButton
            // 
            this.addTeamButton.BackColor = System.Drawing.Color.White;
            this.addTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addTeamButton.ForeColor = System.Drawing.Color.Green;
            this.addTeamButton.Location = new System.Drawing.Point(72, 319);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(218, 42);
            this.addTeamButton.TabIndex = 16;
            this.addTeamButton.Text = "Csapat Hozzáadása";
            this.addTeamButton.UseVisualStyleBackColor = false;
            this.addTeamButton.Click += new System.EventHandler(this.addTeamButton_Click);
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.BackColor = System.Drawing.Color.White;
            this.createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createPrizeButton.ForeColor = System.Drawing.Color.Green;
            this.createPrizeButton.Location = new System.Drawing.Point(86, 383);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(190, 42);
            this.createPrizeButton.TabIndex = 17;
            this.createPrizeButton.Text = "Díj Létrehozása";
            this.createPrizeButton.UseVisualStyleBackColor = false;
            this.createPrizeButton.Click += new System.EventHandler(this.createPrizeButton_Click);
            // 
            // tournamentPlayersLabel
            // 
            this.tournamentPlayersLabel.AutoSize = true;
            this.tournamentPlayersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tournamentPlayersLabel.ForeColor = System.Drawing.Color.Green;
            this.tournamentPlayersLabel.Location = new System.Drawing.Point(389, 87);
            this.tournamentPlayersLabel.Name = "tournamentPlayersLabel";
            this.tournamentPlayersLabel.Size = new System.Drawing.Size(230, 29);
            this.tournamentPlayersLabel.TabIndex = 18;
            this.tournamentPlayersLabel.Text = "Csapatok/Játékosok";
            // 
            // teamPlayerListBox
            // 
            this.teamPlayerListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teamPlayerListBox.ForeColor = System.Drawing.Color.Green;
            this.teamPlayerListBox.FormattingEnabled = true;
            this.teamPlayerListBox.ItemHeight = 24;
            this.teamPlayerListBox.Location = new System.Drawing.Point(394, 119);
            this.teamPlayerListBox.Name = "teamPlayerListBox";
            this.teamPlayerListBox.Size = new System.Drawing.Size(277, 148);
            this.teamPlayerListBox.TabIndex = 19;
            // 
            // deleteSelectedPlayersButton
            // 
            this.deleteSelectedPlayersButton.BackColor = System.Drawing.Color.White;
            this.deleteSelectedPlayersButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedPlayersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteSelectedPlayersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteSelectedPlayersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedPlayersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteSelectedPlayersButton.ForeColor = System.Drawing.Color.Green;
            this.deleteSelectedPlayersButton.Location = new System.Drawing.Point(677, 150);
            this.deleteSelectedPlayersButton.Name = "deleteSelectedPlayersButton";
            this.deleteSelectedPlayersButton.Size = new System.Drawing.Size(135, 90);
            this.deleteSelectedPlayersButton.TabIndex = 20;
            this.deleteSelectedPlayersButton.Text = "Kiválasztott Törlése";
            this.deleteSelectedPlayersButton.UseVisualStyleBackColor = false;
            this.deleteSelectedPlayersButton.Click += new System.EventHandler(this.deleteSelectedPlayersButton_Click);
            // 
            // deleteSelectedPrizeButton
            // 
            this.deleteSelectedPrizeButton.BackColor = System.Drawing.Color.White;
            this.deleteSelectedPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteSelectedPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteSelectedPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedPrizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteSelectedPrizeButton.ForeColor = System.Drawing.Color.Green;
            this.deleteSelectedPrizeButton.Location = new System.Drawing.Point(677, 336);
            this.deleteSelectedPrizeButton.Name = "deleteSelectedPrizeButton";
            this.deleteSelectedPrizeButton.Size = new System.Drawing.Size(135, 89);
            this.deleteSelectedPrizeButton.TabIndex = 23;
            this.deleteSelectedPrizeButton.Text = "Kiválasztott Törlése";
            this.deleteSelectedPrizeButton.UseVisualStyleBackColor = true;
            this.deleteSelectedPrizeButton.Click += new System.EventHandler(this.deleteSelectedPrizeButton_Click);
            // 
            // prizeListBox
            // 
            this.prizeListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prizeListBox.ForeColor = System.Drawing.Color.Green;
            this.prizeListBox.FormattingEnabled = true;
            this.prizeListBox.ItemHeight = 24;
            this.prizeListBox.Location = new System.Drawing.Point(394, 305);
            this.prizeListBox.Name = "prizeListBox";
            this.prizeListBox.Size = new System.Drawing.Size(277, 148);
            this.prizeListBox.TabIndex = 22;
            // 
            // prizeLabel
            // 
            this.prizeLabel.AutoSize = true;
            this.prizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prizeLabel.ForeColor = System.Drawing.Color.Green;
            this.prizeLabel.Location = new System.Drawing.Point(389, 273);
            this.prizeLabel.Name = "prizeLabel";
            this.prizeLabel.Size = new System.Drawing.Size(67, 29);
            this.prizeLabel.TabIndex = 21;
            this.prizeLabel.Text = "Díjak";
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.BackColor = System.Drawing.Color.White;
            this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createTournamentButton.ForeColor = System.Drawing.Color.Green;
            this.createTournamentButton.Location = new System.Drawing.Point(319, 471);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(218, 64);
            this.createTournamentButton.TabIndex = 24;
            this.createTournamentButton.Text = "Bajnokság Létrehozása";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            this.createTournamentButton.Click += new System.EventHandler(this.createTournamentButton_Click);
            // 
            // selectTeamComboBox
            // 
            this.selectTeamComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectTeamComboBox.ForeColor = System.Drawing.Color.Green;
            this.selectTeamComboBox.FormattingEnabled = true;
            this.selectTeamComboBox.Location = new System.Drawing.Point(29, 269);
            this.selectTeamComboBox.Name = "selectTeamComboBox";
            this.selectTeamComboBox.Size = new System.Drawing.Size(310, 33);
            this.selectTeamComboBox.TabIndex = 25;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(833, 547);
            this.Controls.Add(this.selectTeamComboBox);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.deleteSelectedPrizeButton);
            this.Controls.Add(this.prizeListBox);
            this.Controls.Add(this.prizeLabel);
            this.Controls.Add(this.deleteSelectedPlayersButton);
            this.Controls.Add(this.teamPlayerListBox);
            this.Controls.Add(this.tournamentPlayersLabel);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.creatTeamLinkLabel);
            this.Controls.Add(this.selectTeamLabel);
            this.Controls.Add(this.entryFeeValue);
            this.Controls.Add(this.entryFeeLabel);
            this.Controls.Add(this.tournamentNameValue);
            this.Controls.Add(this.tournamentNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "CreateTournamentForm";
            this.Text = "Bajnokság Létrehozása";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TextBox tournamentNameValue;
        private System.Windows.Forms.Label tournamentNameLabel;
        private System.Windows.Forms.TextBox entryFeeValue;
        private System.Windows.Forms.Label entryFeeLabel;
        private System.Windows.Forms.Label selectTeamLabel;
        private System.Windows.Forms.LinkLabel creatTeamLinkLabel;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.Button createPrizeButton;
        private System.Windows.Forms.Label tournamentPlayersLabel;
        private System.Windows.Forms.ListBox teamPlayerListBox;
        private System.Windows.Forms.Button deleteSelectedPlayersButton;
        private System.Windows.Forms.Button deleteSelectedPrizeButton;
        private System.Windows.Forms.ListBox prizeListBox;
        private System.Windows.Forms.Label prizeLabel;
        private System.Windows.Forms.Button createTournamentButton;
        private System.Windows.Forms.ComboBox selectTeamComboBox;
    }
}