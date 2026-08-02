using DesignPatterns.Builder.Models;
using DesignPatterns.Prototype.Models;

namespace DesignPatterns.Builder.Builders
{
    internal sealed class HtmlBodyBuilder
    {
        private readonly HtmlBody _body = new();

        public HtmlBodyBuilder AddSection(
            string heading,
            string description,
            string text)
        {
            _body.Sections.Add(new HtmlSection
            {
                Heading = heading,
                Description = description,
                Text = text
            });

            return this;
        }

        public HtmlBody Build()
        {
            return _body;
        }
    }
}
