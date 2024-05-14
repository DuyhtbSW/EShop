using Microsoft.AspNetCore.Mvc;

namespace AdvancedEshop.Controllers
{
    public class CartController : Controller
    {
        public IActionResult AddToCart(int productId)
        {
            return View();
        }
    }
}
