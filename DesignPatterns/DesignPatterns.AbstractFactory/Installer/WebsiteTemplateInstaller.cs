using DesignPatterns.AbstractFactory.Factories;
using DesignPatterns.AbstractFactory.Models.Navigations;
using DesignPatterns.AbstractFactory.Models.Pages;
using DesignPatterns.AbstractFactory.Models.Themes;
using DesignPatterns.AbstractFactory.Models.Websites;

namespace DesignPatterns.AbstractFactory.Installer
{
    internal class WebsiteTemplateInstaller : IWebsiteTemplateInstaller
    {
        private readonly IWebsiteKitFactory _factory;

        public WebsiteTemplateInstaller(IWebsiteKitFactory factory)
        {
            _factory = factory;
        }

        public Website Install(WebsiteInstallationRequest request)
        {
            // IWebsiteKitFactory: Abstract factory interface that defines methods for creating pages, master pages, and themes.
            IReadOnlyCollection<Page> pages = _factory.CreatePages(request);
            IReadOnlyCollection<MasterPage> masterPages = _factory.CreateMasterPages(request);
            Theme theme = _factory.CreateTheme(request);

            var website = new Website(request.WebsiteName, request.Domain);
            foreach (Page page in pages)
            {
                website.AddPage(page);
            }
            foreach (MasterPage masterPage in masterPages)
            {
                website.AddMasterPage(masterPage);
            }

            website.SetTheme(theme);

            Navigation navigation = NavigationBuilder.Build(pages);

            website.SetNavigation(navigation);

            return website;
        }
    }
}
