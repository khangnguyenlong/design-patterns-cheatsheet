using DesignPatterns.Builder.Models;
using DesignPatterns.Prototype.Models;

namespace DesignPatterns.Builder.Builders
{
    internal sealed class HtmlHeaderBuilder
    {
        private readonly HtmlHeader _header = new();

        public HtmlHeaderBuilder WithTitle(string title)
        {
            _header.Title = title;
            return this;
        }

        public HtmlHeaderBuilder WithLogo(string logoUrl)
        {
            _header.LogoUrl = logoUrl;
            return this;
        }

        public HtmlHeaderBuilder AddLink(
            string title,
            string url)
        {
            _header.Links.Add(new HtmlLink
            {
                LinkTitle = title,
                LinkUrl = url
            });

            return this;
        }

        public HtmlHeader Build()
        {
            return _header;
        }
    }
}
