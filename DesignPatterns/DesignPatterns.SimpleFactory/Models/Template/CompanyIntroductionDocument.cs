namespace DesignPatterns.SimpleFactory.Models.Template
{
    internal class CompanyIntroductionDocument : HtmlDocument
    {
        public CompanyIntroductionDocument(string title) : base(title)
        {
        }

        public override string Render()
        {
            return @$"<html><html>
               <head>
                  <title>{Title}</title>
               </head>
               <body>
                  <h1>Welcome to Our Company</h1>
                  <p>This is the company introduction document.</p>
               </body>
            </html>";
        }
    }
}