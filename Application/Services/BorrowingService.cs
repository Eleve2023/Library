using Application.Dtos.LibraryManagement.Borrowings;
using AutoMapper;
using Domain.Entities.LibraryManagement.Borrowings;
using Domain.Interfaces;

namespace Application.Services
{
    public class BorrowingService(IBorrowingRepository<BorrowingDto> commonRepository, IMapper mapper, 
        IBorrowingAlertViewRepository<BorrowingAlertViewDto> borrowingAlertViewRepository, IBorrowRuleRepository<BorrowRuleDto> borrowRuleRepository
        ) : CommonService<Borrowing, BorrowingDto>(commonRepository, mapper)
    {
        public override async Task<object> AddAsync(BorrowingDto modelDto)
        {
            var alertViews = await borrowingAlertViewRepository.GetAllAsync();
            var alertViewsByCart = alertViews.Where(e => e.CardId == modelDto.LibraryCardId).ToList();

            if (alertViewsByCart.Count > 0)
            {
                throw new Exception("interdit");// todo: gestion de cette erreur
            }

            var borrowings = await  commonRepository.GetAllAsync();
            var borrowingsByCart = borrowings.Where(e => e.LibraryCardId == modelDto.LibraryCardId).ToList();
            
            var borrowRules = await borrowRuleRepository.GetAllAsync();
            var borrowRule = borrowRules.First(e => e.Id == modelDto.BorrowRuleId);
            if (borrowingsByCart.Count > borrowRule.MaxBorrowing )
            {
                throw new Exception("déplacement"); // todo: gestion de cette erreur
            }
            
            
            return base.AddAsync(modelDto);
        }
    }

}
