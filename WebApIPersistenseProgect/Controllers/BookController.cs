using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace WebApIPersistenseProgect.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        private BookService bookService;
        public BookController(BookService bookService)
        {
            this.bookService = bookService;
        }

        [HttpGet("GetBooks")]
        public async Task<List<Book>> GetBooks()
        {
            return await bookService.GetBooks();
        }

        [HttpGet("GetBookById")]
        public async Task<Book> GetBookById(int id)
        {
            return await bookService.GetBookById(id);
        }

        [HttpPost("Insert")]
        public async Task<int> Insert(Book book)
        {
            return await bookService.Insert(book);
        }

        [HttpPut("Update")]
        public async Task<int> Update(Book book)
        {
            return await bookService.Update(book);
        }

        [HttpDelete("Delete")]
        public async Task<int> Delete(int id)
        {
            return await bookService.Delete(id);
        }
    }
}
