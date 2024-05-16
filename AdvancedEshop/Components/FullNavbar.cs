using AdvancedEshop.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AdvancedEshop.Components
{
    public class FullNavbar : ViewComponent
    {
        private readonly ApplicationDbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public FullNavbar(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        public IViewComponentResult Invoke()
        {
            var path = _httpContextAccessor.HttpContext.Request.Path.ToString().ToLower();

            // Do not render the navbar on login and register pages
            if (path.Contains("/account/login") || path.Contains("/account/register"))
            {
                return Content(string.Empty);
            }

            return View(_context.Categories.ToList());
        }
    }
}
