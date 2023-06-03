using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PulsenicsAssessment
{
    public partial class Form2 : Form
    {
        private readonly string folderPath = "C:\\Users\\akars\\OneDrive\\Desktop\\Pulsenics";
        private YourDbContext dbContext;
        public Form2()
        {
            InitializeComponent();
            InitializeDataGridView();

            LoadFilesFromFolder();
            InitializeDbContext();

            // Initialize the FileSystemWatcher
            FileSystemWatcher fileSystemWatcher = new FileSystemWatcher();
            fileSystemWatcher.Path = folderPath;
            fileSystemWatcher.Filter = "*.*";
            fileSystemWatcher.IncludeSubdirectories = false;
            fileSystemWatcher.NotifyFilter = NotifyFilters.LastWrite;
            fileSystemWatcher.Changed += fileSystemWatcher_Changed;
            fileSystemWatcher.EnableRaisingEvents = true;


            LoadUsers();
        }

        private void InitializeDataGridView()
        {
            // Configure the DataGridView control
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add("FileNameColumn", "File Name");
            dataGridView1.Columns.Add("ExtensionColumn", "Extension");
            dataGridView1.Columns.Add("CreatedDateColumn", "Created Date");
            dataGridView1.Columns.Add("ModifiedDateColumn", "Modified Date");
            dataGridView1.Columns.Add("AssignedColumn", "Assigned");

            // Set the Assigned column to read-only
            dataGridView1.Columns["AssignedColumn"].ReadOnly = false;
        }


        private void InitializeDbContext()
        {
            // Get the connection string from the configuration file
            string connectionString = "server=DESKTOP-5JVB8O4\\SQLEXPRESS; database=PulsenicsDB; Integrated Security=True; MultipleActiveResultSets=true; TrustServerCertificate=True;";
            dbContext = new YourDbContext(connectionString);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadFilesFromFolder();
        }

        private void LoadFilesFromFolder()
        {
            // Get the list of files from the specified folder
            string[] files = Directory.GetFiles(folderPath);

            // Clear existing data
            dataGridView1.Rows.Clear();

            foreach (string filePath in files)
            {
                FileInfo fileInfo = new FileInfo(filePath);

                // Get the assigned status for the current file
                bool isAssigned = GetAssignedStatusFromFile(fileInfo.Name);

                // Add file details to the DataGridView
                dataGridView1.Rows.Add(
                    fileInfo.Name,
                    fileInfo.Extension,
                    fileInfo.CreationTime,
                    fileInfo.LastWriteTime,
                    isAssigned  // Assign the assigned status to the AssignedColumn
                );

                // Save the file details to the database
                SaveFileToDatabase(fileInfo);
            }
        }

        private bool GetAssignedStatusFromFile(string fileName)
        {
            using (var dbContext = new YourDbContext("server=DESKTOP-5JVB8O4\\SQLEXPRESS; database=PulsenicsDB; Integrated Security=True; MultipleActiveResultSets=true; TrustServerCertificate=True;"))
            {
                // Check if the file exists in the database
                var file = dbContext.Files.FirstOrDefault(f => f.FileName == fileName);
                if (file != null)
                {
                    // Check if the file is assigned to any user
                    var assignedFile = dbContext.AssignedFiles.FirstOrDefault(af => af.FileId == file.FileId);
                    if (assignedFile != null)
                    {
                        // File is assigned to at least one user
                        return true;
                    }
                }
            }

            // File is not assigned to any user
            return false;
        }



        private void SaveFileToDatabase(FileInfo fileInfo)
        {
            using (YourDbContext dbContext = new YourDbContext("server=DESKTOP-5JVB8O4\\SQLEXPRESS; database=PulsenicsDB; Integrated Security=True; MultipleActiveResultSets=true; TrustServerCertificate=True;"))
            {
                // check if file already exists
                bool fileExists = dbContext.Files.Any(f => f.FileName == fileInfo.Name && f.Extension == fileInfo.Extension);
                if (!fileExists)
                {
                    FileEntity fileEntity = new FileEntity
                    {
                        FileName = fileInfo.Name,
                        Extension = fileInfo.Extension,
                        CreatedDate = fileInfo.CreationTime,
                        ModifiedDate = fileInfo.LastWriteTime
                    };
                    dbContext.Files.Add(fileEntity);
                    dbContext.SaveChanges();
                }
            }
        }

        private void SearchFiles(string searchQuery)
        {
            List<FileEntity> matchingFiles = dbContext.Files
                .Where(file => file.FileName.Contains(searchQuery))
                .ToList();

            dataGridView1.Rows.Clear();

            foreach (FileEntity file in matchingFiles)
            {
                dataGridView1.Rows.Add(
                    file.FileName,
                    file.Extension,
                    file.CreatedDate,
                    file.ModifiedDate
                );
            }
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            string name = txtUserName.Text.Trim();
            string email = txtUserEmail.Text.Trim();
            string phone = txtUserPhone.Text.Trim();

            // Validate name
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a valid name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate email format
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate phone number format
            if (!IsValidPhoneNumber(phone))
            {
                MessageBox.Show("Please enter a 9-digit phone number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UserEntity user = new UserEntity
            {
                Name = name,
                Email = email,
                Phone = phone
            };

            dbContext.Users.Add(user);
            dbContext.SaveChanges();

            // Clear the text boxes
            txtUserName.Text = "";
            txtUserEmail.Text = "";
            txtUserPhone.Text = "";

            // Populate the combo box with the new user
            PopulateUserComboBox();

        }

        // Validation check for email
        private bool IsValidEmail(string email)
        {
            return email.Contains("@");
        }

        // Validation check for phone number
        private bool IsValidPhoneNumber(string phone)
        {
            return phone.Length == 9 && int.TryParse(phone, out _);
        }


        private void btnAssignFile_Click(object sender, EventArgs e)
        {
            // Get the selected user from the combo box
            UserEntity selectedUser = (UserEntity)comboBoxUsers.SelectedItem;
            // Verify if a user is selected
            if (selectedUser == null)
            {
                MessageBox.Show("Please select a user.");
                return;
            }
            // Verify if any rows are selected
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select one or more files.");
                return;
            }
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                // Get the file name from the selected row
                string fileName = row.Cells["FileNameColumn"].Value.ToString();

                // Get the file from the database based on the file name
                FileEntity file = dbContext.Files.FirstOrDefault(f => f.FileName == fileName);

                if (file != null)
                {
                    // Check if the file is already assigned to the selected user
                    bool isAlreadyAssigned = dbContext.AssignedFiles
                        .Any(a => a.UserId == selectedUser.UserId && a.FileId == file.FileId);

                    if (isAlreadyAssigned)
                    {
                        MessageBox.Show("The file is already assigned to the selected user.");
                    }
                    else
                    {
                        // Create a new assigned file entity
                        AssignedFileEntity assignedFile = new AssignedFileEntity
                        {
                            UserId = selectedUser.UserId,
                            FileId = file.FileId,
                            User = selectedUser,
                            File = file
                        };

                        // Update the assigned column in the DataGridView
                        DataGridViewCell assignedCell = row.Cells["AssignedColumn"];
                        assignedCell.Value = true;


                        // Add the assigned file to the database
                        dbContext.AssignedFiles.Add(assignedFile);
                        dbContext.SaveChanges();
                    }
                }
            }

            // Reload the files with updated info in the combo box
            LoadFilesFromFolder();
        }




        private void fileSystemWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            // Update the modified date of the file in the database
            FileEntity file = dbContext.Files.FirstOrDefault(f => f.FileName == e.Name);

            if (file != null)
            {
                file.ModifiedDate = File.GetLastWriteTime(e.FullPath);
                dbContext.SaveChanges();
                // update the file in the combo box 
                UpdateFileData(e.Name);
            }
        }

        private void UpdateFileData(string fileName)
        {
            // Get the file row in the DataGridView
            DataGridViewRow fileRow = dataGridView1.Rows
                .Cast<DataGridViewRow>()
                .FirstOrDefault(row => row.Cells["FileNameColumn"].Value.ToString() == fileName);

            if (fileRow != null)
            {
                // Get the file information
                FileInfo fileInfo = new FileInfo(Path.Combine(folderPath, fileName));

                // Update the file data in the DataGridView
                fileRow.Cells["CreatedDateColumn"].Value = fileInfo.CreationTime;
                fileRow.Cells["ModifiedDateColumn"].Value = fileInfo.LastWriteTime;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchQuery = txtSearch.Text;
            SearchFiles(searchQuery);
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        // Load the users in the database into the combo box list
        private void LoadUsers()
        {
            comboBoxUsers.Items.Clear();

            List<UserEntity> users = dbContext.Users.ToList();

            foreach (UserEntity user in users)
            {
                comboBoxUsers.Items.Add(user);
            }
        }

        // Populate the combo box as soon as a new user is created
        private void PopulateUserComboBox()
        {
            using (YourDbContext dbContext = new YourDbContext("server=DESKTOP-5JVB8O4\\SQLEXPRESS; database=PulsenicsDB; Integrated Security=True; MultipleActiveResultSets=true; TrustServerCertificate=True;"))
            {
                List<UserEntity> users = dbContext.Users.ToList();
                comboBoxUsers.DataSource = users;
                comboBoxUsers.DisplayMember = "Name";
                comboBoxUsers.ValueMember = "UserId";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click_2(object sender, EventArgs e)
        {

        }

        private void comboBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void txtUserPhone_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtUserEmail_TextChanged(object sender, EventArgs e)
        {
        }
    }
    public class YourDbContext : DbContext
    {
        public YourDbContext(string connectionString)
            : base(connectionString)
        {
        }

        public DbSet<FileEntity> Files { get; set; }
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<AssignedFileEntity> AssignedFiles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserEntity>().ToTable("Users");
            modelBuilder.Entity<FileEntity>().ToTable("Files");
            modelBuilder.Entity<AssignedFileEntity>().ToTable("AssignedFiles");

            modelBuilder.Entity<UserEntity>()
                .HasMany(u => u.AssignedFiles)
                .WithMany()
                .Map(m =>
                {
                    m.ToTable("UserAssignedFiles");
                    m.MapLeftKey("UserId");
                    m.MapRightKey("AssignedFileId");
                });

            base.OnModelCreating(modelBuilder);
        }
    }

    public class FileEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FileId { get; set; }

        // Rest of the properties...
        public string FileName { get; set; }
        public string Extension { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }


    public class UserEntity
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public virtual ICollection<FileEntity> AssignedFiles { get; set; } = new List<FileEntity>();
    }



    public class AssignedFileEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        [ForeignKey("File")]
        public int FileId { get; set; }

        public virtual UserEntity User { get; set; }

        public virtual FileEntity File { get; set; }
    }

}
