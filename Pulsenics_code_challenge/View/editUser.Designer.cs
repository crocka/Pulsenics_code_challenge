namespace Pulsenics_code_challenge {
    partial class editUser
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
            this.saveButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.phoneInput = new System.Windows.Forms.TextBox();
            this.fileList = new System.Windows.Forms.ListBox();
            this.addedFileList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(279, 295);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(150, 46);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(98, 58);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(83, 31);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phone";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(203, 52);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(307, 38);
            this.nameInput.TabIndex = 4;
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(203, 131);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(307, 38);
            this.emailInput.TabIndex = 5;
            // 
            // phoneInput
            // 
            this.phoneInput.Location = new System.Drawing.Point(203, 212);
            this.phoneInput.Name = "phoneInput";
            this.phoneInput.Size = new System.Drawing.Size(307, 38);
            this.phoneInput.TabIndex = 6;
            // 
            // fileList
            // 
            this.fileList.FormattingEnabled = true;
            this.fileList.ItemHeight = 31;
            this.fileList.Location = new System.Drawing.Point(581, 85);
            this.fileList.Name = "fileList";
            this.fileList.Size = new System.Drawing.Size(193, 562);
            this.fileList.TabIndex = 7;
            this.fileList.SelectedIndexChanged += new System.EventHandler(this.fileList_SelectedIndexChanged);
            // 
            // addedFileList
            // 
            this.addedFileList.FormattingEnabled = true;
            this.addedFileList.ItemHeight = 31;
            this.addedFileList.Location = new System.Drawing.Point(798, 85);
            this.addedFileList.Name = "addedFileList";
            this.addedFileList.Size = new System.Drawing.Size(192, 562);
            this.addedFileList.TabIndex = 8;
            this.addedFileList.SelectedIndexChanged += new System.EventHandler(this.addedFileList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(581, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "List of All Files";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(798, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "My Files";
            // 
            // editUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 719);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addedFileList);
            this.Controls.Add(this.fileList);
            this.Controls.Add(this.phoneInput);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.saveButton);
            this.Name = "editUser";
            this.Text = "editUser";
            this.Load += new System.EventHandler(this.editUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button saveButton;
        private Label nameLabel;
        private Label label2;
        private Label label3;
        private TextBox nameInput;
        private TextBox emailInput;
        private TextBox phoneInput;
        private ListBox fileList;
        private ListBox addedFileList;
        private Label label1;
        private Label label4;
    }
}