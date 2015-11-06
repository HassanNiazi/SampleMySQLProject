namespace DatabaseSampleApp
{
    partial class Main_Menu
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
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.AccountButton = new System.Windows.Forms.Button();
            this.EmployeeManagmentButton = new System.Windows.Forms.Button();
            this.AdminsAndUsersButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(159, 261);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 37);
            this.button4.TabIndex = 3;
            this.button4.Text = "Sign Off";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(269, 261);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 37);
            this.button5.TabIndex = 4;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // AccountButton
            // 
            this.AccountButton.BackColor = System.Drawing.Color.Transparent;
            this.AccountButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountButton.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountButton.ForeColor = System.Drawing.Color.DarkOrchid;
            this.AccountButton.Location = new System.Drawing.Point(12, 36);
            this.AccountButton.Name = "AccountButton";
            this.AccountButton.Size = new System.Drawing.Size(166, 214);
            this.AccountButton.TabIndex = 0;
            this.AccountButton.Text = "Accounts";
            this.AccountButton.UseVisualStyleBackColor = false;
            this.AccountButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmployeeManagmentButton
            // 
            this.EmployeeManagmentButton.BackColor = System.Drawing.Color.Transparent;
            this.EmployeeManagmentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EmployeeManagmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmployeeManagmentButton.Font = new System.Drawing.Font("Modern No. 20", 25F);
            this.EmployeeManagmentButton.ForeColor = System.Drawing.Color.DarkOrchid;
            this.EmployeeManagmentButton.Location = new System.Drawing.Point(184, 36);
            this.EmployeeManagmentButton.Name = "EmployeeManagmentButton";
            this.EmployeeManagmentButton.Size = new System.Drawing.Size(166, 214);
            this.EmployeeManagmentButton.TabIndex = 5;
            this.EmployeeManagmentButton.Text = "Employee";
            this.EmployeeManagmentButton.UseVisualStyleBackColor = false;
            this.EmployeeManagmentButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // AdminsAndUsersButton
            // 
            this.AdminsAndUsersButton.BackColor = System.Drawing.Color.Transparent;
            this.AdminsAndUsersButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AdminsAndUsersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminsAndUsersButton.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminsAndUsersButton.ForeColor = System.Drawing.Color.DarkOrchid;
            this.AdminsAndUsersButton.Location = new System.Drawing.Point(356, 36);
            this.AdminsAndUsersButton.Name = "AdminsAndUsersButton";
            this.AdminsAndUsersButton.Size = new System.Drawing.Size(166, 214);
            this.AdminsAndUsersButton.TabIndex = 6;
            this.AdminsAndUsersButton.Text = "Users";
            this.AdminsAndUsersButton.UseVisualStyleBackColor = false;
            this.AdminsAndUsersButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Welcome";
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DatabaseSampleApp.Properties.Resources.Cyan_Blue_Blue_Background_with_White_Light_620x387;
            this.ClientSize = new System.Drawing.Size(535, 312);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdminsAndUsersButton);
            this.Controls.Add(this.EmployeeManagmentButton);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.AccountButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main_Menu";
            this.Load += new System.EventHandler(this.Main_Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AccountButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button EmployeeManagmentButton;
        private System.Windows.Forms.Button AdminsAndUsersButton;
        private System.Windows.Forms.Label label1;
    }
}