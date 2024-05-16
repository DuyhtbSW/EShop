﻿using AdvancedEshop.Data;
using AdvancedEshop.Infrastructure;
using AdvancedEshop.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdvancedEshop.Components
{
    public class CartWidget : ViewComponent
    {
       
        public IViewComponentResult Invoke()
        {
            return View(HttpContext.Session.GetJson<Cart>("cart"));
        }
    }
}
