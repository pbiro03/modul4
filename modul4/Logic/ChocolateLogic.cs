using modul4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4.ChocholateLogic
{
    public class ChocolateLogic
    {
        IList<Chocolate> chocolates;
        public int Income
        {
            get
            {
                return chocolates.Count == 0 ? 0 : chocolates.Sum(t => t.Price);
            }
        }

        public void BuySnack(Chocolate c)
        {

        }
    }
}
