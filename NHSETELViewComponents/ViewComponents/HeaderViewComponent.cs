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
            Dictionary<string, LinkViewModel>? accountLinks = null,
            List<LinkViewModel>? navigationLinks = null,
            string? searchFolder = null,
            string? searchNavView = null,
            string? searchControllerName = null)
        {
            if (accountLinks == null)
            {
                accountLinks = new Dictionary<string, LinkViewModel>
                {
                    { "logout", new LinkViewModel("Home", "Logout", "Log out", null) },
                    { "account", new LinkViewModel("myaccount", null, "My account", null) }
                };
            }

            var model = new HeaderViewModel(homeLink, accountLinks, navigationLinks, searchFolder, searchNavView, searchControllerName);

            return View(model);
        }
    }
}
