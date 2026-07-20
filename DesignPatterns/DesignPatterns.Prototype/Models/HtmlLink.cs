namespace DesignPatterns.Prototype.Models
{
    internal class HtmlLink : IPrototype<HtmlLink>
    {
        public string LinkUrl { get; set; }

        public string LinkTitle { get; set; }

        public HtmlLink DeepClone()
        {
            var other = (HtmlLink)this.MemberwiseClone();
            return other;
        }
    }
}
