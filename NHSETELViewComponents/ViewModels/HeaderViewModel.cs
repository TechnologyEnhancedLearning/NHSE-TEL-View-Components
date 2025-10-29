namespace NHSETELViewComponents.ViewModels
{
    public class HeaderViewModel
    {
        public HeaderViewModel(
            LinkViewModel homeLink,
            List<LinkViewModel>? accountLinks,
            List<LinkViewModel>? navigationLinks,
            string? searchFolder = null,
            string? searchNavView = null,
            string? searchControllerName = null
            )
        {
            HomeLink = homeLink;
            AccountLinks = accountLinks;
            NavigationLinks = navigationLinks;
            SearchFolder = searchFolder;
            SearchNavView = searchNavView;
            SearchControllerName = searchControllerName;
        }

        public LinkViewModel HomeLink { get; set; }

        public List<LinkViewModel>? AccountLinks { get; set; }

        public List<LinkViewModel>? NavigationLinks { get; set; }

        public string? SearchFolder { get; set; }

        public string? SearchNavView { get; set; }

        public string? SearchControllerName { get; set; }

    }
}
