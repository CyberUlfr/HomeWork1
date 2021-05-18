using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using travelOrganizer;

namespace WindowsFormsTravelOrginizer
{
    public partial class FormUsers : Form
    {
        public FormUsers()
        {
            InitializeComponent();
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ListBoxPurchaseEditUpdate(List<Purchase> purchases)
        {
            listBoxPurchase.Items.Clear();
            foreach (Purchase elem in purchases)
                listBoxPurchase.Items.Add(elem.Name,elem.Price);
        }
    }
}
