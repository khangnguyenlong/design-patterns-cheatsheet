namespace DesignPatterns.Prototype.Models
{
    internal class HtmlFooter : IPrototype<HtmlFooter>
    {
        public string LogoUrl { get; set; }

        public string Copyright { get; set; }

        public ContactInformation ContactInformation { get; set; }

        public HtmlFooter DeepClone()
        {
            var other = (HtmlFooter)MemberwiseClone();
            other.ContactInformation = ContactInformation?.DeepClone();
            return other;
        }
    }
}
