using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pulsenics_code_challenge
{
    public partial class main : Form
    {

        private string filePath = @"C:\Users\chino\Desktop\pulsenics";
        private File selectedFile = new();
        public List<File> files = Program._dbContext.Files.ToList();

        public main()
        {
            InitializeComponent();
        }

        private void fileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Update label texts
                if (fileList?.SelectedItem != null)
                {

                    selectedFile = Program.FindFileFromFileName(fileList?.SelectedItem?.ToString());

                    fileNameLabel.Text = selectedFile.Name;

                    fileCreateTime.Text = selectedFile.Created_at;

                    fileUpdateTime.Text = selectedFile.Updated_at;
                }

                //Update userList
                var users = Program.FindUsersFromFileId(selectedFile.Id);

                if (users != null)
                {
                    userList.Items.Clear();

                    foreach (var user in users)
                    {
                        if (userList.Items.Contains(user.Name) == false)
                        {
                            userList.Items.Add(user.Name);

                        }
                    };
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("File List Index Change:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void searchInput_TextChanged(object sender, EventArgs e)
        {

            try
            {

                if (searchInput.Text == "")
                {
                    files = Program._dbContext.Files.ToList();

                    fileList.Items.Clear();

                    foreach (var file in files)
                    {
                        fileList.Items.Add(file.Name);

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Search Input Change:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void main_Load(object sender, EventArgs e)
        {
            foreach (var file in files)
            {
                fileList.Items.Add(file.Name);

            }

            userLabel.Text = signIn.CurrentUser?.Name.ToString();

        }

        private void editUserButton_Click(object sender, EventArgs e)
        {
            //go to edit user page
            editUser editUser = new();
            editUser.Show();
            this.Hide();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchInput.Text != "")
            {
                files = Program._dbContext.Files.Where(file => file.Name.Contains(searchInput.Text)).ToList();


                fileList.Items.Clear();

                foreach (var file in files)
                {
                    fileList.Items.Add(file.Name);

                }

            }
        }
    }
}
