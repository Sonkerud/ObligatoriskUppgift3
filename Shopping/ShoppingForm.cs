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

        
        public void DataBinding() {

            shoppingListListBoxBinding.DataSource = varorList; 
            shoppingListListBox.DataSource = shoppingListListBoxBinding;
            
            shoppingListListBox.ValueMember = "Display";
            shoppingListListBox.DisplayMember = "Display";

            dyrasteBinding.DataSource = Dyraste();
            dyrasteListBox.DataSource = dyrasteBinding;

            billigasteBinding.DataSource = Billigaste();
            billigasteListBox.DataSource = billigasteBinding;

            dyrasteListBox.ValueMember = "Display";
            dyrasteListBox.DisplayMember = "Display";

            billigasteListBox.ValueMember = "Display";
            billigasteListBox.DisplayMember = "Display";

            
            summaBinding.DataSource = varorList.Sum(item => item.Price);
            summaListBox.DataSource = summaBinding;

            shoppingListListBoxBinding.ResetBindings(false);
            dyrasteBinding.ResetBindings(false);
            billigasteBinding.ResetBindings(false);
                      

        }


        private void AddVaraButton_Click(object sender, EventArgs e)
        {
            //Kontrollera inmatning
            bool inmatning = KontrolleraInmatning();

            if (inmatning)
            {

                //Lägg till vara. Ta värden från textfält
                AddVara();
                
                DataBinding();

            }
         }

        public void AddVara()
        {
            VarorModel model = new VarorModel(
               varansNamnTextBox.Text,
               decimal.Parse(varansPrisTextBox.Text)
               );

            //kontrollera om inmatadvara redan finns. Om den finns. Uppdatera priset.
            var found = varorList.Any(x => x.Name.ToLower() == model.Name.ToLower());

            for (int i = 0; i < varorList.Count; i++)
            {
                if (varorList[i].Name.ToLower() == model.Name.ToLower())
                {
                    varorList[i].Price = model.Price;
                }
            }

            //Om den inte finns - Lägg till i listan.
            if (!found)
            {
                varorList.Add(model);
             }

            //Rensa textfält
            varansNamnTextBox.Text = "";
            varansPrisTextBox.Text = "";
        }

        private void TaBortVaraButton_Click(object sender, EventArgs e)
        {
            VarorModel selectedVara = (VarorModel)shoppingListListBox.SelectedItem;
            varorList.Remove(selectedVara);

            DataBinding();

        }

        public bool KontrolleraInmatning()
        {
            if (varansNamnTextBox.Text.Length == 0)
            {
                MessageBox.Show("Fyll i namn på vara");
                return false;
            }

            else if (varansPrisTextBox.Text.Length == 0)
            {
                MessageBox.Show("Fyll i pris på vara");
                return false;
            } else
            {
                return true;
            }
            
        }

        //Räkna ut dyraste och billigaste vara
        public VarorModel Dyraste()
        {
            decimal maxPrice = varorList.Max(t => t.Price);
            VarorModel model = new VarorModel();

            for (int i = 0; i < varorList.Count; i++)
            {
                if (varorList[i].Price == maxPrice)
                {
                    model =  varorList[i];
                }
            }

            return model;

            
        }
        public VarorModel Billigaste()
        {
            decimal minPrice = varorList.Min(t => t.Price);
            VarorModel model = new VarorModel();

            for (int i = 0; i < varorList.Count; i++)
            {
                if (varorList[i].Price == minPrice)
                {
                    model = varorList[i];
                }
            }

            return model;
        }

        //Endast siffror i rutan för pris
        private void VaransPrisTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != ','))
            {
                e.Handled = true;
            }


        }

        
    }
}
