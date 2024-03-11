using CommunityToolkit.Mvvm.Messaging;

using modul4.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4.ChocholateLogic
{
    public class ChocolateLogic
    {
        IList<Chocolate> chocolates;
        IMessenger M;
        private int _income;
        public int Income
        {
            get
            {
                return chocolates.Count == 0 ? 0 : chocolates.Sum(t => t.Price * t.Quantity);
                //return _income;
            }
            set
            {
                _income = value;
            }
        }

        public ChocolateLogic(IList<Chocolate> l)
        {
            this.chocolates = l;
        }

        public void BuySnack(Chocolate c)
        {
            c.Quantity -= 1; //TODO: 0 ala nem mehet
            //Income += c.Price;
            //M.Send("Buying Snack","SnackInfo");
        }

        public void AddSnack()
        {

        }

        public void RemoveSnack(Chocolate c)
        {
            chocolates.Remove(c);
        }

        public void EditSnack()
        {

        }
    }
}
