using System.Collections.Generic;

namespace labo2
{
    public class Sales
    {
        private Dictionary<phone, List<Sale>> history_;

        public struct Sale
        {
            public int date;
            public description good;
            public int quantity;
        }

        public void AddSale(int date, description good, int quantity)
        {
            
            Sale sale = new Sale { date = date, good = good, quantity = quantity };

            
            phone group = good.GetGroup();
            if (!history_.ContainsKey(group))
                history_.Add(group, new List<Sale>());

            
            history_[group].Add(sale);
        }

        public double GetPriceByGroup(phone group)
        {
            double price = 0;

           
            if (history_.ContainsKey(group))
            {
                
                foreach (Sale sale in history_[group])
                    price += sale.good.GetPrice() * sale.quantity;
            }

            return price;
        }
    }
}
