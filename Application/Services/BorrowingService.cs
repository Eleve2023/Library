using Application.Dtos.LibraryManagement.Borrowings;
using Application.Dtos.Ouvrages;
using AutoMapper;
using Domain.Entities.LibraryManagement.Borrowings;
using Domain.Interfaces;

namespace Application.Services
{
    public class BorrowingService(IBorrowingRepository<BorrowingDto> borrowingRepository, IMapper mapper, 
        IBorrowingAlertViewRepository<BorrowingAlertViewDto> borrowingAlertViewRepository, IBorrowRuleRepository<BorrowRuleDto> borrowRuleRepository,
        IWorkRepository<WorkDto> workRepository
        ) : CommonService<Borrowing, BorrowingDto>(borrowingRepository, mapper)
    {
        private readonly IBorrowingRepository<BorrowingDto> borrowingRepository = borrowingRepository;
        private readonly IMapper mapper = mapper;
        private readonly IBorrowingAlertViewRepository<BorrowingAlertViewDto> borrowingAlertViewRepository = borrowingAlertViewRepository;
        private readonly IBorrowRuleRepository<BorrowRuleDto> borrowRuleRepository = borrowRuleRepository;
        private readonly IWorkRepository<WorkDto> workRepository = workRepository;

        public override async Task<object> AddAsync(BorrowingDto modelDto)
        {
            // verifie si la person n'est pas interdite d'emprunte                                    
            var alertViewsByCart = await borrowingAlertViewRepository.GetCountBorrowingAlertByLibriryCart(modelDto.LibraryCardId);
            if (alertViewsByCart > 0)
            {
                throw new Exception("interdit");// todo: gestion de cette erreur
            }

            // vérifie si la Person n'a dépasse nombre d'emprunt            
            var borrowingsByCart = await borrowingRepository.GetCountBorrowingByLibriryCart(modelDto.LibraryCardId);            
            var borrowRule = await borrowRuleRepository.GetByIdAsync(modelDto.BorrowRuleId);
            if (borrowingsByCart > borrowRule.MaxBorrowing )
            {
                throw new Exception("dépassement"); // todo: gestion de cette erreur
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
