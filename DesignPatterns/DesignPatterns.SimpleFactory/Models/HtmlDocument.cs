namespace DesignPatterns.SimpleFactory.Models
{
    internal abstract class HtmlDocument
    {
        public string Title { get; set; }

        public HtmlDocument(string title)
        {
            Title = title;
        }

        public abstract string Render();
    }
}
