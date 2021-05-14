
namespace WindowsFormsTravelOrginizer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonExit = new System.Windows.Forms.Button();
            this.listBoxUsers = new System.Windows.Forms.ListBox();
            this.labelText1 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.tabSelectUser = new System.Windows.Forms.TabControl();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.buttonUsersSelect = new System.Windows.Forms.Button();
            this.tabMenuAdmin = new System.Windows.Forms.TabPage();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.buttonDeleateUser = new System.Windows.Forms.Button();
            this.UserUpdate = new System.Windows.Forms.Button();
            this.listBoxMenuAdminUsers = new System.Windows.Forms.ListBox();
            this.tabSelectedUser = new System.Windows.Forms.TabPage();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.tabSelectUser.SuspendLayout();
            this.tabUsers.SuspendLayout();
            this.tabMenuAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(636, 366);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(100, 45);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.Location = new System.Drawing.Point(6, 7);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.Size = new System.Drawing.Size(450, 264);
            this.listBoxUsers.TabIndex = 1;
            this.listBoxUsers.SelectedIndexChanged += new System.EventHandler(this.listBoxSelectedName);
            // 
            // labelText1
            // 
            this.labelText1.AutoSize = true;
            this.labelText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelText1.Location = new System.Drawing.Point(35, 74);
            this.labelText1.Name = "labelText1";
            this.labelText1.Size = new System.Drawing.Size(319, 31);
            this.labelText1.TabIndex = 2;
            this.labelText1.Text = "Выберите пользователя";
            this.labelText1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(462, 247);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 3;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // tabSelectUser
            // 
            this.tabSelectUser.Controls.Add(this.tabUsers);
            this.tabSelectUser.Controls.Add(this.tabMenuAdmin);
            this.tabSelectUser.Controls.Add(this.tabSelectedUser);
            this.tabSelectUser.Location = new System.Drawing.Point(41, 108);
            this.tabSelectUser.Name = "tabSelectUser";
            this.tabSelectUser.SelectedIndex = 0;
            this.tabSelectUser.Size = new System.Drawing.Size(560, 303);
            this.tabSelectUser.TabIndex = 4;
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.buttonUsersSelect);
            this.tabUsers.Controls.Add(this.listBoxUsers);
            this.tabUsers.Controls.Add(this.buttonUpdate);
            this.tabUsers.Location = new System.Drawing.Point(4, 22);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsers.Size = new System.Drawing.Size(552, 277);
            this.tabUsers.TabIndex = 0;
            this.tabUsers.Text = "Выбор пользователя";
            this.tabUsers.UseVisualStyleBackColor = true;
            this.tabUsers.Click += new System.EventHandler(this.tabUsers_Click);
            // 
            // buttonUsersSelect
            // 
            this.buttonUsersSelect.Location = new System.Drawing.Point(462, 218);
            this.buttonUsersSelect.Name = "buttonUsersSelect";
            this.buttonUsersSelect.Size = new System.Drawing.Size(75, 23);
            this.buttonUsersSelect.TabIndex = 4;
            this.buttonUsersSelect.Text = "Выбор";
            this.buttonUsersSelect.UseVisualStyleBackColor = true;
            this.buttonUsersSelect.Click += new System.EventHandler(this.buttonUsersSelect_Click);
            // 
            // tabMenuAdmin
            // 
            this.tabMenuAdmin.Controls.Add(this.textBoxUser);
            this.tabMenuAdmin.Controls.Add(this.buttonAddUser);
            this.tabMenuAdmin.Controls.Add(this.buttonDeleateUser);
            this.tabMenuAdmin.Controls.Add(this.UserUpdate);
            this.tabMenuAdmin.Controls.Add(this.listBoxMenuAdminUsers);
            this.tabMenuAdmin.Location = new System.Drawing.Point(4, 22);
            this.tabMenuAdmin.Name = "tabMenuAdmin";
            this.tabMenuAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.tabMenuAdmin.Size = new System.Drawing.Size(552, 277);
            this.tabMenuAdmin.TabIndex = 1;
            this.tabMenuAdmin.Text = "Меню админа";
            this.tabMenuAdmin.UseVisualStyleBackColor = true;
            this.tabMenuAdmin.Click += new System.EventHandler(this.tabMenuAdmin_Click);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Location = new System.Drawing.Point(471, 33);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(75, 23);
            this.buttonAddUser.TabIndex = 6;
            this.buttonAddUser.Text = "Добавить";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // buttonDeleateUser
            // 
            this.buttonDeleateUser.Location = new System.Drawing.Point(471, 62);
            this.buttonDeleateUser.Name = "buttonDeleateUser";
            this.buttonDeleateUser.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleateUser.TabIndex = 5;
            this.buttonDeleateUser.Text = "Удалить";
            this.buttonDeleateUser.UseVisualStyleBackColor = true;
            this.buttonDeleateUser.Click += new System.EventHandler(this.buttonDeleateUser_Click);
            // 
            // UserUpdate
            // 
            this.UserUpdate.Location = new System.Drawing.Point(471, 248);
            this.UserUpdate.Name = "UserUpdate";
            this.UserUpdate.Size = new System.Drawing.Size(75, 23);
            this.UserUpdate.TabIndex = 4;
            this.UserUpdate.Text = "Обновить";
            this.UserUpdate.UseVisualStyleBackColor = true;
            this.UserUpdate.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // listBoxMenuAdminUsers
            // 
            this.listBoxMenuAdminUsers.FormattingEnabled = true;
            this.listBoxMenuAdminUsers.Location = new System.Drawing.Point(6, 7);
            this.listBoxMenuAdminUsers.Name = "listBoxMenuAdminUsers";
            this.listBoxMenuAdminUsers.Size = new System.Drawing.Size(363, 264);
            this.listBoxMenuAdminUsers.TabIndex = 2;
            this.listBoxMenuAdminUsers.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // tabSelectedUser
            // 
            this.tabSelectedUser.Location = new System.Drawing.Point(4, 22);
            this.tabSelectedUser.Name = "tabSelectedUser";
            this.tabSelectedUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabSelectedUser.Size = new System.Drawing.Size(552, 277);
            this.tabSelectedUser.TabIndex = 2;
            this.tabSelectedUser.Text = "Меню пользователя";
            this.tabSelectedUser.UseVisualStyleBackColor = true;
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(375, 7);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(171, 20);
            this.textBoxUser.TabIndex = 7;
            this.textBoxUser.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabSelectUser);
            this.Controls.Add(this.labelText1);
            this.Controls.Add(this.buttonExit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabSelectUser.ResumeLayout(false);
            this.tabUsers.ResumeLayout(false);
            this.tabMenuAdmin.ResumeLayout(false);
            this.tabMenuAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ListBox listBoxUsers;
        private System.Windows.Forms.Label labelText1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TabControl tabSelectUser;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.TabPage tabMenuAdmin;
        private System.Windows.Forms.TabPage tabSelectedUser;
        private System.Windows.Forms.Button buttonUsersSelect;
        private System.Windows.Forms.Button UserUpdate;
        private System.Windows.Forms.ListBox listBoxMenuAdminUsers;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Button buttonDeleateUser;
        private System.Windows.Forms.TextBox textBoxUser;
    }
}

