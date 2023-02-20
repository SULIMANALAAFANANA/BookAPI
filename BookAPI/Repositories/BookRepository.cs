using BookAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookAPI.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly BookContext context;
        private BookContext dbContext;

        public BookRepository(BookContext context)
        {
            dbContext = context;
        }
        public Task<Book> Create(Book book)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Book>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<Book> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
