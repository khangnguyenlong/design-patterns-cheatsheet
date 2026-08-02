namespace DesignPatterns.Builder.Models
{
    internal class HtmlHeader
    {
        public string LogoUrl { get; set; }

        public string Title { get; set; }

        public List<HtmlLink> Links { get; set; } = new();

    }
}
