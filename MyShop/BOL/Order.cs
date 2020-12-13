using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.BOL
{
    public class Order
    {
        public int OrderID { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public Double ShippingCost { get; set; }


        public Order(DataRow dr)
        {
            OrderID = dr.Field<int>("OrderID");
            CompanyName = dr.Field<string>("CompanyName");
            Address = dr.Field<string>("Address");
            City = dr.Field<string>("City");
            Region = dr.Field<string>("Region");
            ShippingCost = dr.Field<Double>("ShippingCost");
        }
    }
}
