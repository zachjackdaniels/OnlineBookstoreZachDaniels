using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookstoreZachDaniels.Models
{
    public class EFBookstoreRepo : IBookstoreRepo
    {
        private BookstoreDbContext _context;
        public EFBookstoreRepo(BookstoreDbContext context)
        {
            _context = context;
        }
        public IQueryable<Book> Books => _context.Books;
    }
}
