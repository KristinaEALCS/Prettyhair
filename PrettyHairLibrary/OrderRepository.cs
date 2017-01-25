using System;
using System.Collections.Generic;
using PrettyHairLibrary;

namespace PrettyHairLibrary
{

    public class OrderRepository
    {
        public OrderRepository oRep;
        public event TickHandler Tick;
        public EventArgs e = null;
        public delegate void TickHandler(OrderRepository m, EventArgs e);
        private List<Order> _orders = new List<Order>();

        private static OrderRepository instance;

        public static OrderRepository Instance
        {
            get
            {
                if(instance == null) { instance = new OrderRepository(); }
                return instance;
            }
        }

        private OrderRepository() { }

        public void Add(Order o)
        {
            _orders.Add(o);
            this.ReceivedOrderNotification(o);
            if (!o.CheckQuantity()) NotifPurchaserAboutAmount(o); 
        }

        private void ReceivedOrderNotification(Order o)
        {
            Tick?.Invoke(this, e);
        }

        private void NotifPurchaserAboutAmount(Order o)
        {
            Tick?.Invoke(this, e);
        }


        public void Remove(Order o) {
            _orders.Remove(o);
        }

        public void Remove(int orderid)
        {
            _orders.Remove(FindOrder(orderid));
        }

        public Order FindOrder(int orderid)
        {
            Order o = null;
            foreach (Order ord in _orders)
            {
                if (ord.OrderId == orderid) o = ord;
            }
            return o;
        }

        public Order GetOrder(int orderid)
        {
            return FindOrder(orderid);
        }
        //Local version, make DB query instead
        public List<Order> GetUnproccessedOrders()
        {
            List<Order> orders = new List<Order>();
            foreach (Order ord in _orders)
            {
               if ((ord.ProcessStatus == picked.NotProcessed)) orders.Add(ord);
            }
            return orders;
        }

    }
}
