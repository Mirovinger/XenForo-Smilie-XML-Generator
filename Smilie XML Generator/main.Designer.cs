namespace Smilie_XML_Generator
{
    partial class main
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
            this.smilieFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.folderPathText = new MetroFramework.Controls.MetroTextBox();
            this.oneLabel = new MetroFramework.Controls.MetroLabel();
            this.openFolderButton = new MetroFramework.Controls.MetroButton();
            this.twoLabel = new MetroFramework.Controls.MetroLabel();
            this.stepDescription = new MetroFramework.Controls.MetroTextBox();
            this.charText = new MetroFramework.Controls.MetroTextBox();
            this.goToStepThree = new MetroFramework.Controls.MetroButton();
            this.xmlOutput = new System.Windows.Forms.FolderBrowserDialog();
            this.xmlFolder = new MetroFramework.Controls.MetroButton();
            this.threeLabel = new MetroFramework.Controls.MetroLabel();
            this.xmlFolderPath = new MetroFramework.Controls.MetroTextBox();
            this.generate = new MetroFramework.Controls.MetroButton();
            this.goButton = new MetroFramework.Controls.MetroButton();
            this.fourLabel = new MetroFramework.Controls.MetroLabel();
            this.serverPathTextBox = new MetroFramework.Controls.MetroTextBox();
            this.matthDevLink = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // smilieFolder
            // 
            this.smilieFolder.ShowNewFolderButton = false;
            // 
            // folderPathText
            // 
            this.folderPathText.Lines = new string[] {
        "Please choose a folder with the smilies..."};
            this.folderPathText.Location = new System.Drawing.Point(48, 60);
            this.folderPathText.MaxLength = 32767;
            this.folderPathText.Name = "folderPathText";
            this.folderPathText.PasswordChar = '\0';
            this.folderPathText.ReadOnly = true;
            this.folderPathText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.folderPathText.SelectedText = "";
            this.folderPathText.Size = new System.Drawing.Size(313, 23);
            this.folderPathText.Style = MetroFramework.MetroColorStyle.Blue;
            this.folderPathText.TabIndex = 0;
            this.folderPathText.Text = "Please choose a folder with the smilies...";
            this.folderPathText.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.folderPathText.UseSelectable = true;
            // 
            // oneLabel
            // 
            this.oneLabel.AutoSize = true;
            this.oneLabel.Location = new System.Drawing.Point(23, 60);
            this.oneLabel.Name = "oneLabel";
            this.oneLabel.Size = new System.Drawing.Size(19, 19);
            this.oneLabel.TabIndex = 1;
            this.oneLabel.Text = "1.";
            this.oneLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // openFolderButton
            // 
            this.openFolderButton.Location = new System.Drawing.Point(367, 60);
            this.openFolderButton.Name = "openFolderButton";
            this.openFolderButton.Size = new System.Drawing.Size(100, 23);
            this.openFolderButton.TabIndex = 2;
            this.openFolderButton.Text = "Open Folder...";
            this.openFolderButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.openFolderButton.UseSelectable = true;
            this.openFolderButton.Click += new System.EventHandler(this.openFolderButton_Click);
            // 
            // twoLabel
            // 
            this.twoLabel.AutoSize = true;
            this.twoLabel.Location = new System.Drawing.Point(23, 89);
            this.twoLabel.Name = "twoLabel";
            this.twoLabel.Size = new System.Drawing.Size(19, 19);
            this.twoLabel.TabIndex = 3;
            this.twoLabel.Text = "2.";
            this.twoLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.twoLabel.Visible = false;
            // 
            // stepDescription
            // 
            this.stepDescription.Lines = new string[] {
        "Step Descriptions"};
            this.stepDescription.Location = new System.Drawing.Point(473, 60);
            this.stepDescription.MaxLength = 32767;
            this.stepDescription.Multiline = true;
            this.stepDescription.Name = "stepDescription";
            this.stepDescription.PasswordChar = '\0';
            this.stepDescription.ReadOnly = true;
            this.stepDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.stepDescription.SelectedText = "";
            this.stepDescription.Size = new System.Drawing.Size(177, 250);
            this.stepDescription.TabIndex = 4;
            this.stepDescription.Text = "Step Descriptions";
            this.stepDescription.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.stepDescription.UseSelectable = true;
            // 
            // charText
            // 
            this.charText.Lines = new string[] {
        "@"};
            this.charText.Location = new System.Drawing.Point(48, 89);
            this.charText.MaxLength = 32767;
            this.charText.Name = "charText";
            this.charText.PasswordChar = '\0';
            this.charText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.charText.SelectedText = "";
            this.charText.Size = new System.Drawing.Size(26, 23);
            this.charText.TabIndex = 5;
            this.charText.Text = "@";
            this.charText.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.charText.UseSelectable = true;
            this.charText.Visible = false;
            // 
            // goToStepThree
            // 
            this.goToStepThree.Location = new System.Drawing.Point(367, 88);
            this.goToStepThree.Name = "goToStepThree";
            this.goToStepThree.Size = new System.Drawing.Size(100, 23);
            this.goToStepThree.TabIndex = 6;
            this.goToStepThree.Text = "Next Step...";
            this.goToStepThree.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.goToStepThree.UseSelectable = true;
            this.goToStepThree.Visible = false;
            this.goToStepThree.Click += new System.EventHandler(this.goToStepThree_Click);
            // 
            // xmlFolder
            // 
            this.xmlFolder.Location = new System.Drawing.Point(367, 118);
            this.xmlFolder.Name = "xmlFolder";
            this.xmlFolder.Size = new System.Drawing.Size(100, 23);
            this.xmlFolder.TabIndex = 9;
            this.xmlFolder.Text = "Open Folder...";
            this.xmlFolder.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.xmlFolder.UseSelectable = true;
            this.xmlFolder.Visible = false;
            this.xmlFolder.Click += new System.EventHandler(this.xmlFolder_Click);
            // 
            // threeLabel
            // 
            this.threeLabel.AutoSize = true;
            this.threeLabel.Location = new System.Drawing.Point(23, 118);
            this.threeLabel.Name = "threeLabel";
            this.threeLabel.Size = new System.Drawing.Size(19, 19);
            this.threeLabel.TabIndex = 8;
            this.threeLabel.Text = "3.";
            this.threeLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.threeLabel.Visible = false;
            // 
            // xmlFolderPath
            // 
            this.xmlFolderPath.Lines = new string[] {
        "Please choose a folder to place the XML..."};
            this.xmlFolderPath.Location = new System.Drawing.Point(48, 118);
            this.xmlFolderPath.MaxLength = 32767;
            this.xmlFolderPath.Name = "xmlFolderPath";
            this.xmlFolderPath.PasswordChar = '\0';
            this.xmlFolderPath.ReadOnly = true;
            this.xmlFolderPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.xmlFolderPath.SelectedText = "";
            this.xmlFolderPath.Size = new System.Drawing.Size(313, 23);
            this.xmlFolderPath.Style = MetroFramework.MetroColorStyle.Blue;
            this.xmlFolderPath.TabIndex = 7;
            this.xmlFolderPath.Text = "Please choose a folder to place the XML...";
            this.xmlFolderPath.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.xmlFolderPath.UseSelectable = true;
            this.xmlFolderPath.Visible = false;
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(367, 287);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(99, 23);
            this.generate.TabIndex = 10;
            this.generate.Text = "Generate XML";
            this.generate.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.generate.UseSelectable = true;
            this.generate.Visible = false;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(367, 147);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(100, 23);
            this.goButton.TabIndex = 13;
            this.goButton.Text = "Ready to Go...";
            this.goButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.goButton.UseSelectable = true;
            this.goButton.Visible = false;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // fourLabel
            // 
            this.fourLabel.AutoSize = true;
            this.fourLabel.Location = new System.Drawing.Point(23, 147);
            this.fourLabel.Name = "fourLabel";
            this.fourLabel.Size = new System.Drawing.Size(19, 19);
            this.fourLabel.TabIndex = 12;
            this.fourLabel.Text = "4.";
            this.fourLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.fourLabel.Visible = false;
            // 
            // serverPathTextBox
            // 
            this.serverPathTextBox.Lines = new string[] {
        "Location of smilies..."};
            this.serverPathTextBox.Location = new System.Drawing.Point(48, 147);
            this.serverPathTextBox.MaxLength = 32767;
            this.serverPathTextBox.Name = "serverPathTextBox";
            this.serverPathTextBox.PasswordChar = '\0';
            this.serverPathTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.serverPathTextBox.SelectedText = "";
            this.serverPathTextBox.Size = new System.Drawing.Size(313, 23);
            this.serverPathTextBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.serverPathTextBox.TabIndex = 11;
            this.serverPathTextBox.Text = "Location of smilies...";
            this.serverPathTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.serverPathTextBox.UseSelectable = true;
            this.serverPathTextBox.Visible = false;
            // 
            // matthDevLink
            // 
            this.matthDevLink.Location = new System.Drawing.Point(23, 287);
            this.matthDevLink.Name = "matthDevLink";
            this.matthDevLink.Size = new System.Drawing.Size(156, 23);
            this.matthDevLink.TabIndex = 14;
            this.matthDevLink.Text = "Matthew H Development";
            this.matthDevLink.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.matthDevLink.UseSelectable = true;
            this.matthDevLink.Click += new System.EventHandler(this.matthDevLink_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 333);
            this.Controls.Add(this.matthDevLink);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.fourLabel);
            this.Controls.Add(this.serverPathTextBox);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.xmlFolder);
            this.Controls.Add(this.threeLabel);
            this.Controls.Add(this.xmlFolderPath);
            this.Controls.Add(this.goToStepThree);
            this.Controls.Add(this.charText);
            this.Controls.Add(this.stepDescription);
            this.Controls.Add(this.twoLabel);
            this.Controls.Add(this.openFolderButton);
            this.Controls.Add(this.oneLabel);
            this.Controls.Add(this.folderPathText);
            this.MaximizeBox = false;
            this.Name = "main";
            this.Resizable = false;
            this.ShowIcon = false;
            this.Text = "XenForo Smilie XML Generator";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog smilieFolder;
        private MetroFramework.Controls.MetroTextBox folderPathText;
        private MetroFramework.Controls.MetroLabel oneLabel;
        private MetroFramework.Controls.MetroButton openFolderButton;
        private MetroFramework.Controls.MetroLabel twoLabel;
        private MetroFramework.Controls.MetroTextBox stepDescription;
        private MetroFramework.Controls.MetroTextBox charText;
        private MetroFramework.Controls.MetroButton goToStepThree;
        private System.Windows.Forms.FolderBrowserDialog xmlOutput;
        private MetroFramework.Controls.MetroButton xmlFolder;
        private MetroFramework.Controls.MetroLabel threeLabel;
        private MetroFramework.Controls.MetroTextBox xmlFolderPath;
        private MetroFramework.Controls.MetroButton generate;
        private MetroFramework.Controls.MetroButton goButton;
        private MetroFramework.Controls.MetroLabel fourLabel;
        private MetroFramework.Controls.MetroTextBox serverPathTextBox;
        private MetroFramework.Controls.MetroLink matthDevLink;

    }
}

