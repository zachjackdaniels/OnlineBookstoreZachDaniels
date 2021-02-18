using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookstoreZachDaniels.Models
{
    public interface IBookstoreRepo
    {
        IQueryable<Book> Books { get; }
    }
}
