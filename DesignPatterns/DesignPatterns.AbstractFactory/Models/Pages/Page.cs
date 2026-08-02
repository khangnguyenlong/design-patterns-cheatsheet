namespace DesignPatterns.AbstractFactory.Models.Pages
{
    internal sealed class Page
    {
        public Page(
            PageType type,
            string title,
            string slug,
            string content,
            string masterPageKey,
            bool showInNavigation)
        {
            Type = type;
            Title = title;
            Slug = slug;
            Content = content;
            MasterPageKey = masterPageKey;
            ShowInNavigation = showInNavigation;
        }

        public PageType Type { get; }

        public string Title { get; }

        public string Slug { get; }

        public string Content { get; }

        public string MasterPageKey { get; }

        public bool ShowInNavigation { get; }
    }
}
