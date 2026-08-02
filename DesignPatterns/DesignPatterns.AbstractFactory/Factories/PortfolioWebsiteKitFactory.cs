using DesignPatterns.AbstractFactory.Models.Pages;
using DesignPatterns.AbstractFactory.Models.Themes;
using DesignPatterns.AbstractFactory.Models.Websites;

namespace DesignPatterns.AbstractFactory.Factories
{
    internal class PortfolioWebsiteKitFactory : IWebsiteKitFactory
    {
        public IReadOnlyCollection<Page> CreatePages(WebsiteInstallationRequest request)
        {
            return
            [
                new Page(
                    PageType.Home,
                    "Home",
                    "/",
                    "<h1>Welcome to my portfolio</h1>",
                    "main",
                    true),

                new Page(
                    PageType.Portfolio,
                    "Portfolio",
                    "/portfolio",
                    "<h1>My Projects</h1>",
                    "showcase",
                    true),

                new Page(
                    PageType.Contact,
                    "Contact",
                    "/contact",
                    "<h1>Work With Me</h1>",
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
                    footer: $"Created by {request.WebsiteName}"),

                new MasterPage(
                    key: "showcase",
                    header: string.Empty,
                    footer: "View more projects")
            ];
        }

        public Theme CreateTheme(WebsiteInstallationRequest request)
        {
            return new Theme(
                name: "Creative",
                font: "Poppins",
                primaryColor: "Purple");
        }
    }
}
