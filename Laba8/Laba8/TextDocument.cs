using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba8
{
    class TextDocument : Document
    {
        public string Content { get; }

        public TextDocument(string title, DateOnly creationDate, string author, string content)
            : base(title, creationDate, author)
        {
            if (string.IsNullOrWhiteSpace(content))
                throw new ArgumentException("Content cannot be null or empty.", nameof(content));

            this.Content = content;
        }

        public override Document AddContent(string content)
        {
            string newContent = Content + content;
            return new TextDocument(Title, CreationDate, Author, newContent);
        }

        public int CalculateWordCount()
        {
            return Content.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public string Sign(string signer)
        {
            return $"\"{Title}\"  signed by {signer}";
        }

        public override string ToString()
        {
            return base.ToString() + $", Content: {Content}";
        }
    }
}
