using DesignPatterns.Builder.Builders;
using DesignPatterns.Builder.Models;

Console.WriteLine("Hello, World!");

// Create a Company Introduction HTML document using the Builder pattern
var document = new HtmlDocumentBuilder()
    .WithTitle("Company Introduction")
    .WithLanguage("en")

    .ConfigureHeader(header => header
        .WithTitle("ABC Technology")
        .WithLogo("/images/logo.png")
        .AddLink("Home", "/")
        .AddLink("Contact", "/contact"))

    .ConfigureBody(body => body
        .AddSection(
            "About Us",
            "Company introduction",
            "We provide software development services.")
        .AddSection(
            "Our Services",
            "What we provide",
            "Web, mobile and cloud development."))

    .ConfigureFooter(footer => footer
        .WithCopyright("© 2026 ABC Technology")
        .WithContactInformation(
            "contact@abc.com",
            "+84 123 456 789",
            "Ho Chi Minh City, Vietnam"))

    .Build();

// Create a Contact Us HTML document using the Builder pattern
var contactPage = new HtmlDocumentBuilder()
    .WithTitle("Contact Us")
    .WithLanguage("en")

    .ConfigureHeader(header => header
        .WithTitle("ABC Technology")
        .WithLogo("/images/logo.png")
        .AddLink("Home", "/")
        .AddLink("About", "/about"))

    .ConfigureBody(body => body
        .AddSection(
            "Contact Us",
            "Get in touch with our team",
            "Send us an email or call us for more information.")
        .AddSection(
            "Office Hours",
            "When we are available",
            "Monday to Friday, 8:00 AM to 5:00 PM."))

    .ConfigureFooter(footer => footer
        .WithCopyright("© 2026 ABC Technology")
        .WithContactInformation(
            "contact@example.com",
            "+84 123 456 789",
            "Ho Chi Minh City, Vietnam"))

    .Build();

// Create a Terms and Conditions HTML document using the Builder pattern
var termsPage = new HtmlDocumentBuilder()
    .WithTitle("Terms and Conditions")
    .WithLanguage("en")

    .ConfigureBody(body => body
        .AddSection(
            "Introduction",
            "About these terms",
            "By using this website, you agree to these terms and conditions.")
        .AddSection(
            "User Responsibilities",
            "Rules for using the website",
            "Users must not misuse the website or access restricted areas.")
        .AddSection(
            "Privacy",
            "How information is handled",
            "Personal information is processed according to our privacy policy.")
        .AddSection(
            "Changes to Terms",
            "Future updates",
            "These terms may be updated when necessary."))

    .ConfigureFooter(footer => footer
        .WithCopyright("© 2026 ABC Technology"))

    .Build();


// Print the documents to the console
PrintPage(document);
PrintPage(contactPage);
PrintPage(termsPage);

static void PrintPage(HtmlDocument page)
{
    Console.WriteLine($"\n=== {page.Title} ===");

    Console.WriteLine(
        $"Header: {page.Header?.Title ?? "None"}");

    Console.WriteLine(
        $"Links: {string.Join(", ",
            page.Header?.Links.Select(x => x.LinkTitle)
            ?? Enumerable.Empty<string>())}");

    Console.WriteLine(
        $"Sections: {string.Join(", ",
            page.Body?.Sections.Select(x => x.Heading)
            ?? Enumerable.Empty<string>())}");

    Console.WriteLine(
        $"Contact: {page.Footer?.ContactInformation?.Email ?? "None"}");
}