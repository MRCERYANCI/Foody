using Microsoft.AspNetCore.Mvc;

namespace Foody.PresentationLayer.ViewComponents.AdminLayoutViewComponents
{
    public class _AdminHeadLayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
