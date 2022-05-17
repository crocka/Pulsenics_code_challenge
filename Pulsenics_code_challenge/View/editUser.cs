using System.Data;

namespace Pulsenics_code_challenge
{
    public partial class editUser : Form
    {
        //public static List<User_file> user_files = Program._dbContext.User_files?.Where(User_file => User_file.UserId == signIn.CurrentUser.Id).ToList();

        public List<File> savedFiles = Program.FindFilesFromUserId(signIn.CurrentUser.Id);

        ApplicationDbContext _dbContext = new();

        //private string filePath = @"C:\Users\chino\Desktop\pulsenics";

        public editUser()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void editUser_Load(object sender, EventArgs e)
        {
            try
            {

                nameInput.Text = signIn.CurrentUser.Name;
                emailInput.Text = signIn.CurrentUser.Email;
                phoneInput.Text = signIn.CurrentUser.Phone;

                var files = Program._dbContext.Files?.ToList();

                if (files?.Count > 0)
                {

                    foreach (var file in files)
                    {
                        fileList.Items.Add(file.Name);
                    }

                }

                //list of files of current user
                if (savedFiles != null)
                {
                    foreach (var file in savedFiles)
                    {
                        addedFileList.Items.Add(file.Name);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Edit page load:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void nameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void fileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedFile = fileList.SelectedItem?.ToString();

                var file = Program.FindFileFromFileName(selectedFile);

                if (file != null && addedFileList.Items.Contains(file.Name) == false)
                {

                    addedFileList.Items.Add(file.Name);
                    savedFiles.Add(file);
                    //MessageBox.Show(savedFiles.Count().ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("File List Index Change:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            //try
            //{
            //save user
            User? user = Program._dbContext.Users?.Where(user => user.Id == signIn.CurrentUser.Id).FirstOrDefault();

            user.Name = nameInput.Text;
            user.Email = emailInput.Text;
            user.Phone = phoneInput.Text;

            Program._dbContext.SaveChanges();

            ICollection<File> files = new List<File>();

            Program.RemoveAllUserFilesFromUserId(signIn.CurrentUser.Id);

            foreach (var item in addedFileList.Items)
            {
                User_file user_files = new();

                File file = Program.FindFileFromFileName(item.ToString());

                User_file uf = new();

                uf.UserId = signIn.CurrentUser.Id;
                uf.FileId = file.Id;
                uf.User = user;
                uf.File = file;

                Program._dbContext.User_files.Add(uf);


                //files.Add(file);

                Program._dbContext.SaveChanges();

                //}

            }

            //Program._dbContext.Users.Add(new User {Name= nameInput.Text, Email= emailInput.Text, Phone= phoneInput.Text, Files=files});

            //Program._dbContext.SaveChanges();

            main mainPage = new();
            mainPage.Show();
            this.Hide();

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}

        }

        private void addedFileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedFile = addedFileList.SelectedItem?.ToString();

            if (selectedFile != null)
            {
                addedFileList.Items.Remove(selectedFile);
                var file = Program.FindFileFromFileName(selectedFile);
                savedFiles.Remove(file);
                MessageBox.Show(savedFiles.Count().ToString());
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
