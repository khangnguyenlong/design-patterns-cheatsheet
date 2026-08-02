using DesignPatterns.FactoryMethod.Models;

namespace DesignPatterns.FactoryMethod.Installer
{
    internal abstract class WebsiteTemplateInstaller : IWebsiteTemplateInstaller
    {
        // Workflow for installing a website template
        public Website Install(WebsiteInstallationRequest request)
        {
            // 1. Create website
            var website = new Website(name: request.WebsiteName, domain: request.Domain);

            // 2. Create pages - Factory Method
            IReadOnlyCollection<Page> pages = CreatePages(request);
            foreach (Page page in pages)
            {
                website.AddPage(page);
            }

            // 3. Perform additional installation steps, such as build navigation, configuring the website, setting up databases, etc.

            return website;
        }

        // Factory method: The subclass decides which pages to create.
        protected abstract IReadOnlyCollection<Page> CreatePages(WebsiteInstallationRequest request);
    }
}
