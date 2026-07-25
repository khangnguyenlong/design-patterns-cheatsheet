namespace DesignPatterns.FactoryMethod.Models
{
    internal class Website
    {
        private readonly List<Page> _pages = new();

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

        public void AddPage(Page page)
        {
            _pages.Add(page);
        }
    }
}
