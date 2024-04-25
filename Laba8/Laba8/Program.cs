namespace Laba8
{
    class Program
    {
        static void Main()
        {
            try
            {
                DateTime specificDate = new DateTime(2024, 4, 20);

                var documentManager = new DocumentManager();

                var doc1 = documentManager.CreateDocument("Text_Document_1", DateOnly.FromDateTime(specificDate), "Sofia Tanchuk", "Glory to Ukraine!");
                var textDoc1 = documentManager.CreateDocument("Text_Document_2", DateOnly.FromDateTime(specificDate), "Illya Mayer", "Glory to Heroes!");

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
                Console.WriteLine(document.ToString());
                Console.WriteLine($"Word Count in the \"{document.Title}\": {document.CalculateWordCount()}");
                Console.WriteLine(document.Sign("Administrator"));
            }
        }

    }
}

