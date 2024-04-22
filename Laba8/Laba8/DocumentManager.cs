﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba8
{
    class DocumentManager
    {
        private List<Document> documents;

        public DocumentManager()
        {
            documents = new List<Document>();
        }

        public void AddDocument(Document document)
        {
            documents.Add(document);
        }

        public List<Document> GetDocuments()
        {
            return documents;
        }

        public Document CreateDocument(string title, DateOnly creationDate, string author, string content = null)
        {
            Document document;

            if (string.IsNullOrWhiteSpace(content))
            {
                document = new PlainDocument(title, creationDate, author);
            }
            else
            {
                document = new TextDocument(title, creationDate, author, content);
            }

            return document;
        }
    }
}
