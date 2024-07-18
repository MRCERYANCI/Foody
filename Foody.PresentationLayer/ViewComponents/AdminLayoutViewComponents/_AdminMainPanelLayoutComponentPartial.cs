using Microsoft.AspNetCore.Mvc;

namespace Foody.PresentationLayer.ViewComponents.AdminLayoutViewComponents
{
    public class _AdminMainPanelLayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
