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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
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
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.BackgroundColor = Color.FromArgb(128, 128, 255);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(288, 104);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(545, 145);
            dataGridView1.TabIndex = 0;
            // 
            // txtUserName
            // 
            txtUserName.AccessibleName = "txtUserName";
            txtUserName.Location = new Point(104, 46);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(100, 23);
            txtUserName.TabIndex = 1;
            txtUserName.TextChanged += txtUserName_TextChanged;
            // 
            // txtUserPhone
            // 
            txtUserPhone.Location = new Point(104, 125);
            txtUserPhone.Name = "txtUserPhone";
            txtUserPhone.Size = new Size(100, 23);
            txtUserPhone.TabIndex = 2;
            // 
            // txtUserEmail
            // 
            txtUserEmail.Location = new Point(104, 87);
            txtUserEmail.Name = "txtUserEmail";
            txtUserEmail.Size = new Size(100, 23);
            txtUserEmail.TabIndex = 3;
            // 
            // comboBoxUsers
            // 
            comboBoxUsers.FormattingEnabled = true;
            comboBoxUsers.Location = new Point(288, 275);
            comboBoxUsers.Name = "comboBoxUsers";
            comboBoxUsers.Size = new Size(194, 23);
            comboBoxUsers.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(502, 315);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 23);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search Files";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(288, 315);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(194, 23);
            txtSearch.TabIndex = 6;
            // 
            // btnSaveUser
            // 
            btnSaveUser.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSaveUser.ForeColor = Color.Black;
            btnSaveUser.Location = new Point(104, 163);
            btnSaveUser.Name = "btnSaveUser";
            btnSaveUser.Size = new Size(100, 31);
            btnSaveUser.TabIndex = 7;
            btnSaveUser.Text = "Save User";
            btnSaveUser.UseVisualStyleBackColor = true;
            btnSaveUser.Click += btnSaveUser_Click;
            // 
            // btnFileAssign
            // 
            btnFileAssign.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnFileAssign.Location = new Point(502, 275);
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
            label1.ForeColor = Color.Black;
            label1.Location = new Point(38, 49);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 9;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(62, 90);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 10;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(10, 128);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 11;
            label3.Text = "Phone Number";
            // 
            // label4
            // 
            label4.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(128, 128, 255);
            label4.Location = new Point(288, 79);
            label4.Name = "label4";
            label4.Size = new Size(124, 22);
            label4.TabIndex = 12;
            label4.Text = "List of Files";
            // 
            // label5
            // 
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(52, 9);
            label5.Name = "label5";
            label5.Size = new Size(112, 21);
            label5.TabIndex = 13;
            label5.Text = "Create a User";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Location = new Point(24, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(173, 55);
            panel1.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 128, 255);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtUserName);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtUserPhone);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtUserEmail);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnSaveUser);
            panel2.ForeColor = Color.Transparent;
            panel2.Location = new Point(24, 115);
            panel2.Name = "panel2";
            panel2.Size = new Size(219, 220);
            panel2.TabIndex = 15;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(866, 402);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(btnFileAssign);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(comboBoxUsers);
            Controls.Add(dataGridView1);
            Name = "Form2";
            Text = "PulsenicsApp";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Panel panel1;
        private Panel panel2;
    }
}