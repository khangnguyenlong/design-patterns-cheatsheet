using DesignPatterns.AbstractFactory.Factories;
using DesignPatterns.AbstractFactory.Installer;
using DesignPatterns.AbstractFactory.Models.Navigations;
using DesignPatterns.AbstractFactory.Models.Pages;
using DesignPatterns.AbstractFactory.Models.Websites;

Console.WriteLine("=== Abstract Factory Pattern ===");

IWebsiteKitFactory factory = WebsiteKitFactoryResolver.Resolve(WebsiteType.Company);
IWebsiteTemplateInstaller installer = new WebsiteTemplateInstaller(factory);

// Create a list of website installation requests
WebsiteInstallationRequest[] requests =
[
    new("ABC Technology", "abc.com", WebsiteType.Company),
    new("XZY Portfolio", "xyz.com", WebsiteType.Portfolio),
];

foreach (WebsiteInstallationRequest request in requests)
{
    // Install the website using the installer
    Website website = installer.Install(request);

    Console.WriteLine($"{request.WebsiteType} Website");
    Console.WriteLine($"Name: {website.Name}");
    Console.WriteLine($"Domain: {website.Domain}");
    Console.WriteLine( $"Theme: {website.Theme!.Name} ({website.Theme.PrimaryColor}, {website.Theme.Font})");

    // Display the master pages, pages, and navigation items
    Console.WriteLine("Master Pages:");
    foreach (MasterPage masterPage in website.MasterPages)
    {
        Console.WriteLine($"- {masterPage.Key}");
    }

    Console.WriteLine("Pages:");
    foreach (Page page in website.Pages)
    {
        Console.WriteLine(
            $"- {page.Title} ({page.Slug}) " +
            $"[Master: {page.MasterPageKey}]");
    }

    Console.WriteLine("Navigation:");
    foreach (NavigationItem item in website.Navigation!.Items)
    {
        Console.WriteLine($"- {item.Title} -> {item.Url}");
    }

    Console.WriteLine();
}