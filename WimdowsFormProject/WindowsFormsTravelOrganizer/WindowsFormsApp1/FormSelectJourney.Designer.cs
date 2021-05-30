
namespace WindowsFormsApp1
{
    partial class FormSelectJourney
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
            this.comboBoxSelectJourney = new System.Windows.Forms.ComboBox();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelSelectJourney = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxSelectJourney
            // 
            this.comboBoxSelectJourney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSelectJourney.FormattingEnabled = true;
            this.comboBoxSelectJourney.Location = new System.Drawing.Point(36, 69);
            this.comboBoxSelectJourney.Name = "comboBoxSelectJourney";
            this.comboBoxSelectJourney.Size = new System.Drawing.Size(260, 28);
            this.comboBoxSelectJourney.TabIndex = 0;
            this.comboBoxSelectJourney.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectJourney_SelectedIndexChanged);
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(36, 128);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(260, 39);
            this.buttonSelect.TabIndex = 1;
            this.buttonSelect.Text = "Выбрать";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(36, 173);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(260, 43);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelSelectJourney
            // 
            this.labelSelectJourney.AutoSize = true;
            this.labelSelectJourney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSelectJourney.Location = new System.Drawing.Point(12, 33);
            this.labelSelectJourney.Name = "labelSelectJourney";
            this.labelSelectJourney.Size = new System.Drawing.Size(193, 20);
            this.labelSelectJourney.TabIndex = 3;
            this.labelSelectJourney.Text = "Выбирите путешествие,\r\n";
            this.labelSelectJourney.Click += new System.EventHandler(this.labelSelectJourney_Click);
            // 
            // FormSelectJourney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 281);
            this.Controls.Add(this.labelSelectJourney);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.comboBoxSelectJourney);
            this.Name = "FormSelectJourney";
            this.Text = "SelectJourney";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSelectJourney;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelSelectJourney;
    }
}