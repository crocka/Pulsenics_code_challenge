namespace Pulsenics_code_challenge
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
            this.fileList = new System.Windows.Forms.ListBox();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.fileCreateTime = new System.Windows.Forms.Label();
            this.fileUpdateTime = new System.Windows.Forms.Label();
            this.searchInput = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.userList = new System.Windows.Forms.ListBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.currentUserLabel = new System.Windows.Forms.Label();
            this.editUserButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fileList
            // 
            this.fileList.FormattingEnabled = true;
            this.fileList.ItemHeight = 31;
            this.fileList.Location = new System.Drawing.Point(47, 136);
            this.fileList.Name = "fileList";
            this.fileList.Size = new System.Drawing.Size(1034, 810);
            this.fileList.TabIndex = 0;
            this.fileList.SelectedIndexChanged += new System.EventHandler(this.fileList_SelectedIndexChanged);
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(47, 993);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(82, 31);
            this.fileNameLabel.TabIndex = 1;
            this.fileNameLabel.Text = "label1";            // 
            // fileCreateTime
            // 
            this.fileCreateTime.AutoSize = true;
            this.fileCreateTime.Location = new System.Drawing.Point(307, 993);
            this.fileCreateTime.Name = "fileCreateTime";
            this.fileCreateTime.Size = new System.Drawing.Size(82, 31);
            this.fileCreateTime.TabIndex = 2;
            this.fileCreateTime.Text = "label2";
            // 
            // fileUpdateTime
            // 
            this.fileUpdateTime.AutoSize = true;
            this.fileUpdateTime.Location = new System.Drawing.Point(608, 993);
            this.fileUpdateTime.Name = "fileUpdateTime";
            this.fileUpdateTime.Size = new System.Drawing.Size(82, 31);
            this.fileUpdateTime.TabIndex = 3;
            this.fileUpdateTime.Text = "label3";
            // 
            // searchInput
            // 
            this.searchInput.Location = new System.Drawing.Point(47, 26);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(1185, 38);
            this.searchInput.TabIndex = 4;
            this.searchInput.TextChanged += new System.EventHandler(this.searchInput_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(1281, 26);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(150, 46);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // userList
            // 
            this.userList.FormattingEnabled = true;
            this.userList.ItemHeight = 31;
            this.userList.Location = new System.Drawing.Point(1128, 136);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(303, 810);
            this.userList.TabIndex = 6;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(1230, 993);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(82, 31);
            this.userLabel.TabIndex = 7;
            this.userLabel.Text = "label3";
            // 
            // currentUserLabel
            // 
            this.currentUserLabel.AutoSize = true;
            this.currentUserLabel.Location = new System.Drawing.Point(1128, 949);
            this.currentUserLabel.Name = "currentUserLabel";
            this.currentUserLabel.Size = new System.Drawing.Size(285, 31);
            this.currentUserLabel.TabIndex = 8;
            this.currentUserLabel.Text = "Currently Logged in as: ";
            // 
            // editUserButton
            // 
            this.editUserButton.Location = new System.Drawing.Point(931, 978);
            this.editUserButton.Name = "editUserButton";
            this.editUserButton.Size = new System.Drawing.Size(150, 46);
            this.editUserButton.TabIndex = 9;
            this.editUserButton.Text = "Edit User";
            this.editUserButton.UseVisualStyleBackColor = true;
            this.editUserButton.Click += new System.EventHandler(this.editUserButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "List of All Files";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1128, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "List of Users";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 1045);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editUserButton);
            this.Controls.Add(this.currentUserLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.userList);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchInput);
            this.Controls.Add(this.fileUpdateTime);
            this.Controls.Add(this.fileCreateTime);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.fileList);
            this.Name = "main";
            this.Text = "main";
            this.Load += new System.EventHandler(this.main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public ListBox fileList;
        private Label fileNameLabel;
        private Label fileCreateTime;
        private Label fileUpdateTime;
        private TextBox searchInput;
        private Button searchButton;
        private ListBox userList;
        private Label userLabel;
        private Label currentUserLabel;
        private Button editUserButton;
        private Label label1;
        private Label label2;
    }
}