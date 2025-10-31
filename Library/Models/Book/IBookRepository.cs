using System.Data;

namespace Library.Models.Book
{
    public interface IBookRepository
    {
        void Create(Book book);
        void Delete(Book book);
        void Update(Book book , int id);
        List<Book> GetAll();
        Book? GetById(int id);

        

    }
}
