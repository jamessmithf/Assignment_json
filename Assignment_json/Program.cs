using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace Assignment_json
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            var options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.Cyrillic)
            };
            var booksJson = File.ReadAllText("books.json");
            List<Book> books = JsonSerializer.Deserialize<List<Book>>(booksJson, options);

            for (int i = 0; i < books.Count; i++)
            {
                books[i].GetInfo();
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
