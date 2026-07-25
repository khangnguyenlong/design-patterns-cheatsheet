using DesignPatterns.FactoryMethod.Installer;
using DesignPatterns.FactoryMethod.Models;

Console.WriteLine("=== Factory Method Design Pattern ===");

var request = new WebsiteInstallationRequest(websiteName: "ABC Technology", domain: "abc-technology.com");

IWebsiteTemplateInstaller installer = new CompanyWebsiteInstaller();
Website website = installer.Install(request);

Console.WriteLine("Website installed successfully \n");

Console.WriteLine($"Name   : {website.Name}");
Console.WriteLine($"Domain : {website.Domain}");
Console.WriteLine($"Pages  : {website.Pages.Count} \n");

foreach (Page page in website.Pages)
{
    Console.WriteLine($"Title: {page.Title}");
    Console.WriteLine($"Slug   : {page.Slug}");
    Console.WriteLine($"HtmlDocument : {page.HtmlDocument} \n");
}