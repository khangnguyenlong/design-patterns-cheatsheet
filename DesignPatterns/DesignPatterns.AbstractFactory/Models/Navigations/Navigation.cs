namespace DesignPatterns.AbstractFactory.Models.Navigations
{
    internal class Navigation
    {
        public Navigation(IReadOnlyCollection<NavigationItem> items)
        {
            Items = items;
        }

        public IReadOnlyCollection<NavigationItem> Items { get; }
    }
}
