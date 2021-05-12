using System;
using System.Windows.Forms;
using System.Linq;

namespace WindowsFormsTravelOrginizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void listBoxSelectedName(object sender, EventArgs e)
        {
            foreach (var user in travelOrganizer.User.Users)
            {
                if (!user.IsAdmin)
                {
                    
                }
                else
                {
                    var admin = travelOrganizer.User.Users.First(username => username == user);
                }
            }

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            listBoxUsers.Items.Clear();
            foreach (var user in travelOrganizer.User.Users)
                listBoxUsers.Items.Add(user.Name);
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }
    }
}
