namespace DesignPatterns.FactoryMethod.Models
{
    internal class Page
    {
        public Page(PageType type, string title, string slug, string document)
        {
            Type = type;
            Title = title;
            Slug = slug;
            HtmlDocument = document;
        }

        public PageType Type { get; }

        public string Title { get; set; }

        public string Slug { get; }

        public string HtmlDocument { get; }
    }
}
