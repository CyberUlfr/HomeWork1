
namespace LibraryTravelOrganizer
{
    partial class FormInput
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
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxUsers2 = new System.Windows.Forms.ListBox();
            this.labeInput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(244, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxUsers2
            // 
            this.listBoxUsers2.FormattingEnabled = true;
            this.listBoxUsers2.Location = new System.Drawing.Point(12, 46);
            this.listBoxUsers2.Name = "listBoxUsers2";
            this.listBoxUsers2.Size = new System.Drawing.Size(226, 251);
            this.listBoxUsers2.TabIndex = 1;
            this.listBoxUsers2.SelectedIndexChanged += new System.EventHandler(this.listBoxUsers_SelectedIndexChanged);
            // 
            // labeInput
            // 
            this.labeInput.AutoSize = true;
            this.labeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labeInput.Location = new System.Drawing.Point(12, 19);
            this.labeInput.Name = "labeInput";
            this.labeInput.Size = new System.Drawing.Size(231, 24);
            this.labeInput.TabIndex = 2;
            this.labeInput.Text = "Выбирете пользователя";
            this.labeInput.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 313);
            this.Controls.Add(this.labeInput);
            this.Controls.Add(this.listBoxUsers2);
            this.Controls.Add(this.button1);
            this.Name = "FormInput";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxUsers2;
        private System.Windows.Forms.Label labeInput;
    }
}