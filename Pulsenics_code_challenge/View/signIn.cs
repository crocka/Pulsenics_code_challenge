using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pulsenics_code_challenge
{
    public partial class signIn : Form
    {
        public signIn()
        {
            InitializeComponent();
            
        }
       
        public static User CurrentUser { get; set; }

        private void signInButton_Click(object sender, EventArgs e)
        {

            try
            {
                //if email exists in database, go to main page
                var user = Program._dbContext.Users?.Where(user => user.Email == emailInput.Text).First();

                CurrentUser = user;

                MessageBox.Show($"Welcome back, {user?.Name}!");
                main mainPage = new();
                mainPage.Show();
                this.Hide();

            }
            catch(Exception ex)
            {
                //if not, go back to signUp page
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
