using Domain.Entities;
using Persistence.Data;

namespace Services
{
    public class BookService
    {
        private DataContext dataContext;
        public BookService(DataContext dataContext)
        {
            this.dataContext=dataContext;
        }

        public async Task<List<Book>> GetBooks()
        {
            var books = dataContext.Books.ToList();
            return books.ToList();

        }

        public async Task<Book> GetBookById(int id)
        {
            var book = await dataContext.Books.FindAsync(id);
            return book;
           

        }

        public  async Task<int> Insert(Book book)
        {
            dataContext.Add(book);
            var inserted = await dataContext.SaveChangesAsync();
            return inserted;

        }

        public  async Task<int> Update(Book book)
        {
            var book1 = await dataContext.Books.FindAsync(book.Id);
            book1.Name = book.Name;
            book1.NumberOfPages = book.NumberOfPages;
            book1.Author = book.Author;
            var updated= await dataContext.SaveChangesAsync();
            return updated;
                
        }

        public async Task<int> Delete(int id)
        {
            var book = await dataContext.Books.FindAsync(id);
            dataContext.Books.Remove(book);
            var delete = await dataContext.SaveChangesAsync();
            return delete;
        }
    }
}