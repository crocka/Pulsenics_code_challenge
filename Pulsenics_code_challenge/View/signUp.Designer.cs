namespace Pulsenics_code_challenge
{
    partial class signUp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.phoneInput = new System.Windows.Forms.TextBox();
            this.signUpButton = new System.Windows.Forms.Button();
            this.signInLabel = new System.Windows.Forms.Label();
            this.goToSignInButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(93, 89);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(83, 31);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(93, 150);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(74, 31);
            this.emailLabel.TabIndex = 1;
            this.emailLabel.Text = "Email";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(93, 218);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(88, 31);
            this.phoneLabel.TabIndex = 2;
            this.phoneLabel.Text = "Phone";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(212, 89);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(455, 38);
            this.nameInput.TabIndex = 3;
            this.nameInput.Text = "t";
            this.nameInput.TextChanged += new System.EventHandler(this.nameInput_TextChanged);
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(212, 150);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(455, 38);
            this.emailInput.TabIndex = 4;
            this.emailInput.TextChanged += new System.EventHandler(this.emailInput_TextChanged);
            // 
            // phoneInput
            // 
            this.phoneInput.Location = new System.Drawing.Point(212, 211);
            this.phoneInput.Name = "phoneInput";
            this.phoneInput.Size = new System.Drawing.Size(455, 38);
            this.phoneInput.TabIndex = 5;
            this.phoneInput.TextChanged += new System.EventHandler(this.phoneInput_TextChanged);
            // 
            // signUpButton
            // 
            this.signUpButton.Location = new System.Drawing.Point(226, 290);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(150, 46);
            this.signUpButton.TabIndex = 6;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // signInLabel
            // 
            this.signInLabel.AutoSize = true;
            this.signInLabel.Location = new System.Drawing.Point(117, 385);
            this.signInLabel.Name = "signInLabel";
            this.signInLabel.Size = new System.Drawing.Size(308, 31);
            this.signInLabel.TabIndex = 7;
            this.signInLabel.Text = "Already have an account?";
            this.signInLabel.Click += new System.EventHandler(this.signInLabel_Click);
            // 
            // goToSignInButton
            // 
            this.goToSignInButton.Location = new System.Drawing.Point(431, 377);
            this.goToSignInButton.Name = "goToSignInButton";
            this.goToSignInButton.Size = new System.Drawing.Size(236, 46);
            this.goToSignInButton.TabIndex = 8;
            this.goToSignInButton.Text = "Go to sign in";
            this.goToSignInButton.UseVisualStyleBackColor = true;
            this.goToSignInButton.Click += new System.EventHandler(this.goToSignInButton_Click);
            // 
            // signUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 497);
            this.Controls.Add(this.goToSignInButton);
            this.Controls.Add(this.signInLabel);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.phoneInput);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "signUp";
            this.Load += new System.EventHandler(this.signUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label nameLabel;
        private Label emailLabel;
        private Label phoneLabel;
        private FileSystemWatcher fileSystemWatcher1;
        private TextBox nameInput;
        private TextBox phoneInput;
        private TextBox emailInput;
        private Button signUpButton;
        private Label signInLabel;
        private Button goToSignInButton;
    }
}