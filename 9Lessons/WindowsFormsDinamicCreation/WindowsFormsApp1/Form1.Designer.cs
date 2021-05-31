
namespace WindowsFormsApp1
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
            this.buttonAddCheckBox = new System.Windows.Forms.Button();
            this.checkBoxHideButton = new System.Windows.Forms.CheckBox();
            this.buttonDeleateCheckBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddCheckBox
            // 
            this.buttonAddCheckBox.Location = new System.Drawing.Point(12, 12);
            this.buttonAddCheckBox.Name = "buttonAddCheckBox";
            this.buttonAddCheckBox.Size = new System.Drawing.Size(166, 29);
            this.buttonAddCheckBox.TabIndex = 0;
            this.buttonAddCheckBox.Text = "Создать задачу ";
            this.buttonAddCheckBox.UseVisualStyleBackColor = true;
            this.buttonAddCheckBox.Click += new System.EventHandler(this.buttonAddCheckBox_Click);
            // 
            // checkBoxHideButton
            // 
            this.checkBoxHideButton.AutoSize = true;
            this.checkBoxHideButton.Location = new System.Drawing.Point(282, 68);
            this.checkBoxHideButton.Name = "checkBoxHideButton";
            this.checkBoxHideButton.Size = new System.Drawing.Size(103, 17);
            this.checkBoxHideButton.TabIndex = 1;
            this.checkBoxHideButton.Text = "Скрыть кнопки";
            this.checkBoxHideButton.UseVisualStyleBackColor = true;
            this.checkBoxHideButton.CheckedChanged += new System.EventHandler(this.checkBoxHideButton_CheckedChanged);
            // 
            // buttonDeleateCheckBox
            // 
            this.buttonDeleateCheckBox.Location = new System.Drawing.Point(210, 12);
            this.buttonDeleateCheckBox.Name = "buttonDeleateCheckBox";
            this.buttonDeleateCheckBox.Size = new System.Drawing.Size(174, 29);
            this.buttonDeleateCheckBox.TabIndex = 2;
            this.buttonDeleateCheckBox.Text = "Удалить выполненные задачи";
            this.buttonDeleateCheckBox.UseVisualStyleBackColor = true;
            this.buttonDeleateCheckBox.Click += new System.EventHandler(this.buttonDeleateCheckBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 698);
            this.Controls.Add(this.buttonDeleateCheckBox);
            this.Controls.Add(this.checkBoxHideButton);
            this.Controls.Add(this.buttonAddCheckBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddCheckBox;
        private System.Windows.Forms.CheckBox checkBoxHideButton;
        private System.Windows.Forms.Button buttonDeleateCheckBox;
    }
}

