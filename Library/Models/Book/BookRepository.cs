
namespace Library.Models.Book
{
    public class BookRepository : IBookRepository
    {
        public static List<Book> books { get; set; } = new List<Book>();

        public void Create(Book book)
        {
            books.Add(book);
        }

        public void Delete(Book book)
        {
            book.IsAvailable = false;
        }

        public List<Book> GetAll()
        {
            return books;
        }

        public Book? GetById(int id)
        {
            return books.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Book book, int id)
        {
            var book1 = GetById(id);
            book1.Title = book.Title;
            book1.Author = book.Author;
            book1.Quantity = book.Quantity;
            book1.BookGenre = book.BookGenre;
        }
        public List<Book> Filter(BookGenre bookGenre, string title)
        {
            List<Book> Books = books;
            if (bookGenre != BookGenre.None)
            {
                Books = Books.Where(x => x.BookGenre == bookGenre).ToList();
            }
            else if (!string.IsNullOrWhiteSpace(title))
            {

                Books = Books.Where(x => x.Title.Contains(title) || x.Author.Contains(title)).ToList();
            }
            return Books;
        }
    }

}
