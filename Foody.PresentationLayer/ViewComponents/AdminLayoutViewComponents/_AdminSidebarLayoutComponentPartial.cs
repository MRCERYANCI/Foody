using Microsoft.AspNetCore.Mvc;

namespace Foody.PresentationLayer.ViewComponents.AdminLayoutViewComponents
{
    public class _AdminSidebarLayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
