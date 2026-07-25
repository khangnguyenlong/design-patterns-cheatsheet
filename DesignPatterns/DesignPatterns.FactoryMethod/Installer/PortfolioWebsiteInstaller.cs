using DesignPatterns.FactoryMethod.Factories;
using DesignPatterns.FactoryMethod.Models;

namespace DesignPatterns.FactoryMethod.Installer
{
    internal class PortfolioWebsiteInstaller : WebsiteTemplateInstaller
    {
        // Factory method: The subclass decides which pages to create.
        protected override IReadOnlyCollection<Page> CreatePages(WebsiteInstallationRequest request)
        {
            return new List<Page>
            {
                PageFactory.Create(PageType.Home, request),
                PageFactory.Create(PageType.Portfolio, request),
                PageFactory.Create(PageType.Contact, request)
            };
        }
    }
}
