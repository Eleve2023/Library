using System.ComponentModel.DataAnnotations;

namespace Application.Dtos.Ouvrages
{
    public class WorkDto
    {
        [RegularExpression(@"\d{9}[\d|X]", ErrorMessage = "Doit être un ISBN-10 valide.")]
        public string CodeISBN { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Author { get; set; } = null!;
        public int DomainId { get; set; }
        public WorkDomainDto? Domain { get; set; } = null!;
        public int TypeId { get; set; }
        public WorkTypeDto? Type { get; set; } = null!;
        public bool IsAvailable { get; set; } = true;
        public bool IsBorrowing { get; set; } = true;

    }

}
