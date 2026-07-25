using DesignPatterns.SimpleFactory.Models;
using DesignPatterns.SimpleFactory.Models.Template;

namespace DesignPatterns.SimpleFactory.Factories
{
    internal static class HtmlDocumentTemplateDictFactory
    {
        private static readonly IReadOnlyDictionary<HtmlDocumentType, Func<HtmlDocument>> CreationMethods =
            new Dictionary<HtmlDocumentType, Func<HtmlDocument>>
            {
                [HtmlDocumentType.CompanyIntroduction] = CreateCompanyIntroduction,
                [HtmlDocumentType.ContactUs] = CreateContactUs,
                [HtmlDocumentType.TermsAndConditions] = CreateTermsAndConditions
            };

        public static HtmlDocument Create(HtmlDocumentType documentType)
        {
            if (!CreationMethods.TryGetValue(documentType, out var creationMethod))
            {
                throw new NotSupportedException($"Document type '{documentType}' is not supported.");
            }

            return creationMethod();
        }

        private static HtmlDocument CreateCompanyIntroduction()
        {
            // TODO : Implement the logic to create a CompanyIntroductionDocument
            return new CompanyIntroductionDocument("Welcome to Our Company");
        }

        private static HtmlDocument CreateContactUs()
        {
            // TODO : Implement the logic to create a ContactUsDocument
            return new ContactUsDocument("Contact Us");
        }

        private static HtmlDocument CreateTermsAndConditions()
        {
            // TODO : Implement the logic to create a TermsAndConditionsDocument
            return new TermsAndConditionsDocument("Terms and Conditions");
        }
    }
}
