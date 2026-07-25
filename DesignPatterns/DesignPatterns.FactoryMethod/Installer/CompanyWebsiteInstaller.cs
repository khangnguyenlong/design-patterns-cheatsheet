using DesignPatterns.FactoryMethod.Factories;
using DesignPatterns.FactoryMethod.Models;

namespace DesignPatterns.FactoryMethod.Installer
{
    internal class CompanyWebsiteInstaller : WebsiteTemplateInstaller
    {
        // Factory method: The subclass decides which pages to create.
        protected override IReadOnlyCollection<Page> CreatePages(WebsiteInstallationRequest request)
        {
            return
            [
                PageFactory.Create(PageType.Home, request),
                PageFactory.Create(PageType.About, request),
                PageFactory.Create(PageType.Contact, request)
            ];
        }
    }
}
