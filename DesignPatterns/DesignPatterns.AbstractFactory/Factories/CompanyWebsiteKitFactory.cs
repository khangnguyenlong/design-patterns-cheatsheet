using DesignPatterns.AbstractFactory.Models.Pages;
using DesignPatterns.AbstractFactory.Models.Themes;
using DesignPatterns.AbstractFactory.Models.Websites;

namespace DesignPatterns.AbstractFactory.Factories
{
    internal class CompanyWebsiteKitFactory : IWebsiteKitFactory
    {
        public IReadOnlyCollection<Page> CreatePages(WebsiteInstallationRequest request)
        {
            return
            [
                new Page(
                PageType.Home,
                "Home",
                "/",
                "<h1>Welcome to our company</h1>",
                "main",
                true),

                new Page(
                    PageType.About,
                    "About Us",
                    "/about",
                    "<h1>About Our Company</h1>",
                    "main",
                    true),

                new Page(
                    PageType.Contact,
                    "Contact",
                    "/contact",
                    "<h1>Contact Us</h1>",
                    "main",
                    true)
            ];
        }

        public IReadOnlyCollection<MasterPage> CreateMasterPages(WebsiteInstallationRequest request)
        {
            return
            [
                new MasterPage(
                key: "main",
                header: request.WebsiteName,
                footer: $"© 2026 {request.WebsiteName}")
            ];
        }

        public Theme CreateTheme(WebsiteInstallationRequest request)
        {
            return new Theme(
                name: "Corporate",
                font: "Arial",
                primaryColor: "Blue");
        }
    }
}
