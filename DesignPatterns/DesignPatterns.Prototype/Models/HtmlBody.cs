namespace DesignPatterns.Prototype.Models
{
    internal class HtmlBody : IPrototype<HtmlBody>
    {
        public List<HtmlSection> Sections { get; set; } = new();

        public HtmlBody DeepClone()
        {
            var clone = (HtmlBody)MemberwiseClone();

            clone.Sections = Sections
                .Select(section => section.DeepClone())
                .ToList();

            return clone;
        }
    }
}
