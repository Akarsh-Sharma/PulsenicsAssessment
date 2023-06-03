namespace PulsenicsAssessment
{
    partial class Form2
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
            dataGridView1 = new DataGridView();
            txtUserName = new TextBox();
            txtUserPhone = new TextBox();
            txtUserEmail = new TextBox();
            comboBoxUsers = new ComboBox();
            btnSearch = new Button();
            txtSearch = new TextBox();
            btnSaveUser = new Button();
            btnFileAssign = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(288, 29);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(575, 269);
            dataGridView1.TabIndex = 0;
            // 
            // txtUserName
            // 
            txtUserName.AccessibleName = "txtUserName";
            txtUserName.Location = new Point(75, 29);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(100, 23);
            txtUserName.TabIndex = 1;
            txtUserName.TextChanged += txtUserName_TextChanged;
            // 
            // txtUserPhone
            // 
            txtUserPhone.Location = new Point(75, 87);
            txtUserPhone.Name = "txtUserPhone";
            txtUserPhone.Size = new Size(100, 23);
            txtUserPhone.TabIndex = 2;
            // 
            // txtUserEmail
            // 
            txtUserEmail.Location = new Point(75, 58);
            txtUserEmail.Name = "txtUserEmail";
            txtUserEmail.Size = new Size(100, 23);
            txtUserEmail.TabIndex = 3;
            // 
            // comboBoxUsers
            // 
            comboBoxUsers.FormattingEnabled = true;
            comboBoxUsers.Location = new Point(288, 328);
            comboBoxUsers.Name = "comboBoxUsers";
            comboBoxUsers.Size = new Size(194, 23);
            comboBoxUsers.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(75, 298);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 30);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search Files";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(75, 257);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 23);
            txtSearch.TabIndex = 6;
            // 
            // btnSaveUser
            // 
            btnSaveUser.Location = new Point(75, 116);
            btnSaveUser.Name = "btnSaveUser";
            btnSaveUser.Size = new Size(100, 24);
            btnSaveUser.TabIndex = 7;
            btnSaveUser.Text = "Save User";
            btnSaveUser.UseVisualStyleBackColor = true;
            btnSaveUser.Click += btnSaveUser_Click;
            // 
            // btnFileAssign
            // 
            btnFileAssign.Location = new Point(509, 328);
            btnFileAssign.Name = "btnFileAssign";
            btnFileAssign.Size = new Size(87, 23);
            btnFileAssign.TabIndex = 8;
            btnFileAssign.Text = "Assign File";
            btnFileAssign.UseVisualStyleBackColor = true;
            btnFileAssign.Click += btnAssignFile_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 553);
            Controls.Add(btnFileAssign);
            Controls.Add(btnSaveUser);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(comboBoxUsers);
            Controls.Add(txtUserEmail);
            Controls.Add(txtUserPhone);
            Controls.Add(txtUserName);
            Controls.Add(dataGridView1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtUserName;
        private TextBox txtUserPhone;
        private TextBox txtUserEmail;
        private ComboBox comboBoxUsers;
        private Button btnSearch;
        private TextBox txtSearch;
        private Button btnSaveUser;
        private Button btnFileAssign;
    }
}