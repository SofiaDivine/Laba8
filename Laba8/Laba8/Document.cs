using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Laba8
{
    public abstract class Document
    {
        public string Title { get; }
        public DateOnly CreationDate { get; }
        public string Author { get; }
        public string Content { get; }

        protected Document(string title, DateOnly creationDate, string author, string content)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Title cannot be null or empty.", nameof(title));

            if (string.IsNullOrWhiteSpace(author))
                throw new ArgumentException("Author cannot be null or empty.", nameof(author));

            if (string.IsNullOrWhiteSpace(content))
                throw new ArgumentException("Content cannot be null or empty.", nameof(content));

            this.Title = title;
            this.CreationDate = creationDate;
            this.Author = author;
            this.Content = content;
        }

        public abstract Document AddContent(string content);

        public abstract void Save();

        public abstract void Print();

        public abstract void Close();

        public virtual string Sign(string signer)
        {
            return $"Document \"{Title}\" is signed by {signer}";
        }

        public override string ToString()
        {
            return $"\nTitle: {Title}, Created: {CreationDate}, Author: {Author}, Content: {Content}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Document other = (Document)obj;
            return Title == other.Title && CreationDate == other.CreationDate && Author == other.Author && Content == other.Content;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Title, CreationDate, Author, Content);
        }
    }
}

