﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace deneme.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult CreateProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult VeriAl(IFormCollection datas)
        {
            var value1 = datas["txtValue1"].ToString();
            var value2 = datas["txtValue2"].ToString();
            var value3 = datas["txtValue3"].ToString();
            return View();
        }
    }
}
