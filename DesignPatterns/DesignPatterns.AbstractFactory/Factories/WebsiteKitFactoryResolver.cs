using DesignPatterns.AbstractFactory.Models.Websites;

namespace DesignPatterns.AbstractFactory.Factories
{
    internal static class WebsiteKitFactoryResolver
    {
        public static IWebsiteKitFactory Resolve(
            WebsiteType websiteType)
        {
            return websiteType switch
            {
                WebsiteType.Company => new CompanyWebsiteKitFactory(),
                WebsiteType.Portfolio => new PortfolioWebsiteKitFactory(),

                _ => throw new ArgumentOutOfRangeException(nameof(websiteType))
            };
        }
    }
}
