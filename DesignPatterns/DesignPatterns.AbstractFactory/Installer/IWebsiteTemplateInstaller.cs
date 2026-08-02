using DesignPatterns.AbstractFactory.Models.Websites;

namespace DesignPatterns.AbstractFactory.Installer
{
    internal interface IWebsiteTemplateInstaller
    {
        Website Install(WebsiteInstallationRequest request);
    }
}
