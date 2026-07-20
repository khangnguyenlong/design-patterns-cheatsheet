namespace DesignPatterns.Prototype.Models
{
    internal class ContactInformation : IPrototype<ContactInformation>
    {
        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public ContactInformation DeepClone()
        {
            var other = (ContactInformation)this.MemberwiseClone();
            return other;
        }
    }
}
