using DesignPatterns.SimpleFactory.Factories;
using DesignPatterns.SimpleFactory.Models;


// Create a ContactUsDocument using the HtmlDocumentTemplateFactory
Console.WriteLine("Creating a ContactUs Html Document using the HtmlDocumentFactory...");
HtmlDocument htmlDocument = HtmlDocumentTemplateFactory.Create(HtmlDocumentType.ContactUs);
string html = htmlDocument.Render();
Console.WriteLine(html);

// Create a Company Profile using the HtmlDocumentTemplateDictFactory
Console.WriteLine("Creating a CompanyIntroduction Html Document using the HtmlDocumentTemplateDictFactory...");
HtmlDocument companyHtmlDocument = HtmlDocumentTemplateDictFactory.Create(HtmlDocumentType.CompanyIntroduction);
string companyHtml = companyHtmlDocument.Render();
Console.WriteLine(companyHtml);