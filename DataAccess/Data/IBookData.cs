using DataAccess.Models;

namespace DataAccess.Data;

public interface IBookData
{
    Task DeleteBook(int id);
    Task<BookModel?> GetBookById(int id);
    Task<IEnumerable<BookModel>> GetBooks();
    Task InsertBook(BookModel book);
    Task UpdateBook(BookModel book);
}