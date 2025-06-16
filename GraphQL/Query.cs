using GraphQLCrud.Data;
using GraphQLCrud.Models;

namespace GraphQLCrud.GraphQL;

    public class Query
    {
        public IQueryable<Book> GetBooks([Service] AppDbContext context) =>
        context.Books;
        
    public Book? GetBookById(int id, [Service] AppDbContext context) =>
        context.Books.Find(id);
    }
