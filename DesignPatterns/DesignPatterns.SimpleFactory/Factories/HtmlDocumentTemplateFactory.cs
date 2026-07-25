using DesignPatterns.SimpleFactory.Models;
using DesignPatterns.SimpleFactory.Models.Template;

namespace DesignPatterns.SimpleFactory.Factories
{
    internal class HtmlDocumentTemplateFactory
    {
        public static HtmlDocument Create(HtmlDocumentType documentType)
        {
            return documentType switch
            {
                HtmlDocumentType.CompanyIntroduction => new CompanyIntroductionDocument("Welcome to Our Company"),
                HtmlDocumentType.ContactUs => new ContactUsDocument("Contact Us"),
                HtmlDocumentType.TermsAndConditions => new TermsAndConditionsDocument("Terms and Conditions"),

                _ => throw new NotSupportedException($"Document type '{documentType}' is not supported.")
            };
        }
    }
}
