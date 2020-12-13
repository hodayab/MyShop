using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyShop.BOL;
using MyShop.Models;

namespace MyShop.Controllers
{
    [Route("api/Shop")]
    public class ShopController : Controller
    {
        [HttpGet, Route("AllOrders")]
        public ActionResult<ShopModel> GetAll()
        {
            ShopModel result = new ShopModel();
            return result;
        }
    }
}