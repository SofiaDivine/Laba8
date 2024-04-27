using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba8
{
    public class TextDocument : Document
    {
        private int _fontSize;
        private string _textColor;

        public TextDocument(string title, DateOnly creationDate, string author, string content, int fontSize = 14, string textColor = "blue")
            : base(title, creationDate, author, content)
        {
            _fontSize = fontSize;
            _textColor = textColor;
        }

        public override Document AddContent(string content)
        {
            return new TextDocument(Title, CreationDate, Author, content, _fontSize, _textColor);
        }

        public override bool IsSigned()
        {
            return true;
        }

        public override int CalculateWordCount()
        {
            return Content.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Font Size: {_fontSize}, Text Color: {_textColor}";
        }
    
    }
}

