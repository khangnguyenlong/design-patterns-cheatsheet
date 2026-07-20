namespace DesignPatterns.Prototype.Models
{
    internal class HtmlDocument : IPrototype<HtmlDocument>
    {
        public string Title { get; set; }

        public string Language { get; set; }

        public DateTime CreatedAt { get; set; }

        public HtmlHeader Header { get; set; }

        public HtmlBody Body { get; set; }

        public HtmlFooter Footer { get; set; }

        public HtmlDocument ShallowClone()
        {
            return (HtmlDocument)MemberwiseClone();
        }

        public HtmlDocument DeepClone()
        {
            var other = (HtmlDocument)MemberwiseClone();

            other.Header = other.Header?.DeepClone();
            other.Body = other.Body?.DeepClone();
            other.Footer = other.Footer?.DeepClone();
            return other;
        }
    }
}
