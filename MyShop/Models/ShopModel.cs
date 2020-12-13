using MyShop.BOL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.Models
{
    public class ShopModel
    {
        public List<Order> OrderList { get; set; }

        const string QUERY_GetAllOrders = @"
SELECT O.*,C.CompanyName , 0 AS CostInEdit, 0 AS NameInEdit
FROM Orders O
JOIN Customers C ON C.CustomerID = O.CustomerID
";

        

        public ShopModel()
        {
            OrderList = GetAllOrders();
        }

        

        public List<Order> GetAllOrders()
        {
            DataTable dt = DataAdapter.GetData(QUERY_GetAllOrders);
            if (dt != null && dt.Rows.Count > 0)
                return dt.AsEnumerable().Select(r =>
                new Order(r)).ToList();
            else
                return new List<Order>();
        }
         
    }
}
