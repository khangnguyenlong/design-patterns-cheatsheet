using DesignPatterns.AbstractFactory.Models.Pages;
using DesignPatterns.AbstractFactory.Models.Themes;
using DesignPatterns.AbstractFactory.Models.Websites;

namespace DesignPatterns.AbstractFactory.Factories
{
    internal interface IWebsiteKitFactory
    {
        IReadOnlyCollection<Page> CreatePages(WebsiteInstallationRequest request);

        IReadOnlyCollection<MasterPage> CreateMasterPages(WebsiteInstallationRequest request);

        Theme CreateTheme(WebsiteInstallationRequest request);
    }
}