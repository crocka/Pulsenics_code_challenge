namespace Pulsenics_code_challenge
{
    public partial class signUp : Form
    {
        public signUp()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void nameInput_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(nameInput.Text);
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            // save user to database

            try
            {

                if(string.IsNullOrEmpty(nameInput.Text))
                {
                    MessageBox.Show("Please enter your name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nameInput.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(emailInput.Text))
                {
                    MessageBox.Show("Please enter your email.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    emailInput.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(phoneInput.Text))
                {
                    MessageBox.Show("Please enter your phone number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    phoneInput.Focus();
                    return;
                }

                User user = new();

                user.Name = nameInput.Text;
                user.Email = emailInput.Text;
                user.Phone = phoneInput.Text;

                Program._dbContext.Users.Add(user);
                Program._dbContext.SaveChanges();

                if(Program._dbContext.SaveChanges() == 0)
                {
                    
                    MessageBox.Show("User saved. Thank you for joining.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    signIn.CurrentUser = user;

                    main mainPage = new main();
                    mainPage.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Unable to continue.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void signInLabel_Click(object sender, EventArgs e)
        {

        }

        private void goToSignInButton_Click(object sender, EventArgs e)
        {
            //Application.Run(new sign());

            signIn signInForm = new();
            signInForm.Show();
            this.Hide();
        }

        private void emailInput_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(emailInput.Text);

        }

        private void phoneInput_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(phoneInput.Text);
        }

        private void signUp_Load(object sender, EventArgs e)
        {

        }
    }
}