using Domain.Entities.LibraryManagement.Borrowings;

namespace Domain.Interfaces
{
    public interface IBorrowingAlertViewRepository<TModel> 
    {
        Task<IEnumerable<BorrowingAlertView>> GetAllAsync();
        Task<BorrowingAlertView> GetByIdAsync(object id);
        Task<int> GetCountBorrowingAlertByLibriryCart(Guid libriryCartId);
        Task<IEnumerable<BorrowingAlertView>> GetListBorrowingByLibriryCartAsync(Guid libriryCartId);
    }
}
