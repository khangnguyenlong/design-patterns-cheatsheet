namespace DesignPatterns.AbstractFactory.Models.Pages
{
    internal class MasterPage
    {
        public MasterPage(string key, string header, string footer)
        {
            Key = key;
            Header = header;
            Footer = footer;
        }

        public string Key { get; }

        public string Header { get; }

        public string Footer { get; }
    }
}
