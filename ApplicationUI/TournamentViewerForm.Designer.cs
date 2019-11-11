namespace ApplicationUI
{
    partial class TournamentViewerForm
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
            this.tournamentNameLabel = new System.Windows.Forms.Label();
            this.roundLabel = new System.Windows.Forms.Label();
            this.roundsComboBox = new System.Windows.Forms.ComboBox();
            this.unplayedOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.matchUpListBox = new System.Windows.Forms.ListBox();
            this.firstTeamNameLabel = new System.Windows.Forms.Label();
            this.firstScoreLabel = new System.Windows.Forms.Label();
            this.firstTeamScoreLabel = new System.Windows.Forms.TextBox();
            this.secondTeamScoreLabel = new System.Windows.Forms.TextBox();
            this.secondScoreLabel = new System.Windows.Forms.Label();
            this.secondTeamNameLabel = new System.Windows.Forms.Label();
            this.vsLabel = new System.Windows.Forms.Label();
            this.scoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.ForeColor = System.Drawing.Color.Green;
            this.headerLabel.Location = new System.Drawing.Point(12, 25);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(159, 33);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Bajnokság:";
            // 
            // tournamentNameLabel
            // 
            this.tournamentNameLabel.AutoSize = true;
            this.tournamentNameLabel.ForeColor = System.Drawing.Color.Green;
            this.tournamentNameLabel.Location = new System.Drawing.Point(198, 25);
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.Size = new System.Drawing.Size(118, 33);
            this.tournamentNameLabel.TabIndex = 1;
            this.tournamentNameLabel.Text = "<nincs>";
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.roundLabel.ForeColor = System.Drawing.Color.Green;
            this.roundLabel.Location = new System.Drawing.Point(12, 81);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(85, 25);
            this.roundLabel.TabIndex = 2;
            this.roundLabel.Text = "Forduló";
            // 
            // roundsComboBox
            // 
            this.roundsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.roundsComboBox.ForeColor = System.Drawing.Color.Green;
            this.roundsComboBox.FormattingEnabled = true;
            this.roundsComboBox.Location = new System.Drawing.Point(93, 78);
            this.roundsComboBox.Name = "roundsComboBox";
            this.roundsComboBox.Size = new System.Drawing.Size(202, 33);
            this.roundsComboBox.TabIndex = 3;
            this.roundsComboBox.SelectedIndexChanged += new System.EventHandler(this.roundsComboBox_SelectedIndexChanged);
            // 
            // unplayedOnlyCheckBox
            // 
            this.unplayedOnlyCheckBox.AutoSize = true;
            this.unplayedOnlyCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.unplayedOnlyCheckBox.ForeColor = System.Drawing.Color.Green;
            this.unplayedOnlyCheckBox.Location = new System.Drawing.Point(93, 117);
            this.unplayedOnlyCheckBox.Name = "unplayedOnlyCheckBox";
            this.unplayedOnlyCheckBox.Size = new System.Drawing.Size(137, 24);
            this.unplayedOnlyCheckBox.TabIndex = 4;
            this.unplayedOnlyCheckBox.Text = "Le nem játszott";
            this.unplayedOnlyCheckBox.UseVisualStyleBackColor = true;
            this.unplayedOnlyCheckBox.CheckedChanged += new System.EventHandler(this.unplayedOnlyCheckBox_CheckedChanged);
            // 
            // matchUpListBox
            // 
            this.matchUpListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.matchUpListBox.ForeColor = System.Drawing.Color.Green;
            this.matchUpListBox.FormattingEnabled = true;
            this.matchUpListBox.ItemHeight = 24;
            this.matchUpListBox.Location = new System.Drawing.Point(17, 178);
            this.matchUpListBox.Name = "matchUpListBox";
            this.matchUpListBox.Size = new System.Drawing.Size(277, 244);
            this.matchUpListBox.TabIndex = 5;
            this.matchUpListBox.SelectedIndexChanged += new System.EventHandler(this.matchUpListBox_SelectedIndexChanged);
            // 
            // firstTeamNameLabel
            // 
            this.firstTeamNameLabel.AutoSize = true;
            this.firstTeamNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.firstTeamNameLabel.ForeColor = System.Drawing.Color.Green;
            this.firstTeamNameLabel.Location = new System.Drawing.Point(338, 117);
            this.firstTeamNameLabel.Name = "firstTeamNameLabel";
            this.firstTeamNameLabel.Size = new System.Drawing.Size(97, 29);
            this.firstTeamNameLabel.TabIndex = 6;
            this.firstTeamNameLabel.Text = "<hazai>";
            // 
            // firstScoreLabel
            // 
            this.firstScoreLabel.AutoSize = true;
            this.firstScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.firstScoreLabel.ForeColor = System.Drawing.Color.Green;
            this.firstScoreLabel.Location = new System.Drawing.Point(338, 158);
            this.firstScoreLabel.Name = "firstScoreLabel";
            this.firstScoreLabel.Size = new System.Drawing.Size(123, 29);
            this.firstScoreLabel.TabIndex = 7;
            this.firstScoreLabel.Text = "Eredmény";
            // 
            // firstTeamScoreLabel
            // 
            this.firstTeamScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.firstTeamScoreLabel.ForeColor = System.Drawing.Color.Green;
            this.firstTeamScoreLabel.Location = new System.Drawing.Point(467, 155);
            this.firstTeamScoreLabel.Name = "firstTeamScoreLabel";
            this.firstTeamScoreLabel.Size = new System.Drawing.Size(100, 35);
            this.firstTeamScoreLabel.TabIndex = 8;
            // 
            // secondTeamScoreLabel
            // 
            this.secondTeamScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.secondTeamScoreLabel.ForeColor = System.Drawing.Color.Green;
            this.secondTeamScoreLabel.Location = new System.Drawing.Point(467, 338);
            this.secondTeamScoreLabel.Name = "secondTeamScoreLabel";
            this.secondTeamScoreLabel.Size = new System.Drawing.Size(100, 35);
            this.secondTeamScoreLabel.TabIndex = 11;
            // 
            // secondScoreLabel
            // 
            this.secondScoreLabel.AutoSize = true;
            this.secondScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.secondScoreLabel.ForeColor = System.Drawing.Color.Green;
            this.secondScoreLabel.Location = new System.Drawing.Point(338, 341);
            this.secondScoreLabel.Name = "secondScoreLabel";
            this.secondScoreLabel.Size = new System.Drawing.Size(123, 29);
            this.secondScoreLabel.TabIndex = 10;
            this.secondScoreLabel.Text = "Eredmény";
            // 
            // secondTeamNameLabel
            // 
            this.secondTeamNameLabel.AutoSize = true;
            this.secondTeamNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.secondTeamNameLabel.ForeColor = System.Drawing.Color.Green;
            this.secondTeamNameLabel.Location = new System.Drawing.Point(340, 297);
            this.secondTeamNameLabel.Name = "secondTeamNameLabel";
            this.secondTeamNameLabel.Size = new System.Drawing.Size(121, 29);
            this.secondTeamNameLabel.TabIndex = 9;
            this.secondTeamNameLabel.Text = "<vendég>";
            // 
            // vsLabel
            // 
            this.vsLabel.AutoSize = true;
            this.vsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vsLabel.ForeColor = System.Drawing.Color.Green;
            this.vsLabel.Location = new System.Drawing.Point(353, 234);
            this.vsLabel.Name = "vsLabel";
            this.vsLabel.Size = new System.Drawing.Size(82, 25);
            this.vsLabel.TabIndex = 12;
            this.vsLabel.Text = "---VS---";
            // 
            // scoreButton
            // 
            this.scoreButton.BackColor = System.Drawing.Color.White;
            this.scoreButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.scoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.scoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.scoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scoreButton.ForeColor = System.Drawing.Color.Green;
            this.scoreButton.Location = new System.Drawing.Point(579, 234);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(133, 42);
            this.scoreButton.TabIndex = 13;
            this.scoreButton.Text = "Eredmény";
            this.scoreButton.UseVisualStyleBackColor = false;
            this.scoreButton.Click += new System.EventHandler(this.scoreButton_Click);
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(741, 463);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.vsLabel);
            this.Controls.Add(this.secondTeamScoreLabel);
            this.Controls.Add(this.secondScoreLabel);
            this.Controls.Add(this.secondTeamNameLabel);
            this.Controls.Add(this.firstTeamScoreLabel);
            this.Controls.Add(this.firstScoreLabel);
            this.Controls.Add(this.firstTeamNameLabel);
            this.Controls.Add(this.matchUpListBox);
            this.Controls.Add(this.unplayedOnlyCheckBox);
            this.Controls.Add(this.roundsComboBox);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.tournamentNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "TournamentViewerForm";
            this.Text = "Bajnokság Eredmények";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label tournamentNameLabel;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.ComboBox roundsComboBox;
        private System.Windows.Forms.CheckBox unplayedOnlyCheckBox;
        private System.Windows.Forms.ListBox matchUpListBox;
        private System.Windows.Forms.Label firstTeamNameLabel;
        private System.Windows.Forms.Label firstScoreLabel;
        private System.Windows.Forms.TextBox firstTeamScoreLabel;
        private System.Windows.Forms.TextBox secondTeamScoreLabel;
        private System.Windows.Forms.Label secondScoreLabel;
        private System.Windows.Forms.Label secondTeamNameLabel;
        private System.Windows.Forms.Label vsLabel;
        private System.Windows.Forms.Button scoreButton;
    }
}