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
            this.createTeamLabel = new System.Windows.Forms.Label();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.teamNameValueTextbox = new System.Windows.Forms.TextBox();
            this.selectTeamMemberDropdownCombobox = new System.Windows.Forms.ComboBox();
            this.selectTeamMemberLabel = new System.Windows.Forms.Label();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.addNewMemberGroupbox = new System.Windows.Forms.GroupBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameValueTextbox = new System.Windows.Forms.TextBox();
            this.lastNameValueTextbox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.emailValueTextbox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.cellphoneValueTextbox = new System.Windows.Forms.TextBox();
            this.cellphoneLabel = new System.Windows.Forms.Label();
            this.createMemberButton = new System.Windows.Forms.Button();
            this.teamMembersListbox = new System.Windows.Forms.ListBox();
            this.createTeamButton = new System.Windows.Forms.Button();
            this.deleteSelectedMemberButton = new System.Windows.Forms.Button();
            this.addNewMemberGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // createTeamLabel
            // 
            this.createTeamLabel.AutoSize = true;
            this.createTeamLabel.Location = new System.Drawing.Point(12, 9);
            this.createTeamLabel.Name = "createTeamLabel";
            this.createTeamLabel.Size = new System.Drawing.Size(68, 13);
            this.createTeamLabel.TabIndex = 0;
            this.createTeamLabel.Text = "Create Team";
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Location = new System.Drawing.Point(12, 36);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(65, 13);
            this.teamNameLabel.TabIndex = 1;
            this.teamNameLabel.Text = "Team Name";
            // 
            // teamNameValueTextbox
            // 
            this.teamNameValueTextbox.Location = new System.Drawing.Point(12, 52);
            this.teamNameValueTextbox.Name = "teamNameValueTextbox";
            this.teamNameValueTextbox.Size = new System.Drawing.Size(200, 20);
            this.teamNameValueTextbox.TabIndex = 2;
            // 
            // selectTeamMemberDropdownCombobox
            // 
            this.selectTeamMemberDropdownCombobox.FormattingEnabled = true;
            this.selectTeamMemberDropdownCombobox.Location = new System.Drawing.Point(12, 91);
            this.selectTeamMemberDropdownCombobox.Name = "selectTeamMemberDropdownCombobox";
            this.selectTeamMemberDropdownCombobox.Size = new System.Drawing.Size(200, 21);
            this.selectTeamMemberDropdownCombobox.TabIndex = 3;
            // 
            // selectTeamMemberLabel
            // 
            this.selectTeamMemberLabel.AutoSize = true;
            this.selectTeamMemberLabel.Location = new System.Drawing.Point(9, 75);
            this.selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            this.selectTeamMemberLabel.Size = new System.Drawing.Size(108, 13);
            this.selectTeamMemberLabel.TabIndex = 4;
            this.selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // addMemberButton
            // 
            this.addMemberButton.Location = new System.Drawing.Point(91, 118);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(121, 23);
            this.addMemberButton.TabIndex = 5;
            this.addMemberButton.Text = "Add Member";
            this.addMemberButton.UseVisualStyleBackColor = true;
            // 
            // addNewMemberGroupbox
            // 
            this.addNewMemberGroupbox.Controls.Add(this.createMemberButton);
            this.addNewMemberGroupbox.Controls.Add(this.cellphoneValueTextbox);
            this.addNewMemberGroupbox.Controls.Add(this.cellphoneLabel);
            this.addNewMemberGroupbox.Controls.Add(this.emailValueTextbox);
            this.addNewMemberGroupbox.Controls.Add(this.emailLabel);
            this.addNewMemberGroupbox.Controls.Add(this.lastNameValueTextbox);
            this.addNewMemberGroupbox.Controls.Add(this.lastNameLabel);
            this.addNewMemberGroupbox.Controls.Add(this.firstNameValueTextbox);
            this.addNewMemberGroupbox.Controls.Add(this.firstNameLabel);
            this.addNewMemberGroupbox.Location = new System.Drawing.Point(12, 159);
            this.addNewMemberGroupbox.Name = "addNewMemberGroupbox";
            this.addNewMemberGroupbox.Size = new System.Drawing.Size(200, 160);
            this.addNewMemberGroupbox.TabIndex = 6;
            this.addNewMemberGroupbox.TabStop = false;
            this.addNewMemberGroupbox.Text = "Add New Member";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(3, 26);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.firstNameLabel.TabIndex = 7;
            this.firstNameLabel.Text = "First Name";
            // 
            // firstNameValueTextbox
            // 
            this.firstNameValueTextbox.Location = new System.Drawing.Point(79, 23);
            this.firstNameValueTextbox.Name = "firstNameValueTextbox";
            this.firstNameValueTextbox.Size = new System.Drawing.Size(115, 20);
            this.firstNameValueTextbox.TabIndex = 7;
            // 
            // lastNameValueTextbox
            // 
            this.lastNameValueTextbox.Location = new System.Drawing.Point(79, 49);
            this.lastNameValueTextbox.Name = "lastNameValueTextbox";
            this.lastNameValueTextbox.Size = new System.Drawing.Size(115, 20);
            this.lastNameValueTextbox.TabIndex = 8;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(3, 52);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.lastNameLabel.TabIndex = 9;
            this.lastNameLabel.Text = "Last Name";
            // 
            // emailValueTextbox
            // 
            this.emailValueTextbox.Location = new System.Drawing.Point(79, 75);
            this.emailValueTextbox.Name = "emailValueTextbox";
            this.emailValueTextbox.Size = new System.Drawing.Size(115, 20);
            this.emailValueTextbox.TabIndex = 10;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(3, 78);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(32, 13);
            this.emailLabel.TabIndex = 11;
            this.emailLabel.Text = "Email";
            // 
            // cellphoneValueTextbox
            // 
            this.cellphoneValueTextbox.Location = new System.Drawing.Point(79, 101);
            this.cellphoneValueTextbox.Name = "cellphoneValueTextbox";
            this.cellphoneValueTextbox.Size = new System.Drawing.Size(115, 20);
            this.cellphoneValueTextbox.TabIndex = 12;
            // 
            // cellphoneLabel
            // 
            this.cellphoneLabel.AutoSize = true;
            this.cellphoneLabel.Location = new System.Drawing.Point(3, 104);
            this.cellphoneLabel.Name = "cellphoneLabel";
            this.cellphoneLabel.Size = new System.Drawing.Size(54, 13);
            this.cellphoneLabel.TabIndex = 13;
            this.cellphoneLabel.Text = "Cellphone";
            // 
            // createMemberButton
            // 
            this.createMemberButton.Location = new System.Drawing.Point(79, 127);
            this.createMemberButton.Name = "createMemberButton";
            this.createMemberButton.Size = new System.Drawing.Size(115, 23);
            this.createMemberButton.TabIndex = 7;
            this.createMemberButton.Text = "Create Member";
            this.createMemberButton.UseVisualStyleBackColor = true;
            // 
            // teamMembersListbox
            // 
            this.teamMembersListbox.FormattingEnabled = true;
            this.teamMembersListbox.Location = new System.Drawing.Point(222, 91);
            this.teamMembersListbox.Name = "teamMembersListbox";
            this.teamMembersListbox.Size = new System.Drawing.Size(163, 186);
            this.teamMembersListbox.TabIndex = 7;
            // 
            // createTeamButton
            // 
            this.createTeamButton.Location = new System.Drawing.Point(222, 286);
            this.createTeamButton.Name = "createTeamButton";
            this.createTeamButton.Size = new System.Drawing.Size(162, 33);
            this.createTeamButton.TabIndex = 8;
            this.createTeamButton.Text = "Create Team";
            this.createTeamButton.UseVisualStyleBackColor = true;
            // 
            // deleteSelectedMemberButton
            // 
            this.deleteSelectedMemberButton.Location = new System.Drawing.Point(263, 52);
            this.deleteSelectedMemberButton.Name = "deleteSelectedMemberButton";
            this.deleteSelectedMemberButton.Size = new System.Drawing.Size(121, 23);
            this.deleteSelectedMemberButton.TabIndex = 9;
            this.deleteSelectedMemberButton.Text = "Delete Member";
            this.deleteSelectedMemberButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 337);
            this.Controls.Add(this.deleteSelectedMemberButton);
            this.Controls.Add(this.createTeamButton);
            this.Controls.Add(this.teamMembersListbox);
            this.Controls.Add(this.addNewMemberGroupbox);
            this.Controls.Add(this.addMemberButton);
            this.Controls.Add(this.selectTeamMemberLabel);
            this.Controls.Add(this.selectTeamMemberDropdownCombobox);
            this.Controls.Add(this.teamNameValueTextbox);
            this.Controls.Add(this.teamNameLabel);
            this.Controls.Add(this.createTeamLabel);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.addNewMemberGroupbox.ResumeLayout(false);
            this.addNewMemberGroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createTeamLabel;
        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.TextBox teamNameValueTextbox;
        private System.Windows.Forms.ComboBox selectTeamMemberDropdownCombobox;
        private System.Windows.Forms.Label selectTeamMemberLabel;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.GroupBox addNewMemberGroupbox;
        private System.Windows.Forms.TextBox firstNameValueTextbox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox cellphoneValueTextbox;
        private System.Windows.Forms.Label cellphoneLabel;
        private System.Windows.Forms.TextBox emailValueTextbox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox lastNameValueTextbox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Button createMemberButton;
        private System.Windows.Forms.ListBox teamMembersListbox;
        private System.Windows.Forms.Button createTeamButton;
        private System.Windows.Forms.Button deleteSelectedMemberButton;
    }
}