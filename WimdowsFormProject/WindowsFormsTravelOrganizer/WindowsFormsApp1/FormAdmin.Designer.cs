
namespace WindowsFormsApp1
{
    partial class FormAdmin
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
            this.tabControlAdmin = new System.Windows.Forms.TabControl();
            this.tabPageJourneys = new System.Windows.Forms.TabPage();
            this.buttonDeleteUserAddJourneys = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxUsersAdd = new System.Windows.Forms.ListBox();
            this.buttonAddUsersJourneys = new System.Windows.Forms.Button();
            this.comboBoxAddUsers = new System.Windows.Forms.ComboBox();
            this.buttonRemoveJourneys = new System.Windows.Forms.Button();
            this.buttonAddJourneys = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxJourneys = new System.Windows.Forms.TextBox();
            this.labelJourneys = new System.Windows.Forms.Label();
            this.listBoxJourneys = new System.Windows.Forms.ListBox();
            this.tabPageUsers = new System.Windows.Forms.TabPage();
            this.labelTextBoxUserName = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.buttonDeleateUser = new System.Windows.Forms.Button();
            this.buttonEditUsers = new System.Windows.Forms.Button();
            this.buttonUserAdd = new System.Windows.Forms.Button();
            this.labelUsers2 = new System.Windows.Forms.Label();
            this.listBoxUsers = new System.Windows.Forms.ListBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.tabControlAdmin.SuspendLayout();
            this.tabPageJourneys.SuspendLayout();
            this.tabPageUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAdmin
            // 
            this.tabControlAdmin.Controls.Add(this.tabPageJourneys);
            this.tabControlAdmin.Controls.Add(this.tabPageUsers);
            this.tabControlAdmin.Location = new System.Drawing.Point(0, 0);
            this.tabControlAdmin.Name = "tabControlAdmin";
            this.tabControlAdmin.SelectedIndex = 0;
            this.tabControlAdmin.Size = new System.Drawing.Size(510, 444);
            this.tabControlAdmin.TabIndex = 0;
            // 
            // tabPageJourneys
            // 
            this.tabPageJourneys.Controls.Add(this.buttonDeleteUserAddJourneys);
            this.tabPageJourneys.Controls.Add(this.label3);
            this.tabPageJourneys.Controls.Add(this.label2);
            this.tabPageJourneys.Controls.Add(this.listBoxUsersAdd);
            this.tabPageJourneys.Controls.Add(this.buttonAddUsersJourneys);
            this.tabPageJourneys.Controls.Add(this.comboBoxAddUsers);
            this.tabPageJourneys.Controls.Add(this.buttonRemoveJourneys);
            this.tabPageJourneys.Controls.Add(this.buttonAddJourneys);
            this.tabPageJourneys.Controls.Add(this.label1);
            this.tabPageJourneys.Controls.Add(this.textBoxJourneys);
            this.tabPageJourneys.Controls.Add(this.labelJourneys);
            this.tabPageJourneys.Controls.Add(this.listBoxJourneys);
            this.tabPageJourneys.Location = new System.Drawing.Point(4, 22);
            this.tabPageJourneys.Name = "tabPageJourneys";
            this.tabPageJourneys.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageJourneys.Size = new System.Drawing.Size(502, 418);
            this.tabPageJourneys.TabIndex = 0;
            this.tabPageJourneys.Text = "Путешествия";
            this.tabPageJourneys.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteUserAddJourneys
            // 
            this.buttonDeleteUserAddJourneys.Location = new System.Drawing.Point(279, 331);
            this.buttonDeleteUserAddJourneys.Name = "buttonDeleteUserAddJourneys";
            this.buttonDeleteUserAddJourneys.Size = new System.Drawing.Size(214, 43);
            this.buttonDeleteUserAddJourneys.TabIndex = 15;
            this.buttonDeleteUserAddJourneys.Text = "Удалить пользователя списка выбранных";
            this.buttonDeleteUserAddJourneys.UseVisualStyleBackColor = true;
            this.buttonDeleteUserAddJourneys.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(275, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Выбор пользователя";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(8, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 40);
            this.label2.TabIndex = 13;
            this.label2.Text = "Список выбранных \r\nпользователей для путешествия";
            // 
            // listBoxUsersAdd
            // 
            this.listBoxUsersAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listBoxUsersAdd.FormattingEnabled = true;
            this.listBoxUsersAdd.ItemHeight = 20;
            this.listBoxUsersAdd.Location = new System.Drawing.Point(9, 248);
            this.listBoxUsersAdd.Name = "listBoxUsersAdd";
            this.listBoxUsersAdd.ScrollAlwaysVisible = true;
            this.listBoxUsersAdd.Size = new System.Drawing.Size(264, 144);
            this.listBoxUsersAdd.TabIndex = 12;
            this.listBoxUsersAdd.SelectedIndexChanged += new System.EventHandler(this.listBoxUsersAdd_SelectedIndexChanged);
            // 
            // buttonAddUsersJourneys
            // 
            this.buttonAddUsersJourneys.Location = new System.Drawing.Point(279, 282);
            this.buttonAddUsersJourneys.Name = "buttonAddUsersJourneys";
            this.buttonAddUsersJourneys.Size = new System.Drawing.Size(214, 43);
            this.buttonAddUsersJourneys.TabIndex = 11;
            this.buttonAddUsersJourneys.Text = "Добавить пользователя в путешествие";
            this.buttonAddUsersJourneys.UseVisualStyleBackColor = true;
            this.buttonAddUsersJourneys.Click += new System.EventHandler(this.buttonAddUsersJourneys_Click);
            // 
            // comboBoxAddUsers
            // 
            this.comboBoxAddUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAddUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxAddUsers.FormattingEnabled = true;
            this.comboBoxAddUsers.Location = new System.Drawing.Point(279, 248);
            this.comboBoxAddUsers.Name = "comboBoxAddUsers";
            this.comboBoxAddUsers.Size = new System.Drawing.Size(214, 28);
            this.comboBoxAddUsers.TabIndex = 10;
            this.comboBoxAddUsers.SelectedIndexChanged += new System.EventHandler(this.comboBoxAddUsers_SelectedIndexChanged);
            // 
            // buttonRemoveJourneys
            // 
            this.buttonRemoveJourneys.Location = new System.Drawing.Point(279, 136);
            this.buttonRemoveJourneys.Name = "buttonRemoveJourneys";
            this.buttonRemoveJourneys.Size = new System.Drawing.Size(216, 43);
            this.buttonRemoveJourneys.TabIndex = 8;
            this.buttonRemoveJourneys.Text = "Удалить путешествие";
            this.buttonRemoveJourneys.UseVisualStyleBackColor = true;
            this.buttonRemoveJourneys.Click += new System.EventHandler(this.buttonRemoveJourneys_Click);
            // 
            // buttonAddJourneys
            // 
            this.buttonAddJourneys.Location = new System.Drawing.Point(279, 87);
            this.buttonAddJourneys.Name = "buttonAddJourneys";
            this.buttonAddJourneys.Size = new System.Drawing.Size(214, 43);
            this.buttonAddJourneys.TabIndex = 7;
            this.buttonAddJourneys.Text = "Создать путешествие";
            this.buttonAddJourneys.UseVisualStyleBackColor = true;
            this.buttonAddJourneys.Click += new System.EventHandler(this.buttonAddJourneys_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(279, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "Введите название \r\nпутешествия";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxJourneys
            // 
            this.textBoxJourneys.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxJourneys.Location = new System.Drawing.Point(279, 52);
            this.textBoxJourneys.Name = "textBoxJourneys";
            this.textBoxJourneys.Size = new System.Drawing.Size(217, 26);
            this.textBoxJourneys.TabIndex = 5;
            this.textBoxJourneys.TextChanged += new System.EventHandler(this.textBoxJourneys_TextChanged);
            // 
            // labelJourneys
            // 
            this.labelJourneys.AutoSize = true;
            this.labelJourneys.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelJourneys.Location = new System.Drawing.Point(5, 9);
            this.labelJourneys.Name = "labelJourneys";
            this.labelJourneys.Size = new System.Drawing.Size(167, 20);
            this.labelJourneys.TabIndex = 4;
            this.labelJourneys.Text = "Список путешествий";
            this.labelJourneys.Click += new System.EventHandler(this.labelJourneys_Click);
            // 
            // listBoxJourneys
            // 
            this.listBoxJourneys.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxJourneys.FormattingEnabled = true;
            this.listBoxJourneys.HorizontalExtent = 500;
            this.listBoxJourneys.HorizontalScrollbar = true;
            this.listBoxJourneys.ItemHeight = 20;
            this.listBoxJourneys.Location = new System.Drawing.Point(9, 32);
            this.listBoxJourneys.Name = "listBoxJourneys";
            this.listBoxJourneys.ScrollAlwaysVisible = true;
            this.listBoxJourneys.Size = new System.Drawing.Size(264, 164);
            this.listBoxJourneys.TabIndex = 3;
            this.listBoxJourneys.SelectedIndexChanged += new System.EventHandler(this.listBoxJourneys_SelectedIndexChanged);
            // 
            // tabPageUsers
            // 
            this.tabPageUsers.Controls.Add(this.labelTextBoxUserName);
            this.tabPageUsers.Controls.Add(this.textBoxUserName);
            this.tabPageUsers.Controls.Add(this.buttonDeleateUser);
            this.tabPageUsers.Controls.Add(this.buttonEditUsers);
            this.tabPageUsers.Controls.Add(this.buttonUserAdd);
            this.tabPageUsers.Controls.Add(this.labelUsers2);
            this.tabPageUsers.Controls.Add(this.listBoxUsers);
            this.tabPageUsers.Location = new System.Drawing.Point(4, 22);
            this.tabPageUsers.Name = "tabPageUsers";
            this.tabPageUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUsers.Size = new System.Drawing.Size(502, 418);
            this.tabPageUsers.TabIndex = 1;
            this.tabPageUsers.Text = "Пользователи";
            this.tabPageUsers.UseVisualStyleBackColor = true;
            // 
            // labelTextBoxUserName
            // 
            this.labelTextBoxUserName.AutoSize = true;
            this.labelTextBoxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextBoxUserName.Location = new System.Drawing.Point(274, 13);
            this.labelTextBoxUserName.Name = "labelTextBoxUserName";
            this.labelTextBoxUserName.Size = new System.Drawing.Size(109, 20);
            this.labelTextBoxUserName.TabIndex = 9;
            this.labelTextBoxUserName.Text = "Введите имя";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUserName.Location = new System.Drawing.Point(278, 37);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(218, 26);
            this.textBoxUserName.TabIndex = 8;
            // 
            // buttonDeleateUser
            // 
            this.buttonDeleateUser.Location = new System.Drawing.Point(278, 170);
            this.buttonDeleateUser.Name = "buttonDeleateUser";
            this.buttonDeleateUser.Size = new System.Drawing.Size(218, 43);
            this.buttonDeleateUser.TabIndex = 7;
            this.buttonDeleateUser.Text = "Удалить пользователя";
            this.buttonDeleateUser.UseVisualStyleBackColor = true;
            this.buttonDeleateUser.Click += new System.EventHandler(this.buttonDeleateUser_Click);
            // 
            // buttonEditUsers
            // 
            this.buttonEditUsers.Location = new System.Drawing.Point(278, 121);
            this.buttonEditUsers.Name = "buttonEditUsers";
            this.buttonEditUsers.Size = new System.Drawing.Size(218, 43);
            this.buttonEditUsers.TabIndex = 6;
            this.buttonEditUsers.Text = "Изменить имя";
            this.buttonEditUsers.UseVisualStyleBackColor = true;
            this.buttonEditUsers.Click += new System.EventHandler(this.buttonEditUsers_Click);
            // 
            // buttonUserAdd
            // 
            this.buttonUserAdd.Location = new System.Drawing.Point(278, 72);
            this.buttonUserAdd.Name = "buttonUserAdd";
            this.buttonUserAdd.Size = new System.Drawing.Size(218, 43);
            this.buttonUserAdd.TabIndex = 5;
            this.buttonUserAdd.Text = "Добавить пользователя";
            this.buttonUserAdd.UseVisualStyleBackColor = true;
            this.buttonUserAdd.Click += new System.EventHandler(this.buttonUserAdd_Click);
            // 
            // labelUsers2
            // 
            this.labelUsers2.AutoSize = true;
            this.labelUsers2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUsers2.Location = new System.Drawing.Point(5, 13);
            this.labelUsers2.Name = "labelUsers2";
            this.labelUsers2.Size = new System.Drawing.Size(169, 20);
            this.labelUsers2.TabIndex = 1;
            this.labelUsers2.Text = "Лист пользователей";
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.ItemHeight = 20;
            this.listBoxUsers.Location = new System.Drawing.Point(9, 37);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.ScrollAlwaysVisible = true;
            this.listBoxUsers.Size = new System.Drawing.Size(263, 364);
            this.listBoxUsers.TabIndex = 0;
            this.listBoxUsers.SelectedIndexChanged += new System.EventHandler(this.listBoxUsers_SelectedIndexChanged);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(516, 415);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(99, 29);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(516, 380);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(99, 29);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(627, 450);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.tabControlAdmin);
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdmin";
            this.tabControlAdmin.ResumeLayout(false);
            this.tabPageJourneys.ResumeLayout(false);
            this.tabPageJourneys.PerformLayout();
            this.tabPageUsers.ResumeLayout(false);
            this.tabPageUsers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAdmin;
        private System.Windows.Forms.TabPage tabPageJourneys;
        private System.Windows.Forms.TabPage tabPageUsers;
        private System.Windows.Forms.ListBox listBoxUsers;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelUsers2;
        private System.Windows.Forms.Button buttonUserAdd;
        private System.Windows.Forms.Button buttonDeleateUser;
        private System.Windows.Forms.Button buttonEditUsers;
        private System.Windows.Forms.Label labelTextBoxUserName;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Button buttonAddJourneys;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxJourneys;
        private System.Windows.Forms.Label labelJourneys;
        private System.Windows.Forms.ListBox listBoxJourneys;
        private System.Windows.Forms.Button buttonRemoveJourneys;
        private System.Windows.Forms.Button buttonAddUsersJourneys;
        private System.Windows.Forms.ComboBox comboBoxAddUsers;
        private System.Windows.Forms.ListBox listBoxUsersAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDeleteUserAddJourneys;
    }
}