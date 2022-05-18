using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Pulsenics_code_challenge
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 

        public static ApplicationDbContext _dbContext = new();
        public static string filePath = @"C:\Users\chino\Desktop\pulsenics";

        [STAThread]
        static async Task Main()
        {

            using var watcher = new FileSystemWatcher(@"C:\Users\chino\Desktop\pulsenics");

            await using var dbContext = new ApplicationDbContext();
            await dbContext.Database.EnsureCreatedAsync();

            await dbContext.SaveChangesAsync();

            watcher.NotifyFilter = NotifyFilters.Attributes
                     | NotifyFilters.CreationTime
                     | NotifyFilters.DirectoryName
                     | NotifyFilters.FileName
                     | NotifyFilters.LastAccess
                     | NotifyFilters.LastWrite
                     | NotifyFilters.Security
                     | NotifyFilters.Size;

            watcher.Changed += OnChanged;
            watcher.Created += OnCreated;
            watcher.Deleted += OnDeleted;
            watcher.Renamed += OnRenamed;
            watcher.Error += OnError;

            watcher.EnableRaisingEvents = true;
            loadFiles();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new signUp());
        }

        private static void OnChanged(object sender, FileSystemEventArgs e)
        {
            if (e.ChangeType != WatcherChangeTypes.Changed)
            {
                return;
            }
            MessageBox.Show($"Changed: {e.FullPath}");

        }

        private static void OnCreated(object sender, FileSystemEventArgs e)
        {

            try
            {
                var fileInfo = new FileInfo(e.FullPath);


                File file = new();

                var dbFile = _dbContext.Files.Where(file => file.Name == fileInfo.Name).FirstOrDefault();

                if (dbFile == null || object.Equals(dbFile, default(File)))
                {
                    file.Name = fileInfo.Name;
                    file.Created_at = fileInfo.CreationTime.ToString();
                    file.Updated_at = fileInfo.LastWriteTime.ToString();
                    _dbContext.Files.Add(file);

                    _dbContext.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };

        }

        private static void OnDeleted(object sender, FileSystemEventArgs e)
        {
            string[] path = e.FullPath.Split(@"\");

            var file = _dbContext.Files.Where(file => file.Name == path[path.Length - 1]).FirstOrDefault();

            _dbContext.Files?.Remove(file);
            _dbContext.SaveChanges();
        }

        private static void OnRenamed(object sender, RenamedEventArgs e)
        {
            string[] oldPath = e.OldFullPath.Split(@"\");
            string[] newPath = e.FullPath.Split(@"\");

            var file = FindFileFromFileName(oldPath[oldPath.Length - 1]);


            if (file != null)
            {
                file.Name = newPath[newPath.Length - 1];
                _dbContext.SaveChanges();

            }
        }

        private static void OnError(object sender, ErrorEventArgs e) =>
            PrintException(e.GetException());

        private static void PrintException(Exception? ex)
        {
            if (ex != null)
            {
                MessageBox.Show($"Message: {ex.Message}");
                MessageBox.Show("Stacktrace:");
                MessageBox.Show(ex.StackTrace);
                PrintException(ex.InnerException);
            }
        }

        public static void loadFiles()
        {
            DirectoryInfo fileDirectory;

            try
            {
                fileDirectory = new DirectoryInfo(filePath);
                FileInfo[] files = fileDirectory.GetFiles();

                for (int i = 0; i < files.Length; i++)
                {
                    File file = new();

                    var dbFile = _dbContext.Files.Where(file => file.Name == files[i].Name).FirstOrDefault();

                    if (dbFile == null || object.Equals(dbFile, default(File)))
                    {
                        file.Name = files[i].Name;
                        file.Created_at = files[i].CreationTime.ToString();
                        file.Updated_at = files[i].LastWriteTime.ToString();
                        _dbContext.Files.Add(file);

                        _dbContext.SaveChanges();

                    }
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };


        }

        public static List<File> FindFilesFromUserId(int userId)
        {

            var files = from file in _dbContext.Files
                        join user_file in _dbContext.User_files.Where(user_file => user_file.UserId == userId)
                        on file.Id equals user_file.FileId
                        select file;

            return files.ToList();
        }

        public static File FindFileFromFileName(string name)
        {
            try
            {
                var file = _dbContext.Files?.Where(file => file.Name == name)?.First();
                return file;
            }
            catch
            {

                return null;
            }


        }

        public static List<User> FindUsersFromFileId(int id)
        {
            var users = from user in _dbContext.Users
                        join user_file in _dbContext.User_files
                        on user.Id equals user_file.UserId
                        where user_file.FileId == id
                        select user;

            return users.ToList();

        }

        public static User FindUserFromUserId(int id)
        {
            var user = _dbContext.Users?.Where(user => user.Id == id)?.First();

            return user;
        }

        public static void RemoveAllUserFilesFromUserId(int id)
        {

            var user = _dbContext.Users?.Where(user => user.Id == id).First();

            var user_files = _dbContext.User_files.Where(uf => uf.UserId == id);

            foreach (var user_file in user_files)
            {
                _dbContext.User_files?.Remove(user_file);

                _dbContext.SaveChanges();
            }
        }
    }
}