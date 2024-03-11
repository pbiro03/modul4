using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4.Models
{
    public class Chocolate : ObservableObject
    {
        private string type;

        public string Type
        {
            get { return type; }
            set { SetProperty(ref type, value); }
        }
        private int price;

        public int Price
        {
            get { return price; }
            set { SetProperty(ref price, value); }
        }
        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { SetProperty(ref quantity, value); }
        }

        public Chocolate GetCopy()
        {
            return new Chocolate()
            {
                Type = this.Type,
                Price = this.Price
            };
        }
    }
}
