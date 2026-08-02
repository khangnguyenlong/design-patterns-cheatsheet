namespace DesignPatterns.AbstractFactory.Models.Themes
{
    internal class Theme
    {
        public Theme(string name, string font, string primaryColor)
        {
            Name = name;
            Font = font;
            PrimaryColor = primaryColor;
        }

        public string Name { get; }

        public string Font { get; }

        public string PrimaryColor { get; }
    }
}
