namespace Laba8
{
    class Program
    {
        static void Main()
        {
            try
            {
                DateTime specificDate = new DateTime(2024, 4, 20);

                DocumentManager documentManager = new DocumentManager();

                Document doc1 = documentManager.CreateDocument("Text_Document_1", DateOnly.FromDateTime(specificDate), "Sofia Tanchuk", "Glory to Ukraine!", 14, "blue");
                Document textDoc1 = documentManager.CreateDocument("Text_Document_2", DateOnly.FromDateTime(specificDate), "Illya Mayer", "Glory to Hero!", 18, "yellow");


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
                document.Save();
                document.Print();
                document.Close();
                if (document is TextDocument textDocument)
                {
                    Console.WriteLine($"Word Count in the \"{document.Title}\": {textDocument.CalculateWordCount()}");
                    Console.WriteLine(textDocument.Sign("Administrator"));
                }
            }
        }
    }
}

