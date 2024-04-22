using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba8
{
    public abstract class Document
    {
        public string Title { get; }
        public DateOnly CreationDate { get; }
        public string Author { get; }

        protected Document(string title, DateOnly creationDate, string author)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Title cannot be null or empty.", nameof(title));

            if (string.IsNullOrWhiteSpace(author))
                throw new ArgumentException("Author cannot be null or empty.", nameof(author));

            this.Title = title;
            this.CreationDate = creationDate;
            this.Author = author;
        }

        public abstract Document AddContent(string content);

        public override string ToString()
        {
            return $"Title: {Title}, Created: {CreationDate}, Author: {Author}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Document other = (Document)obj;
            return Title == other.Title && CreationDate == other.CreationDate && Author == other.Author;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Title, CreationDate, Author);
        }
    }
}
