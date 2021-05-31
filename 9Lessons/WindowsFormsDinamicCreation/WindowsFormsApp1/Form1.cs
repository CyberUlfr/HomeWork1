using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public static List<CheckBox> CheckBoxes = new List<CheckBox>();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAddCheckBox_Click(object sender, EventArgs e)
        {
            {
                CheckBox newCheckBox = new CheckBox();
                CheckBox lastOldCheckBox = CheckBoxes.LastOrDefault();
                int a = 1;
                if (lastOldCheckBox == null)
                {
                    newCheckBox.Location = new Point(30, 50);
                    newCheckBox.Text = $"Задача {a}";
                }
                else
                {
                    newCheckBox.Location = new Point(lastOldCheckBox.Location.X, lastOldCheckBox.Location.Y + 30);
                    newCheckBox.Text = $"Задача {CheckBoxes.Count + 1}";
                }
                CheckBoxes.Add(newCheckBox);
                Controls.Add(newCheckBox);
            }
        }
        private void buttonDeleateCheckBox_Click(object sender, EventArgs e)
        {
            foreach (CheckBox chekCheckBox in CheckBoxes)
            {
                if (chekCheckBox.Checked)
                {
                    Controls.Remove(chekCheckBox);
                }
            }
        }

        private void checkBoxHideButton_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHideButton.Checked)
            {
                buttonDeleateCheckBox.Visible = false;
                buttonAddCheckBox.Visible = false;
            }
            else
            {
                buttonDeleateCheckBox.Visible = true;
                buttonAddCheckBox.Visible = true;
            }
        }
    }
}
