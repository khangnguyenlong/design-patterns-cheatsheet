using DesignPatterns.AbstractFactory.Models.Pages;

namespace DesignPatterns.AbstractFactory.Models.Navigations
{
    internal static class NavigationBuilder
    {
        public static Navigation Build(IReadOnlyCollection<Page> pages)
        {
            IReadOnlyCollection<NavigationItem> items = pages
                .Where(page => page.ShowInNavigation)
                .Select(page => new NavigationItem(page.Title, page.Slug))
                .ToList();

            return new Navigation(items);
        }
    }
}
