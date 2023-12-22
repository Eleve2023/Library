using Domain.Entities.LibraryManagement.Borrowings;

namespace Domain.Interfaces
{
    public interface IBorrowRuleRepository<TModel> : ICommonRepository<BorrowRule, TModel>
    {
    }
}
