using DesignPatterns.Prototype.Models;

namespace DesignPatterns.Builder.Builders
{
    internal sealed class HtmlFooterBuilder
    {
        private readonly HtmlFooter _footer = new();

        public HtmlFooterBuilder WithCopyright(
            string copyright)
        {
            _footer.Copyright = copyright;
            return this;
        }

        public HtmlFooterBuilder WithLogo(string logoUrl)
        {
            _footer.LogoUrl = logoUrl;
            return this;
        }

        public HtmlFooterBuilder WithContactInformation(
            string email,
            string phoneNumber,
            string address)
        {
            _footer.ContactInformation = new ContactInformation
            {
                Email = email,
                PhoneNumber = phoneNumber,
                Address = address
            };

            return this;
        }

        public HtmlFooter Build()
        {
            return _footer;
        }
    }
}
