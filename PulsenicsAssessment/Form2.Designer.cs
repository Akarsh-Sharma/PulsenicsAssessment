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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(273, 84);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(545, 268);
            dataGridView1.TabIndex = 0;
            // 
            // txtUserName
            // 
            txtUserName.AccessibleName = "txtUserName";
            txtUserName.Location = new Point(105, 178);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(100, 23);
            txtUserName.TabIndex = 1;
            txtUserName.TextChanged += txtUserName_TextChanged;
            // 
            // txtUserPhone
            // 
            txtUserPhone.Location = new Point(105, 257);
            txtUserPhone.Name = "txtUserPhone";
            txtUserPhone.Size = new Size(100, 23);
            txtUserPhone.TabIndex = 2;
            txtUserPhone.TextChanged += txtUserPhone_TextChanged;
            // 
            // txtUserEmail
            // 
            txtUserEmail.Location = new Point(105, 219);
            txtUserEmail.Name = "txtUserEmail";
            txtUserEmail.Size = new Size(100, 23);
            txtUserEmail.TabIndex = 3;
            txtUserEmail.TextChanged += txtUserEmail_TextChanged;
            // 
            // comboBoxUsers
            // 
            comboBoxUsers.FormattingEnabled = true;
            comboBoxUsers.Location = new Point(273, 387);
            comboBoxUsers.Name = "comboBoxUsers";
            comboBoxUsers.Size = new Size(194, 23);
            comboBoxUsers.TabIndex = 4;
            comboBoxUsers.SelectedIndexChanged += comboBoxUsers_SelectedIndexChanged;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(487, 427);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 23);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search Files";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(273, 427);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(194, 23);
            txtSearch.TabIndex = 6;
            // 
            // btnSaveUser
            // 
            btnSaveUser.Location = new Point(105, 295);
            btnSaveUser.Name = "btnSaveUser";
            btnSaveUser.Size = new Size(100, 24);
            btnSaveUser.TabIndex = 7;
            btnSaveUser.Text = "Save User";
            btnSaveUser.UseVisualStyleBackColor = true;
            btnSaveUser.Click += btnSaveUser_Click;
            // 
            // btnFileAssign
            // 
            btnFileAssign.Location = new Point(487, 387);
            btnFileAssign.Name = "btnFileAssign";
            btnFileAssign.Size = new Size(100, 23);
            btnFileAssign.TabIndex = 8;
            btnFileAssign.Text = "Assign File";
            btnFileAssign.UseVisualStyleBackColor = true;
            btnFileAssign.Click += btnAssignFile_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 181);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 9;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 222);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 10;
            label2.Text = "Email";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 260);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 11;
            label3.Text = "Phone Number";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(273, 59);
            label4.Name = "label4";
            label4.Size = new Size(124, 22);
            label4.TabIndex = 12;
            label4.Text = "List of Files";
            // 
            // label5
            // 
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(93, 137);
            label5.Name = "label5";
            label5.Size = new Size(112, 21);
            label5.TabIndex = 13;
            label5.Text = "Create a User";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 553);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
            Text = "PulsenicsApp";
            Load += Form2_Load_1;
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}