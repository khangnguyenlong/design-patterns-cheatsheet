using DesignPatterns.Prototype;
using DesignPatterns.Prototype.Models;

var original = new HtmlDocument
{
    Title = "Company Introduction",
    Language = "en",
    CreatedAt = DateTime.UtcNow,

    Header = new HtmlHeader
    {
        Title = "ABC Technology Company",
        LogoUrl = "https://example.com/logo.png"
    },

    Body = new HtmlBody
    {
        Sections =
        [
            new HtmlSection
            {
                Heading = "About Us",
                Description = "Company introduction",
                Text = "We provide software development services."
            }
        ]
    },

    Footer = new HtmlFooter
    {
        Copyright = "© 2026 ABC Technology Company",
        ContactInformation = new ContactInformation
        {
            Email = "contact@example.com",
            PhoneNumber = "+84 123 456 789",
            Address = "Ho Chi Minh City, Vietnam"
        }
    }
};

Console.WriteLine($"\n--- Origin ---");
Console.WriteLine("Field: Header.Title");
Console.WriteLine($"Original     : {original.Header.Title}");

// Create copies before changing anything
var shallowCopy = original.ShallowClone();

Console.WriteLine($"\n--- Before changing shallowCopy.Header.Title ---");
Console.WriteLine("Field: Header.Title");
Console.WriteLine($"Original     :  {original.Header.Title}");
Console.WriteLine($"Shallow Copy : {shallowCopy.Header.Title}");

// Change a nested field through the shallow copy
shallowCopy.Header.Title = "Changed by Shallow Copy";

Console.WriteLine($"\n--- After changing shallowCopy.Header.Title ---");
Console.WriteLine("Field: Header.Title");
Console.WriteLine($"Original     : {original.Header.Title}");
Console.WriteLine($"Shallow Copy : {shallowCopy.Header.Title}");

// Change the same nested field through the deep copy
var deepCopy = original.DeepClone();
deepCopy.Header.Title = "Changed by Deep Copy";

Console.WriteLine($"\n--- After changing deepCopy.Header.Title ---");
Console.WriteLine("Field: Header.Title");
Console.WriteLine($"Original     : {original.Header.Title}");
Console.WriteLine($"Deep Copy    : {deepCopy.Header.Title}");

// Change the same nested field through the deep copy using serialization
var deepCopyUsingSerialize = ObjectExtensions.DeepClone(original);
deepCopyUsingSerialize.Header.Title = "Changed by Deep Copy Using Serialize";
Console.WriteLine($"\n--- After changing deepCopyUsingSerialize.Header.Title ---");
Console.WriteLine("Field: Header.Title");
Console.WriteLine($"Original     : {original.Header.Title}");
Console.WriteLine($"Deep Copy Using Serialize : {deepCopyUsingSerialize.Header.Title}");