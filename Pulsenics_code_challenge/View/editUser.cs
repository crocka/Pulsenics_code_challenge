using System.Data;

namespace Pulsenics_code_challenge
{
    public partial class editUser : Form
    {

        public List<File> savedFiles = Program.FindFilesFromUserId(signIn.CurrentUser.Id);

        public editUser()
        {
            InitializeComponent();
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
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("File List Index Change:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            try
            {
                //save user
                User? user = Program._dbContext.Users?.Where(user => user.Id == signIn.CurrentUser.Id).FirstOrDefault();

                user.Name = nameInput.Text;
                user.Email = emailInput.Text;
                user.Phone = phoneInput.Text;
                Program._dbContext.SaveChanges();
                Program.RemoveAllUserFilesFromUserId(signIn.CurrentUser.Id);

                ICollection<File> files = new List<File>();

                foreach (var item in addedFileList.Items)
                {

                    File file = Program.FindFileFromFileName(item.ToString());

                    User_file uf = new();

                    uf.UserId = signIn.CurrentUser.Id;
                    uf.FileId = file.Id;
                    uf.User = user;
                    uf.File = file;

                    Program._dbContext.User_files.Add(uf);

                    Program._dbContext.SaveChanges();
                }

                main mainPage = new();
                mainPage.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void addedFileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedFile = addedFileList.SelectedItem?.ToString();

            if (selectedFile != null)
            {
                addedFileList.Items.Remove(selectedFile);
                var file = Program.FindFileFromFileName(selectedFile);
                savedFiles.Remove(file);
            }
        }
    }
}
