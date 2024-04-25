using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba8
{
    public class TextDocument : Document
    {
        public const int FONT_SIZE = 14;
        public const string TEXT_COLOR = "blue";

        public TextDocument(string title, DateOnly creationDate, string author, string content)
            : base(title, creationDate, author, content)
        {
        }

        public override Document AddContent(string content)
        {
            string newContent = $"{Content} {content}";
            return new TextDocument(Title, CreationDate, Author, newContent);
        }

        public override string Sign(string signer)
        {
            return $"\"{Title}\" signed by {signer}";
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
            return $"{base.ToString()}, Font Size: {FONT_SIZE}, Text Color: {TEXT_COLOR}";
        }

    
}
}

