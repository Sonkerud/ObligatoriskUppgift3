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

        BindingSource shoppingListListBoxBinding = new BindingSource();
        BindingSource dyrasteBinding = new BindingSource();
        BindingSource billigasteBinding = new BindingSource();
        BindingSource summaBinding = new BindingSource();

        public shoppingForm()
        {
            InitializeComponent();
        }
        
        private void DataBinding(List<VarorModel> list) {

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

            summaBinding.DataSource = VarorProcessor.Sum(list);
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
            VarorProcessor.DeleteVara(VarorModel.listOfVaror, shoppingListListBox);
            DataBinding(VarorModel.listOfVaror);
        }
 
        private void ClearTextFields(TextBox a, TextBox b)
        {
            a.Text = "";
            b.Text = "";
        }

        private void CreateVara()
        {
            //Validate Input
            bool inmatning = ValidateInputClass.ValidateInput(varansNamnTextBox.Text, varansPrisTextBox.Text);

            if (inmatning)
            {
                //Add new vara
                VarorProcessor.AddVara(VarorModel.listOfVaror, varansNamnTextBox.Text, varansPrisTextBox.Text);
                ClearTextFields(varansNamnTextBox, varansPrisTextBox);
                DataBinding(VarorModel.listOfVaror);
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
