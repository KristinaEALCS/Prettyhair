using PrettyHairLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{

    public class MyViewModel
    {

        OrderRepository oRep = new OrderRepository();
        ProductTypeRepository proRep = new ProductTypeRepository();

        public List<Order> checkInventory() {
            return oRep.GetUnproccessedOrders();
        }
    }

}
