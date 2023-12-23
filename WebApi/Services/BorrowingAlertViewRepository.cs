using Application.Dtos.LibraryManagement.Borrowings;
using Application.Helpe;
using Domain.Entities.LibraryManagement.Borrowings;
using Domain.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Services
{
    public class BorrowingAlertViewRepository(AppDbContext appDbContext, MapperHelpe mapper) :
        IBorrowingAlertViewRepository<BorrowingAlertViewDto>
    {
        public async Task<IEnumerable<BorrowingAlertView>> GetAllAsync()
        {
            return await appDbContext.Set<BorrowingAlertView>().ToListAsync();
        }

        public async Task<IEnumerable<BorrowingAlertView>> GetListBorrowingByLibriryCartAsync(Guid libriryCartId)
        {
           return await appDbContext.Set<BorrowingAlertView>().Where(e => e.CardId == libriryCartId).ToListAsync();
        }

        public async Task<int> GetCountBorrowingAlertByLibriryCart(Guid libriryCartId)
        {
            return await appDbContext.Set<BorrowingAlertView>().Where(e => e.CardId == libriryCartId).CountAsync();
        }

        public async Task<BorrowingAlertView> GetByIdAsync(object id)
        {
            return await appDbContext.Set<BorrowingAlertView>().FindAsync(id)
               ?? throw new Domain.Exceptions.BorrowingAlertViewNotFoundException(id);
        }
    }

}
