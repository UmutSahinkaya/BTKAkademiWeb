using Microsoft.AspNetCore.Mvc;

namespace BTKAkademiWeb.MVC.Components
{
    public class ProductFilterMenuViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}