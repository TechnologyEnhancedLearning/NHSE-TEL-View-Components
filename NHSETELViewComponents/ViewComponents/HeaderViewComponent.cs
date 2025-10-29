namespace NHSETELViewComponents.ViewComponents
{
    using Microsoft.AspNetCore.Mvc;
    using NHSETELViewComponents.ViewModels;

    /// <summary>
    /// A ViewComponent that renders a Header.
    /// </summary>
    public class HeaderViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(
            LinkViewModel homeLink,
            List<LinkViewModel>? accountLinks = null,
            List<LinkViewModel>? navigationLinks = null,
            string? searchFolder = null,
            string? searchNavView = null,
            string? searchControllerName = null)
        {
            var model = new HeaderViewModel(homeLink, accountLinks, navigationLinks, searchFolder, searchNavView, searchControllerName);

            return View(model);
        }
    }
}
