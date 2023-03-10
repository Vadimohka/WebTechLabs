using Microsoft.AspNetCore.Mvc;
using WebApplication1.Extensions;
using WebApplication1.Models;

namespace WebApplication1.Components
{
    public class CartViewComponent : ViewComponent
    {
        private Cart _cart;
        public CartViewComponent(Cart cart)
        {
            _cart = cart;
        }
        public IViewComponentResult Invoke()
        {
            return View(_cart);
        }
    }
}
