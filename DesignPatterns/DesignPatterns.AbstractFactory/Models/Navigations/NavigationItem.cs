namespace DesignPatterns.AbstractFactory.Models.Navigations
{
    internal class NavigationItem
    {
        public string Title { get; set; }
        public string Url { get; set; }

        public NavigationItem(string title, string url)
        {
            Title = title;
            Url = url;
        }
    }
}
