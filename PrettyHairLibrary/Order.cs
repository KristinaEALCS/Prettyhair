using System;
using System.Collections.Generic;

namespace PrettyHairLibrary
{

    public enum picked
    {
        Processed,
        NotProcessed,
        BeingProcessed,
        Canceled
    }
    public class Order : EventArgs
    {
        // Unique key for the product, and then the amount of this product in the order
        Dictionary<ProductType, int> orderlines = new Dictionary<ProductType, int>();
        private string deliveryDate;
        private string orderDate;
        public picked ProcessStatus { get; set; }
        public int OrderId { get; private set; } 
        
        public Order(int orderid, string dd,string od, Dictionary<ProductType, int> ol)
        {
            orderlines = ol;
            deliveryDate = dd;
            orderDate = od;
            this.OrderId = orderid;
            this.ProcessStatus = picked.NotProcessed;
        }
        public Order()
        {

        }
        
        public bool CheckQuantity()
        {
            bool cond = true;

            foreach(KeyValuePair<ProductType,int> p in orderlines)
            {
                if (p.Key.Amount < p.Value) {
                    cond = false;
                }
            }
            return cond;
        }

        public Dictionary<ProductType, int> GetOrderLines()
        {
            return orderlines;
        }

        public override string ToString()
        {
            string orderString = "order [deliverydate="+ this.deliveryDate +", orderdate="+this.orderDate+"]";
            return orderString;
        }
    }
}
