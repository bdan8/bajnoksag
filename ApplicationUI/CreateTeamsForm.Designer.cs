namespace ApplicationUI
{
    partial class CreateTeamsForm
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
            this.teamNameValue = new System.Windows.Forms.TextBox();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.selectTeamMemberComboBox = new System.Windows.Forms.ComboBox();
            this.addTeamMemberButton = new System.Windows.Forms.Button();
            this.selectTeamMemberLabel = new System.Windows.Forms.Label();
            this.memberGroupBox = new System.Windows.Forms.GroupBox();
            this.createMemeberButton = new System.Windows.Forms.Button();
            this.cellphoneValue = new System.Windows.Forms.TextBox();
            this.cellphoneLabel = new System.Windows.Forms.Label();
            this.emailValue = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastNameValue = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameValue = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.teamMemeberListBox = new System.Windows.Forms.ListBox();
            this.removeSelectedMember = new System.Windows.Forms.Button();
            this.createTeamButton = new System.Windows.Forms.Button();
            this.memberGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // teamNameValue
            // 
            this.teamNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teamNameValue.ForeColor = System.Drawing.Color.Green;
            this.teamNameValue.Location = new System.Drawing.Point(51, 106);
            this.teamNameValue.Name = "teamNameValue";
            this.teamNameValue.Size = new System.Drawing.Size(317, 35);
            this.teamNameValue.TabIndex = 13;
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teamNameLabel.ForeColor = System.Drawing.Color.Green;
            this.teamNameLabel.Location = new System.Drawing.Point(46, 74);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(151, 29);
            this.teamNameLabel.TabIndex = 12;
            this.teamNameLabel.Text = "Csapat Neve";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.ForeColor = System.Drawing.Color.Green;
            this.headerLabel.Location = new System.Drawing.Point(23, 25);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(275, 33);
            this.headerLabel.TabIndex = 11;
            this.headerLabel.Text = "Csapat Létrehozása";
            // 
            // selectTeamMemberComboBox
            // 
            this.selectTeamMemberComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectTeamMemberComboBox.ForeColor = System.Drawing.Color.Green;
            this.selectTeamMemberComboBox.FormattingEnabled = true;
            this.selectTeamMemberComboBox.Location = new System.Drawing.Point(51, 203);
            this.selectTeamMemberComboBox.Name = "selectTeamMemberComboBox";
            this.selectTeamMemberComboBox.Size = new System.Drawing.Size(317, 33);
            this.selectTeamMemberComboBox.TabIndex = 28;
            // 
            // addTeamMemberButton
            // 
            this.addTeamMemberButton.BackColor = System.Drawing.Color.White;
            this.addTeamMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addTeamMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addTeamMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addTeamMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamMemberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addTeamMemberButton.ForeColor = System.Drawing.Color.Green;
            this.addTeamMemberButton.Location = new System.Drawing.Point(79, 253);
            this.addTeamMemberButton.Name = "addTeamMemberButton";
            this.addTeamMemberButton.Size = new System.Drawing.Size(261, 42);
            this.addTeamMemberButton.TabIndex = 27;
            this.addTeamMemberButton.Text = "Csapattag Hozzáadása";
            this.addTeamMemberButton.UseVisualStyleBackColor = false;
            this.addTeamMemberButton.Click += new System.EventHandler(this.addTeamMemberButton_Click);
            // 
            // selectTeamMemberLabel
            // 
            this.selectTeamMemberLabel.AutoSize = true;
            this.selectTeamMemberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectTeamMemberLabel.ForeColor = System.Drawing.Color.Green;
            this.selectTeamMemberLabel.Location = new System.Drawing.Point(46, 171);
            this.selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            this.selectTeamMemberLabel.Size = new System.Drawing.Size(259, 29);
            this.selectTeamMemberLabel.TabIndex = 26;
            this.selectTeamMemberLabel.Text = "Csapattag Kiválasztása";
            // 
            // memberGroupBox
            // 
            this.memberGroupBox.Controls.Add(this.createMemeberButton);
            this.memberGroupBox.Controls.Add(this.cellphoneValue);
            this.memberGroupBox.Controls.Add(this.cellphoneLabel);
            this.memberGroupBox.Controls.Add(this.emailValue);
            this.memberGroupBox.Controls.Add(this.emailLabel);
            this.memberGroupBox.Controls.Add(this.lastNameValue);
            this.memberGroupBox.Controls.Add(this.lastNameLabel);
            this.memberGroupBox.Controls.Add(this.firstNameValue);
            this.memberGroupBox.Controls.Add(this.firstNameLabel);
            this.memberGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.memberGroupBox.ForeColor = System.Drawing.Color.Green;
            this.memberGroupBox.Location = new System.Drawing.Point(51, 321);
            this.memberGroupBox.Name = "memberGroupBox";
            this.memberGroupBox.Size = new System.Drawing.Size(317, 274);
            this.memberGroupBox.TabIndex = 29;
            this.memberGroupBox.TabStop = false;
            this.memberGroupBox.Text = "Új Csapattag Létrehozása";
            // 
            // createMemeberButton
            // 
            this.createMemeberButton.BackColor = System.Drawing.Color.White;
            this.createMemeberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createMemeberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createMemeberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createMemeberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createMemeberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createMemeberButton.Location = new System.Drawing.Point(50, 215);
            this.createMemeberButton.Name = "createMemeberButton";
            this.createMemeberButton.Size = new System.Drawing.Size(218, 42);
            this.createMemeberButton.TabIndex = 28;
            this.createMemeberButton.Text = "Csapattag Létrehozása";
            this.createMemeberButton.UseVisualStyleBackColor = false;
            this.createMemeberButton.Click += new System.EventHandler(this.createMemeberButton_Click);
            // 
            // cellphoneValue
            // 
            this.cellphoneValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cellphoneValue.ForeColor = System.Drawing.Color.Green;
            this.cellphoneValue.Location = new System.Drawing.Point(129, 166);
            this.cellphoneValue.Name = "cellphoneValue";
            this.cellphoneValue.Size = new System.Drawing.Size(182, 29);
            this.cellphoneValue.TabIndex = 16;
            // 
            // cellphoneLabel
            // 
            this.cellphoneLabel.AutoSize = true;
            this.cellphoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cellphoneLabel.Location = new System.Drawing.Point(6, 169);
            this.cellphoneLabel.Name = "cellphoneLabel";
            this.cellphoneLabel.Size = new System.Drawing.Size(118, 24);
            this.cellphoneLabel.TabIndex = 15;
            this.cellphoneLabel.Text = "Telefonszám";
            // 
            // emailValue
            // 
            this.emailValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.emailValue.ForeColor = System.Drawing.Color.Green;
            this.emailValue.Location = new System.Drawing.Point(129, 123);
            this.emailValue.Name = "emailValue";
            this.emailValue.Size = new System.Drawing.Size(182, 29);
            this.emailValue.TabIndex = 14;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.emailLabel.Location = new System.Drawing.Point(6, 126);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(57, 24);
            this.emailLabel.TabIndex = 13;
            this.emailLabel.Text = "Email";
            // 
            // lastNameValue
            // 
            this.lastNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lastNameValue.ForeColor = System.Drawing.Color.Green;
            this.lastNameValue.Location = new System.Drawing.Point(129, 80);
            this.lastNameValue.Name = "lastNameValue";
            this.lastNameValue.Size = new System.Drawing.Size(182, 29);
            this.lastNameValue.TabIndex = 12;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lastNameLabel.Location = new System.Drawing.Point(6, 83);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(103, 24);
            this.lastNameLabel.TabIndex = 11;
            this.lastNameLabel.Text = "Keresztnév";
            // 
            // firstNameValue
            // 
            this.firstNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.firstNameValue.ForeColor = System.Drawing.Color.Green;
            this.firstNameValue.Location = new System.Drawing.Point(129, 37);
            this.firstNameValue.Name = "firstNameValue";
            this.firstNameValue.Size = new System.Drawing.Size(182, 29);
            this.firstNameValue.TabIndex = 10;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.firstNameLabel.Location = new System.Drawing.Point(6, 40);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(109, 24);
            this.firstNameLabel.TabIndex = 9;
            this.firstNameLabel.Text = "Vezetéknév";
            // 
            // teamMemeberListBox
            // 
            this.teamMemeberListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teamMemeberListBox.ForeColor = System.Drawing.Color.Green;
            this.teamMemeberListBox.FormattingEnabled = true;
            this.teamMemeberListBox.ItemHeight = 24;
            this.teamMemeberListBox.Location = new System.Drawing.Point(438, 94);
            this.teamMemeberListBox.Name = "teamMemeberListBox";
            this.teamMemeberListBox.Size = new System.Drawing.Size(277, 484);
            this.teamMemeberListBox.TabIndex = 30;
            // 
            // removeSelectedMember
            // 
            this.removeSelectedMember.BackColor = System.Drawing.Color.White;
            this.removeSelectedMember.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.removeSelectedMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.removeSelectedMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.removeSelectedMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSelectedMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.removeSelectedMember.ForeColor = System.Drawing.Color.Green;
            this.removeSelectedMember.Location = new System.Drawing.Point(730, 279);
            this.removeSelectedMember.Name = "removeSelectedMember";
            this.removeSelectedMember.Size = new System.Drawing.Size(140, 106);
            this.removeSelectedMember.TabIndex = 31;
            this.removeSelectedMember.Text = "Kiválasztott Törlése";
            this.removeSelectedMember.UseVisualStyleBackColor = false;
            this.removeSelectedMember.Click += new System.EventHandler(this.deleteSelectedMember_Click);
            // 
            // createTeamButton
            // 
            this.createTeamButton.BackColor = System.Drawing.Color.White;
            this.createTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTeamButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createTeamButton.ForeColor = System.Drawing.Color.Green;
            this.createTeamButton.Location = new System.Drawing.Point(352, 622);
            this.createTeamButton.Name = "createTeamButton";
            this.createTeamButton.Size = new System.Drawing.Size(196, 42);
            this.createTeamButton.TabIndex = 32;
            this.createTeamButton.Text = "Csapat Létrehozása";
            this.createTeamButton.UseVisualStyleBackColor = false;
            this.createTeamButton.Click += new System.EventHandler(this.createTeamButton_Click);
            // 
            // CreateTeamsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 676);
            this.Controls.Add(this.createTeamButton);
            this.Controls.Add(this.removeSelectedMember);
            this.Controls.Add(this.teamMemeberListBox);
            this.Controls.Add(this.memberGroupBox);
            this.Controls.Add(this.selectTeamMemberComboBox);
            this.Controls.Add(this.addTeamMemberButton);
            this.Controls.Add(this.selectTeamMemberLabel);
            this.Controls.Add(this.teamNameValue);
            this.Controls.Add(this.teamNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "CreateTeamsForm";
            this.Text = "Csapat Létrehozása";
            this.memberGroupBox.ResumeLayout(false);
            this.memberGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox teamNameValue;
        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.ComboBox selectTeamMemberComboBox;
        private System.Windows.Forms.Button addTeamMemberButton;
        private System.Windows.Forms.Label selectTeamMemberLabel;
        private System.Windows.Forms.GroupBox memberGroupBox;
        private System.Windows.Forms.TextBox firstNameValue;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Button createMemeberButton;
        private System.Windows.Forms.TextBox cellphoneValue;
        private System.Windows.Forms.Label cellphoneLabel;
        private System.Windows.Forms.TextBox emailValue;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox lastNameValue;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.ListBox teamMemeberListBox;
        private System.Windows.Forms.Button removeSelectedMember;
        private System.Windows.Forms.Button createTeamButton;
    }
}