using Laba8;

class Program
{
    static void Main()
    {
        try
        {
            DateTime specificDate = new DateTime(2024, 4, 20);

            DocumentManager documentManager = new DocumentManager();

            Document doc1 = documentManager.CreateDocument("Document", DateOnly.FromDateTime(specificDate), "Sofia Tanchuk");
            Document textDoc1 = documentManager.CreateDocument("Text Document", DateOnly.FromDateTime(specificDate), "Illya Mayer", "Glory to Ukraine!");

            documentManager.AddDocument(doc1);
            documentManager.AddDocument(textDoc1);

            PrintDocuments(documentManager.GetDocuments());
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static void PrintDocuments(List<Document> documents)
    {
        foreach (var document in documents)
        {
            Console.WriteLine(document);
            if (document is TextDocument textDocument)
            {
                Console.WriteLine($"Word Count in the \"{document.Title}\": {textDocument.CalculateWordCount()}");
                Console.WriteLine(textDocument.Sign("Administrator"));
            }
        }
    }
}

