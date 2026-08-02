namespace DesignPatterns.AbstractFactory.Models.Websites
{
    internal sealed class WebsiteInstallationRequest
    {
        public WebsiteInstallationRequest(
            string websiteName,
            string domain,
            WebsiteType websiteType)
        {
            WebsiteName = websiteName;
            Domain = domain;
            WebsiteType = websiteType;
        }

        public string WebsiteName { get; }

        public string Domain { get; }

        public WebsiteType WebsiteType { get; }
    }
}
