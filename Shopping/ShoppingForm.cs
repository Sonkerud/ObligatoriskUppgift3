using ShoppingLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping
{
    public partial class shoppingForm : Form
    {
        private static List<VarorModel> varorList = new List<VarorModel>();

        var hej = new List<Lista<string, double>>();

        BindingSource shoppingListListBoxBinding = new BindingSource();
        BindingSource dyrasteBinding = new BindingSource();
        BindingSource billigasteBinding = new BindingSource();
        BindingSource summaBinding = new BindingSource();

        public shoppingForm()
        {
            InitializeComponent();
        }
        
        public void DataBinding(List<VarorModel> list) {

            shoppingListListBoxBinding.DataSource = list; 
            shoppingListListBox.DataSource = shoppingListListBoxBinding;
            
            shoppingListListBox.ValueMember = "Display";
            shoppingListListBox.DisplayMember = "Display";

            dyrasteBinding.DataSource = VarorProcessor.MostExpensive(list);
            dyrasteListBox.DataSource = dyrasteBinding;

            billigasteBinding.DataSource = VarorProcessor.Cheapest(list);
            billigasteListBox.DataSource = billigasteBinding;

            dyrasteListBox.ValueMember = "Display";
            dyrasteListBox.DisplayMember = "Display";

            billigasteListBox.ValueMember = "Display";
            billigasteListBox.DisplayMember = "Display";

            
            summaBinding.DataSource = list.Sum(item => item.Price);
            summaListBox.DataSource = summaBinding;

            shoppingListListBoxBinding.ResetBindings(false);
            dyrasteBinding.ResetBindings(false);
            billigasteBinding.ResetBindings(false);
        }

        private void AddVaraButton_Click(object sender, EventArgs e)
        {
            CreateVara();
         }
        private void DeleteVaraButton_Click(object sender, EventArgs e)
        {
            VarorProcessor.DeleteVara(varorList, shoppingListListBox);
            DataBinding(varorList);
        }
 
        public void ClearTextFields(TextBox a, TextBox b)
        {
            a.Text = "";
            b.Text = "";
        }

        public void CreateVara()
        {
            //Validate Input
            bool inmatning = ValidateInput(varansNamnTextBox.Text, varansPrisTextBox.Text);

            if (inmatning)
            {
                //Add new vara
                VarorProcessor.AddVara(varorList, varansNamnTextBox.Text, varansPrisTextBox.Text);
                ClearTextFields(varansNamnTextBox, varansPrisTextBox);
                DataBinding(varorList);
            }
        }

        //Validate Input in Name and Price TextBox
        public bool ValidateInput(string name, string price)
        {
            if (name.Length == 0)
            {
                MessageBox.Show("Fyll i namn på vara");
                return false;
            }

            else if (price.Length == 0)
            {
                MessageBox.Show("Fyll i pris på vara");
                return false;
            }
            else
            {
                return true;
            }
            
        }

        //Only allow numbers in Price Textbox
        private void VaransPrisTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        // Press Enter after price in Price textbox activates "AddVara()"
        private void VaransPrisTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CreateVara();
            }
        }
    }
}
