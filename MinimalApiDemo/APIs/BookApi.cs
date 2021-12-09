namespace MinimalApiDemo.APIs;

public static class BookApi
{
    public static void ConfigureApi(this WebApplication app)
    {
        app.MapGet("/Books", GetBooks);
        app.MapGet("/Book/{id}", GetBookById);
        app.MapPost("/InsertBook", InsertBook);
        app.MapPut("/UpdateBook", UpdateBook);
        app.MapDelete("/DeleteBook", DeleteBook);

    }
    private static async Task<IResult> GetBooks(IBookData data)
    {
        try
        {
            return Results.Ok(await data.GetBooks());
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> GetBookById(int id, IBookData data)
    {
        try
        {
            var results = await data.GetBookById(id);

            if (results == null)
            {
                return Results.NotFound("Could not find any record with the Id");
            }

            return Results.Ok(results);
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> InsertBook(BookModel book, IBookData data)
    {
        try
        {
            await data.InsertBook(book);

            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> UpdateBook(BookModel book, IBookData data)
    {
        try
        {
            await data.UpdateBook(book);

            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> DeleteBook(int id, IBookData data)
    {
        try
        {
            await data.DeleteBook(id);

            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
}
