using Domain.Entities.LibraryManagement;

namespace Domain.Interfaces
{
    public interface ILibraryCardRepository<TModel> : ICommonRepository<LibraryCard, TModel>
    {
    }
}
