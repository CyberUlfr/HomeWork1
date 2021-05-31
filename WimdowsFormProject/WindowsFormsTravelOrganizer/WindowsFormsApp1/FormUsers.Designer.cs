
namespace WindowsFormsApp1
{
    partial class FormUsers
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
            this.tabControlUsers = new System.Windows.Forms.TabControl();
            this.tabPagePurchase = new System.Windows.Forms.TabPage();
            this.labelPricePurchase = new System.Windows.Forms.Label();
            this.labelNamePurchase = new System.Windows.Forms.Label();
            this.textBoxPricePurchase = new System.Windows.Forms.TextBox();
            this.textBoxNamePurchase = new System.Windows.Forms.TextBox();
            this.buttonSortedDescending = new System.Windows.Forms.Button();
            this.buttonSortedIncrease = new System.Windows.Forms.Button();
            this.buttonRubInDollar = new System.Windows.Forms.Button();
            this.buttonSumPurchase = new System.Windows.Forms.Button();
            this.buttonDeleatePurchase = new System.Windows.Forms.Button();
            this.buttonAddPurchase = new System.Windows.Forms.Button();
            this.labelListPurchase = new System.Windows.Forms.Label();
            this.listBoxPurchase = new System.Windows.Forms.ListBox();
            this.tabPageDistance = new System.Windows.Forms.TabPage();
            this.tabPageStatistic = new System.Windows.Forms.TabPage();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.tabControlUsers.SuspendLayout();
            this.tabPagePurchase.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlUsers
            // 
            this.tabControlUsers.Controls.Add(this.tabPagePurchase);
            this.tabControlUsers.Controls.Add(this.tabPageDistance);
            this.tabControlUsers.Controls.Add(this.tabPageStatistic);
            this.tabControlUsers.Location = new System.Drawing.Point(0, 12);
            this.tabControlUsers.Name = "tabControlUsers";
            this.tabControlUsers.SelectedIndex = 0;
            this.tabControlUsers.Size = new System.Drawing.Size(618, 435);
            this.tabControlUsers.TabIndex = 0;
            // 
            // tabPagePurchase
            // 
            this.tabPagePurchase.Controls.Add(this.labelPricePurchase);
            this.tabPagePurchase.Controls.Add(this.labelNamePurchase);
            this.tabPagePurchase.Controls.Add(this.textBoxPricePurchase);
            this.tabPagePurchase.Controls.Add(this.textBoxNamePurchase);
            this.tabPagePurchase.Controls.Add(this.buttonSortedDescending);
            this.tabPagePurchase.Controls.Add(this.buttonSortedIncrease);
            this.tabPagePurchase.Controls.Add(this.buttonRubInDollar);
            this.tabPagePurchase.Controls.Add(this.buttonSumPurchase);
            this.tabPagePurchase.Controls.Add(this.buttonDeleatePurchase);
            this.tabPagePurchase.Controls.Add(this.buttonAddPurchase);
            this.tabPagePurchase.Controls.Add(this.labelListPurchase);
            this.tabPagePurchase.Controls.Add(this.listBoxPurchase);
            this.tabPagePurchase.Location = new System.Drawing.Point(4, 22);
            this.tabPagePurchase.Name = "tabPagePurchase";
            this.tabPagePurchase.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePurchase.Size = new System.Drawing.Size(610, 409);
            this.tabPagePurchase.TabIndex = 2;
            this.tabPagePurchase.Text = "Покупки";
            this.tabPagePurchase.UseVisualStyleBackColor = true;
            // 
            // labelPricePurchase
            // 
            this.labelPricePurchase.AutoSize = true;
            this.labelPricePurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPricePurchase.Location = new System.Drawing.Point(397, 58);
            this.labelPricePurchase.Name = "labelPricePurchase";
            this.labelPricePurchase.Size = new System.Drawing.Size(189, 20);
            this.labelPricePurchase.TabIndex = 11;
            this.labelPricePurchase.Text = "Введите цену продукта";
            // 
            // labelNamePurchase
            // 
            this.labelNamePurchase.AutoSize = true;
            this.labelNamePurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNamePurchase.Location = new System.Drawing.Point(397, 3);
            this.labelNamePurchase.Name = "labelNamePurchase";
            this.labelNamePurchase.Size = new System.Drawing.Size(184, 20);
            this.labelNamePurchase.TabIndex = 10;
            this.labelNamePurchase.Text = "Введите имя продукта";
            // 
            // textBoxPricePurchase
            // 
            this.textBoxPricePurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPricePurchase.Location = new System.Drawing.Point(401, 81);
            this.textBoxPricePurchase.Name = "textBoxPricePurchase";
            this.textBoxPricePurchase.Size = new System.Drawing.Size(197, 26);
            this.textBoxPricePurchase.TabIndex = 9;
            // 
            // textBoxNamePurchase
            // 
            this.textBoxNamePurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNamePurchase.Location = new System.Drawing.Point(401, 26);
            this.textBoxNamePurchase.Name = "textBoxNamePurchase";
            this.textBoxNamePurchase.Size = new System.Drawing.Size(197, 26);
            this.textBoxNamePurchase.TabIndex = 8;
            // 
            // buttonSortedDescending
            // 
            this.buttonSortedDescending.Location = new System.Drawing.Point(401, 350);
            this.buttonSortedDescending.Name = "buttonSortedDescending";
            this.buttonSortedDescending.Size = new System.Drawing.Size(197, 40);
            this.buttonSortedDescending.TabIndex = 7;
            this.buttonSortedDescending.Text = "Сортировать по убыванию";
            this.buttonSortedDescending.UseVisualStyleBackColor = true;
            // 
            // buttonSortedIncrease
            // 
            this.buttonSortedIncrease.Location = new System.Drawing.Point(401, 304);
            this.buttonSortedIncrease.Name = "buttonSortedIncrease";
            this.buttonSortedIncrease.Size = new System.Drawing.Size(197, 40);
            this.buttonSortedIncrease.TabIndex = 6;
            this.buttonSortedIncrease.Text = "Сортировать по возрастанию";
            this.buttonSortedIncrease.UseVisualStyleBackColor = true;
            // 
            // buttonRubInDollar
            // 
            this.buttonRubInDollar.Location = new System.Drawing.Point(401, 258);
            this.buttonRubInDollar.Name = "buttonRubInDollar";
            this.buttonRubInDollar.Size = new System.Drawing.Size(197, 40);
            this.buttonRubInDollar.TabIndex = 5;
            this.buttonRubInDollar.Text = "Перевести цену из руб. в доллары";
            this.buttonRubInDollar.UseVisualStyleBackColor = true;
            this.buttonRubInDollar.Click += new System.EventHandler(this.buttonRubInDollar_Click);
            // 
            // buttonSumPurchase
            // 
            this.buttonSumPurchase.Location = new System.Drawing.Point(401, 212);
            this.buttonSumPurchase.Name = "buttonSumPurchase";
            this.buttonSumPurchase.Size = new System.Drawing.Size(197, 40);
            this.buttonSumPurchase.TabIndex = 4;
            this.buttonSumPurchase.Text = "Посчитать общую стоймость";
            this.buttonSumPurchase.UseVisualStyleBackColor = true;
            this.buttonSumPurchase.Click += new System.EventHandler(this.buttonSumPurchase_Click);
            // 
            // buttonDeleatePurchase
            // 
            this.buttonDeleatePurchase.Location = new System.Drawing.Point(401, 166);
            this.buttonDeleatePurchase.Name = "buttonDeleatePurchase";
            this.buttonDeleatePurchase.Size = new System.Drawing.Size(197, 40);
            this.buttonDeleatePurchase.TabIndex = 3;
            this.buttonDeleatePurchase.Text = "Удалить продукт из списка";
            this.buttonDeleatePurchase.UseVisualStyleBackColor = true;
            this.buttonDeleatePurchase.Click += new System.EventHandler(this.buttonDeleatePurchase_Click);
            // 
            // buttonAddPurchase
            // 
            this.buttonAddPurchase.Location = new System.Drawing.Point(401, 120);
            this.buttonAddPurchase.Name = "buttonAddPurchase";
            this.buttonAddPurchase.Size = new System.Drawing.Size(197, 40);
            this.buttonAddPurchase.TabIndex = 2;
            this.buttonAddPurchase.Text = "Добавить продукт";
            this.buttonAddPurchase.UseVisualStyleBackColor = true;
            this.buttonAddPurchase.Click += new System.EventHandler(this.buttonAddPurchase_Click);
            // 
            // labelListPurchase
            // 
            this.labelListPurchase.AutoSize = true;
            this.labelListPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelListPurchase.Location = new System.Drawing.Point(6, 3);
            this.labelListPurchase.Name = "labelListPurchase";
            this.labelListPurchase.Size = new System.Drawing.Size(126, 20);
            this.labelListPurchase.TabIndex = 1;
            this.labelListPurchase.Text = "Список покупок";
            // 
            // listBoxPurchase
            // 
            this.listBoxPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxPurchase.FormattingEnabled = true;
            this.listBoxPurchase.ItemHeight = 20;
            this.listBoxPurchase.Location = new System.Drawing.Point(6, 26);
            this.listBoxPurchase.Name = "listBoxPurchase";
            this.listBoxPurchase.Size = new System.Drawing.Size(389, 364);
            this.listBoxPurchase.TabIndex = 0;
            this.listBoxPurchase.SelectedIndexChanged += new System.EventHandler(this.listBoxPurchase_SelectedIndexChanged);
            // 
            // tabPageDistance
            // 
            this.tabPageDistance.Location = new System.Drawing.Point(4, 22);
            this.tabPageDistance.Name = "tabPageDistance";
            this.tabPageDistance.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDistance.Size = new System.Drawing.Size(610, 409);
            this.tabPageDistance.TabIndex = 3;
            this.tabPageDistance.Text = "Передвижения";
            this.tabPageDistance.UseVisualStyleBackColor = true;
            // 
            // tabPageStatistic
            // 
            this.tabPageStatistic.Location = new System.Drawing.Point(4, 22);
            this.tabPageStatistic.Name = "tabPageStatistic";
            this.tabPageStatistic.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStatistic.Size = new System.Drawing.Size(610, 409);
            this.tabPageStatistic.TabIndex = 4;
            this.tabPageStatistic.Text = "Статистика";
            this.tabPageStatistic.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(624, 356);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(96, 40);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(624, 402);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(96, 40);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 454);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.tabControlUsers);
            this.Name = "FormUsers";
            this.Text = "FormUsers";
            this.tabControlUsers.ResumeLayout(false);
            this.tabPagePurchase.ResumeLayout(false);
            this.tabPagePurchase.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlUsers;
        private System.Windows.Forms.TabPage tabPagePurchase;
        private System.Windows.Forms.Button buttonSortedDescending;
        private System.Windows.Forms.Button buttonSortedIncrease;
        private System.Windows.Forms.Button buttonRubInDollar;
        private System.Windows.Forms.Button buttonSumPurchase;
        private System.Windows.Forms.Button buttonDeleatePurchase;
        private System.Windows.Forms.Button buttonAddPurchase;
        private System.Windows.Forms.Label labelListPurchase;
        private System.Windows.Forms.ListBox listBoxPurchase;
        private System.Windows.Forms.TabPage tabPageDistance;
        private System.Windows.Forms.TabPage tabPageStatistic;
        private System.Windows.Forms.Label labelPricePurchase;
        private System.Windows.Forms.Label labelNamePurchase;
        private System.Windows.Forms.TextBox textBoxPricePurchase;
        private System.Windows.Forms.TextBox textBoxNamePurchase;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonExit;
    }
}