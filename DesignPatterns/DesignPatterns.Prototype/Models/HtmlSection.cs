namespace DesignPatterns.Prototype.Models
{
    internal class HtmlSection : IPrototype<HtmlSection>
    {
        public string Heading { get; set; }

        public string Description { get; set; }

        public string Text { get; set; }

        public HtmlSection DeepClone()
        {
            var other = (HtmlSection)this.MemberwiseClone();
            return other;
        }
    }
}
