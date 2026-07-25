namespace DesignPatterns.SimpleFactory.Models.Template
{
    internal class TermsAndConditionsDocument : HtmlDocument
    {
        public TermsAndConditionsDocument(string title) : base(title)
        {
        }

        public override string Render()
        {
            return @$"<html>
               <head>
                  <title>{Title}</title>
               </head>
               <body>
                  <h1>Terms and Conditions</h1>
                  <p>This is the terms and conditions document.</p>
               </body>
            </html>";
        }   
    }
}