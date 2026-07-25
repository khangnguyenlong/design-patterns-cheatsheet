using DesignPatterns.FactoryMethod.Models;

namespace DesignPatterns.FactoryMethod.Installer
{
    internal interface IWebsiteTemplateInstaller
    {
        Website Install(WebsiteInstallationRequest request);
    }
}
