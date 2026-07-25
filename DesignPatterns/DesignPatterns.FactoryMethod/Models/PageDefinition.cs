namespace DesignPatterns.FactoryMethod.Models
{
    internal class PageDefinition
    {
        public PageDefinition(PageType type, string title, string slug)
        {
            Type = type;
            Title = title;
            Slug = slug;
        }

        public PageType Type { get; }

        public string Title { get; }

        public string Slug { get; }
    }
}
