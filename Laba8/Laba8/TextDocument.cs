using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba8
{
    public class TextDocument : Document
    {
        public int FontSize { get; }
        public string TextColor { get; }

        public TextDocument(string title, DateOnly creationDate, string author, string content, int fontSize, string textColor)
            : base(title, creationDate, author, content)
        {
            if (fontSize <= 0)
                throw new ArgumentException("Font size must be greater than 0.", nameof(fontSize));

            if (string.IsNullOrWhiteSpace(textColor))
                throw new ArgumentException("Text color cannot be null or empty.", nameof(textColor));

            this.FontSize = fontSize;
            this.TextColor = textColor;
        }

        public override Document AddContent(string content)
        {
            string newContent = Content + content;
            return new TextDocument(Title, CreationDate, Author, newContent, FontSize, TextColor);
        }

        public override void Save()
        {
            Console.WriteLine($"Saving the \"{Title}\"");
        }

        public override void Print()
        {
            Console.WriteLine($"Printing the \"{Title}\"");
        }

        public override void Close()
        {
            Console.WriteLine($"Closing the \"{Title}\"");
        }

        public override string Sign(string signer)
        {
            return $"\"{Title}\" signed by {signer}";
        }

        public int CalculateWordCount()
        {
            return Content.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public override string ToString()
        {
            return base.ToString() + $", FontSize: {FontSize}, TextColor: {TextColor}";
        }
    }
}

