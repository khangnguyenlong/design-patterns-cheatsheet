using DesignPatterns.AbstractFactory.Models.Navigations;
using DesignPatterns.AbstractFactory.Models.Pages;
using DesignPatterns.AbstractFactory.Models.Themes;

namespace DesignPatterns.AbstractFactory.Models.Websites
{
    internal sealed class Website
    {
        private readonly List<Page> _pages = [];
        private readonly List<MasterPage> _masterPages = [];

        public Website(
            string name,
            string domain)
        {
            Name = name;
            Domain = domain;
        }

        public string Name { get; }

        public string Domain { get; }

        public IReadOnlyCollection<Page> Pages => _pages;

        public IReadOnlyCollection<MasterPage> MasterPages => _masterPages;

        public Theme Theme { get; private set; }

        public Navigation Navigation { get; private set; }

        public void AddPage(Page page)
        {
            _pages.Add(page);
        }

        public void AddMasterPage(MasterPage masterPage)
        {
            _masterPages.Add(masterPage);
        }

        public void SetTheme(Theme theme)
        {
            Theme = theme;
        }

        public void SetNavigation(Navigation navigation)
        {
            Navigation = navigation;
        }
    }
}
