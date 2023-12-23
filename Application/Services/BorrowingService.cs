using Application.Dtos.LibraryManagement.Borrowings;
using Application.Dtos.Ouvrages;
using AutoMapper;
using Domain.Entities.LibraryManagement.Borrowings;
using Domain.Interfaces;

namespace Application.Services
{
    public class BorrowingService(IBorrowingRepository<BorrowingDto> commonRepository, IMapper mapper, 
        IBorrowingAlertViewRepository<BorrowingAlertViewDto> borrowingAlertViewRepository, IBorrowRuleRepository<BorrowRuleDto> borrowRuleRepository,
        IWorkRepository<WorkDto> workRepository
        ) : CommonService<Borrowing, BorrowingDto>(commonRepository, mapper)
    {
        public override async Task<object> AddAsync(BorrowingDto modelDto)
        {
            // verifie si la person n'est pas interdite d'emprunte                                    
            var alertViewsByCart = await borrowingAlertViewRepository.GetCountBorrowingAlertByLibriryCart(modelDto.LibraryCardId);
            if (alertViewsByCart > 0)
            {
                throw new Exception("interdit");// todo: gestion de cette erreur
            }

            // vérifie si la Person n'a dépasse nombre d'emprunt
            var borrowings = await  commonRepository.GetAllAsync();
            var borrowingsByCart = borrowings.Where(e => e.LibraryCardId == modelDto.LibraryCardId).ToList();
            
            var borrowRules = await borrowRuleRepository.GetAllAsync();
            var borrowRule = borrowRules.First(e => e.Id == modelDto.BorrowRuleId);
            if (borrowingsByCart.Count > borrowRule.MaxBorrowing )
            {
                throw new Exception("déplacement"); // todo: gestion de cette erreur
            }
            
            // verifie si l'ouvrage est disponible
            var work = await workRepository.GetByIdAsync(modelDto.WorkCodeISBN);
            if(work == null || !work.IsAvailable || !work.IsBorrowing)
            {
                throw new Exception("non disponible"); // todo: gestion de cette erreur
            }
            return await base.AddAsync(modelDto);
        }
    }

}
