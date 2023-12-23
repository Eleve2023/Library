using Application.Dtos.LibraryManagement.Borrowings;
using AutoMapper;
using Domain.Entities.LibraryManagement.Borrowings;
using Domain.Interfaces;

namespace Application.Services
{
    public class BorrowingAlertViewService(IBorrowingAlertViewRepository<BorrowingAlertViewDto> commonRepository, IMapper mapper) 
    {
        public virtual async Task<IEnumerable<BorrowingAlertViewDto>> GetAsync()
        {
            IEnumerable<BorrowingAlertView> entities = await commonRepository.GetAllAsync();
            return mapper.Map<List<BorrowingAlertViewDto>>(entities);

        }
        public virtual async Task<BorrowingAlertViewDto> GetAsync(object id)
        {
            var entity = await commonRepository.GetByIdAsync(id);
            return mapper.Map<BorrowingAlertViewDto>(entity);
        }
    }

}
