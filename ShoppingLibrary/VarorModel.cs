using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingLibrary
{
    public class VarorModel/* : INotifyPropertyChanged*/
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        //private string name;
        //private decimal price;

        //public string Name
        //{
        //    get { return this.name; }

        //    set
        //    {
        //        if (this.name != value)
        //        {
        //            this.name = value;
        //            this.NotifyPropertyChanged("Name");
        //        }
        //    }
        //}


        //public decimal Price
        //{
        //    get => price;
        //    set
        //    {
        //        if (this.price != value)
        //        {
        //            this.price = value;
        //            this.NotifyPropertyChanged("Price");
        //        }
        //    }
        //}


        public VarorModel(string namn, decimal pris)
        {
            Price = pris;
            Name = namn;
        }

        public VarorModel()
        {

        }


        public string Display
        {
            get { return string.Format("{0} - Pris: {1} kronor", Name, Price); }
        }

        //public event PropertyChangedEventHandler PropertyChanged;

        //public void NotifyPropertyChanged(string propName)
        //{
        //    if (this.PropertyChanged != null)
        //        this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        //}
    }

}




