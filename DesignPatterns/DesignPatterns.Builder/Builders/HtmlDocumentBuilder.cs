using DesignPatterns.Prototype.Models;

namespace DesignPatterns.Builder.Builders
{
    internal sealed class HtmlDocumentBuilder
    {
        private readonly HtmlDocument _document = new()
        {
            CreatedAt = DateTime.UtcNow
        };

        public HtmlDocumentBuilder WithTitle(string title)
        {
            _document.Title = title;
            return this;
        }

        public HtmlDocumentBuilder WithLanguage(string language)
        {
            _document.Language = language;
            return this;
        }

        public HtmlDocumentBuilder ConfigureHeader(
            Action<HtmlHeaderBuilder> configure)
        {
            var builder = new HtmlHeaderBuilder();

            configure(builder);

            _document.Header = builder.Build();

            return this;
        }

        public HtmlDocumentBuilder ConfigureBody(
            Action<HtmlBodyBuilder> configure)
        {
            var builder = new HtmlBodyBuilder();

            configure(builder);

            _document.Body = builder.Build();

            return this;
        }

        public HtmlDocumentBuilder ConfigureFooter(
            Action<HtmlFooterBuilder> configure)
        {
            var builder = new HtmlFooterBuilder();

            configure(builder);

            _document.Footer = builder.Build();

            return this;
        }

        public HtmlDocument Build()
        {
            return _document;
        }
    }
}
