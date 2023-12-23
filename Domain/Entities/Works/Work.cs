using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Works
{

    public class Work
    {        
        [Key]
        [RegularExpression(@"\d{9}[\d|X]", ErrorMessage = "Doit être un ISBN-10 valide.")]
        public string CodeISBN { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Author { get; set; } = null!;
        public int DomainId { get; set; }
        public WorkDomain Domain { get; set; } = null!;
        public int TypeId { get; set; }
        public WorkType Type { get; set; } = null!;
        public bool IsAvailable { get; set; } = true;
        public bool IsBorrowing { get; set; } = true;

        // NOUVELLE REGLE DE GESTION : Ajout de la valeur pour gérer les amendes en cas de perte d'un ouvrage
        [Column(TypeName = "decimal(20, 5)")]
        public decimal Value { get; set; }

    }

}
