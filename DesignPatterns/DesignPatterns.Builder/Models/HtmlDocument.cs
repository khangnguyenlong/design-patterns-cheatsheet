namespace DesignPatterns.Builder.Models
{
    internal class HtmlDocument
    {
        public string Title { get; set; }

        public string Language { get; set; }

        public DateTime CreatedAt { get; set; }

        public HtmlHeader Header { get; set; }

        public HtmlBody Body { get; set; }

        public HtmlFooter Footer { get; set; }
    }
}
