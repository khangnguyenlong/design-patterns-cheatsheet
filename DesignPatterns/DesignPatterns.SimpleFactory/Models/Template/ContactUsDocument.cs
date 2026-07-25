namespace DesignPatterns.SimpleFactory.Models.Template
{
    internal class ContactUsDocument : HtmlDocument
    {
        public ContactUsDocument(string title) : base(title)
        {
        }

        public override string Render()
        {
            return @$"<html>
               <head>
                  <title>{Title}</title>
               </head>
               <body>
                  <h1>Contact Us</h1>
                  <p>This is the contact us document.</p>
               </body>
            </html>";
        }
    }
}