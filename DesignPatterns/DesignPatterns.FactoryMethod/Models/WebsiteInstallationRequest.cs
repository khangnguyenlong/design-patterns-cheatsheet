namespace DesignPatterns.FactoryMethod.Models
{
    public class WebsiteInstallationRequest
    {
        public WebsiteInstallationRequest(string websiteName, string domain)
        {
            WebsiteName = websiteName;
            Domain = domain;
        }

        public string WebsiteName { get; }

        public string Domain { get; }
    }
}
