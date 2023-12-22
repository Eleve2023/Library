using Domain.Entities.LibraryManagement.Borrowings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IBorrowingRepository<TModel> : ICommonRepository<Borrowing, TModel>
    {
    } 
}
