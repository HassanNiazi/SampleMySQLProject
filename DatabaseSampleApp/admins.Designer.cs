namespace DatabaseSampleApp
{
    partial class admins
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RegisterUser = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.HasAccountPortalAcc = new System.Windows.Forms.CheckBox();
            this.hasManagAcc = new System.Windows.Forms.CheckBox();
            this.hasAdminAcc = new System.Windows.Forms.CheckBox();
            this.ConfirmPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.UpHasAccount = new System.Windows.Forms.CheckBox();
            this.UpdateUserId = new System.Windows.Forms.TextBox();
            this.UpHasManag = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.UpHasAdmin = new System.Windows.Forms.CheckBox();
            this.UpdatePassword = new System.Windows.Forms.TextBox();
            this.UpdateConfirmPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RegisterUser);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.HasAccountPortalAcc);
            this.groupBox1.Controls.Add(this.hasManagAcc);
            this.groupBox1.Controls.Add(this.hasAdminAcc);
            this.groupBox1.Controls.Add(this.ConfirmPassword);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Password);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.UserName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 227);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add User";
            // 
            // RegisterUser
            // 
            this.RegisterUser.Location = new System.Drawing.Point(19, 186);
            this.RegisterUser.Name = "RegisterUser";
            this.RegisterUser.Size = new System.Drawing.Size(104, 23);
            this.RegisterUser.TabIndex = 0;
            this.RegisterUser.Text = "Register User";
            this.RegisterUser.UseVisualStyleBackColor = true;
            this.RegisterUser.Click += new System.EventHandler(this.RegisterUser_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(137, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Show All Users";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // HasAccountPortalAcc
            // 
            this.HasAccountPortalAcc.AutoSize = true;
            this.HasAccountPortalAcc.Location = new System.Drawing.Point(34, 163);
            this.HasAccountPortalAcc.Name = "HasAccountPortalAcc";
            this.HasAccountPortalAcc.Size = new System.Drawing.Size(156, 17);
            this.HasAccountPortalAcc.TabIndex = 7;
            this.HasAccountPortalAcc.Text = "Has Account Portal Access";
            this.HasAccountPortalAcc.UseVisualStyleBackColor = true;
            // 
            // hasManagAcc
            // 
            this.hasManagAcc.AutoSize = true;
            this.hasManagAcc.Location = new System.Drawing.Point(34, 140);
            this.hasManagAcc.Name = "hasManagAcc";
            this.hasManagAcc.Size = new System.Drawing.Size(178, 17);
            this.hasManagAcc.TabIndex = 6;
            this.hasManagAcc.Text = "Has Management Portal Access";
            this.hasManagAcc.UseVisualStyleBackColor = true;
            // 
            // hasAdminAcc
            // 
            this.hasAdminAcc.AutoSize = true;
            this.hasAdminAcc.Location = new System.Drawing.Point(34, 117);
            this.hasAdminAcc.Name = "hasAdminAcc";
            this.hasAdminAcc.Size = new System.Drawing.Size(115, 17);
            this.hasAdminAcc.TabIndex = 0;
            this.hasAdminAcc.Text = "Has Admin Access";
            this.hasAdminAcc.UseVisualStyleBackColor = true;
            // 
            // ConfirmPassword
            // 
            this.ConfirmPassword.Location = new System.Drawing.Point(82, 71);
            this.ConfirmPassword.Name = "ConfirmPassword";
            this.ConfirmPassword.PasswordChar = '*';
            this.ConfirmPassword.Size = new System.Drawing.Size(148, 20);
            this.ConfirmPassword.TabIndex = 4;
            this.ConfirmPassword.TextChanged += new System.EventHandler(this.ConfirmPassword_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Confirm \r\nPassword";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(82, 45);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(148, 20);
            this.Password.TabIndex = 2;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(82, 19);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(148, 20);
            this.UserName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.UpHasAccount);
            this.groupBox2.Controls.Add(this.UpdateUserId);
            this.groupBox2.Controls.Add(this.UpHasManag);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.UpHasAdmin);
            this.groupBox2.Controls.Add(this.UpdatePassword);
            this.groupBox2.Controls.Add(this.UpdateConfirmPassword);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(264, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 227);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update User";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(149, 42);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(81, 23);
            this.button5.TabIndex = 19;
            this.button5.Text = "Search";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(122, 197);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "Update User";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(19, 197);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Delete User";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "User Name";
            // 
            // UpHasAccount
            // 
            this.UpHasAccount.AutoSize = true;
            this.UpHasAccount.Location = new System.Drawing.Point(19, 177);
            this.UpHasAccount.Name = "UpHasAccount";
            this.UpHasAccount.Size = new System.Drawing.Size(156, 17);
            this.UpHasAccount.TabIndex = 17;
            this.UpHasAccount.Text = "Has Account Portal Access";
            this.UpHasAccount.UseVisualStyleBackColor = true;
            // 
            // UpdateUserId
            // 
            this.UpdateUserId.Location = new System.Drawing.Point(82, 18);
            this.UpdateUserId.Name = "UpdateUserId";
            this.UpdateUserId.Size = new System.Drawing.Size(148, 20);
            this.UpdateUserId.TabIndex = 10;
            // 
            // UpHasManag
            // 
            this.UpHasManag.AutoSize = true;
            this.UpHasManag.Location = new System.Drawing.Point(19, 154);
            this.UpHasManag.Name = "UpHasManag";
            this.UpHasManag.Size = new System.Drawing.Size(178, 17);
            this.UpHasManag.TabIndex = 16;
            this.UpHasManag.Text = "Has Management Portal Access";
            this.UpHasManag.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Password";
            // 
            // UpHasAdmin
            // 
            this.UpHasAdmin.AutoSize = true;
            this.UpHasAdmin.Location = new System.Drawing.Point(19, 131);
            this.UpHasAdmin.Name = "UpHasAdmin";
            this.UpHasAdmin.Size = new System.Drawing.Size(115, 17);
            this.UpHasAdmin.TabIndex = 9;
            this.UpHasAdmin.Text = "Has Admin Access";
            this.UpHasAdmin.UseVisualStyleBackColor = true;
            // 
            // UpdatePassword
            // 
            this.UpdatePassword.Location = new System.Drawing.Point(82, 70);
            this.UpdatePassword.Name = "UpdatePassword";
            this.UpdatePassword.PasswordChar = '*';
            this.UpdatePassword.Size = new System.Drawing.Size(148, 20);
            this.UpdatePassword.TabIndex = 12;
            this.UpdatePassword.TextChanged += new System.EventHandler(this.UpdatePassword_TextChanged);
            // 
            // UpdateConfirmPassword
            // 
            this.UpdateConfirmPassword.Location = new System.Drawing.Point(82, 96);
            this.UpdateConfirmPassword.Name = "UpdateConfirmPassword";
            this.UpdateConfirmPassword.PasswordChar = '*';
            this.UpdateConfirmPassword.Size = new System.Drawing.Size(148, 20);
            this.UpdateConfirmPassword.TabIndex = 14;
            this.UpdateConfirmPassword.TextChanged += new System.EventHandler(this.UpdateConfirmPassword_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 26);
            this.label4.TabIndex = 15;
            this.label4.Text = "Confirm \r\nPassword";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 260);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(500, 251);
            this.dataGridView1.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 520);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(523, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Status";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(523, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // admins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 542);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "admins";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator Panel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button RegisterUser;
        private System.Windows.Forms.CheckBox HasAccountPortalAcc;
        private System.Windows.Forms.CheckBox hasManagAcc;
        private System.Windows.Forms.CheckBox hasAdminAcc;
        private System.Windows.Forms.TextBox ConfirmPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox UpHasAccount;
        private System.Windows.Forms.TextBox UpdateUserId;
        private System.Windows.Forms.CheckBox UpHasManag;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox UpHasAdmin;
        private System.Windows.Forms.TextBox UpdatePassword;
        private System.Windows.Forms.TextBox UpdateConfirmPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}