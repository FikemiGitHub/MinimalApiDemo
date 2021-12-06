using DataAccess.DbAccess;
using DataAccess.Models;

namespace DataAccess.Data;

public class BookData : IBookData
{
    private readonly ISqlDataAccess _db;

    public BookData(ISqlDataAccess db)
    {
        _db = db;
    }

    public Task<IEnumerable<BookModel>> GetBooks() => _db.LoadData<BookModel, dynamic>(storedProcedure: "dbo.Books_GetAll", new { });

    public async Task<BookModel?> GetBookById(int id)
    {
        var result = await _db.LoadData<BookModel, dynamic>(storedProcedure: "dbo.Books_GetBook", new { Id = id });

        return result.FirstOrDefault();
    }

    public Task InsertBook(BookModel book) => _db.SaveData(storedProcedure: "dbo.Books_Insert", new { book.Title, book.Author, book.Description });

    public Task UpdateBook(BookModel book) => _db.SaveData(storedProcedure: "dbo.Books_Update", new { book });

    public Task DeleteBook(int id) => _db.SaveData(storedProcedure: "dbo.Books_Delete", new { Id = id });
}
