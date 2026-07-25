using DesignPatterns.FactoryMethod.Models;

namespace DesignPatterns.FactoryMethod.Factories
{
    internal static class PageFactory
    {
        public static Page Create(PageType type, WebsiteInstallationRequest request)
        {
            return type switch
            {
                PageType.Home => CreateHomePage(request),
                PageType.About => CreateAboutPage(request),
                PageType.Contact => CreateContactPage(request),
                PageType.Portfolio => CreatePortfolioPage(request),

                _ => throw new ArgumentOutOfRangeException(nameof(type), type, "Unsupported page type.")
            };
        }

        private static Page CreateHomePage(WebsiteInstallationRequest request)
        {
            return new Page(
                type: PageType.Home,
                title: "Home",
                slug: "/",
                document: $"<header>Home</header><main>Welcome to our website</main><footer>© 2026 {request.WebsiteName}</footer>");
        }

        private static Page CreateAboutPage(WebsiteInstallationRequest request)
        {
            return new Page(
                type: PageType.About,
                title: "About Us",
                slug: "/about",
                document: $"<header>About Us</header><main>Company introduction</main><footer>© 2026 {request.WebsiteName}</footer>");
        }

        private static Page CreateContactPage(WebsiteInstallationRequest request)
        {
            return new Page(
                type: PageType.Contact,
                title: "Contact",
                slug: "/contact",
                document: $"<header>Contact</header><main>Email: contact@company.com</main><footer>© 2026 {request.WebsiteName}</footer>");
        }

        private static Page CreatePortfolioPage(WebsiteInstallationRequest request)
        {
            return new Page(
                type: PageType.Portfolio,
                title: "Portfolio",
                slug: "/portfolio",
                document: $"<header>Portfolio</header><main>Our work</main><footer>© 2026 {request.WebsiteName}</footer>");
        }
    }
}
