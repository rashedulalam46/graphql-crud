using GraphQLCrud.Data;
using GraphQLCrud.Models;

namespace GraphQLCrud.GraphQL;

public class Mutation
{
    public async Task<Book> AddBook(Book input, [Service] AppDbContext context)
    {
        context.Books.Add(input);
        await context.SaveChangesAsync();
        return input;
    }

   public async Task<Book?> UpdateBook(int id, Book updated, [Service] AppDbContext context)
{
    var book = await context.Books.FindAsync(id);
    if (book == null) return null;

    book.Title = updated.Title;
    book.Author = updated.Author;
    await context.SaveChangesAsync();
    return book;
}


    public async Task<bool> DeleteBook(int id, [Service] AppDbContext context)
    {
        var book = await context.Books.FindAsync(id);
        if (book == null) return false;

        context.Books.Remove(book);
        await context.SaveChangesAsync();
        return true;
    }
}
