namespace DesignPatterns.Prototype.Models
{
    internal class HtmlHeader : IPrototype<HtmlHeader>
    {
        public string LogoUrl { get; set; }

        public string Title { get; set; }

        public List<HtmlLink> Links { get; set; } = new();

        public HtmlHeader DeepClone()
        {
            var other = (HtmlHeader)MemberwiseClone();
            return other;
        }
    }
}
