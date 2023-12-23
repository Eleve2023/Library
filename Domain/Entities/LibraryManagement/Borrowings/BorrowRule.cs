using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.LibraryManagement.Borrowings
{
    // CLASSE POUR GERER LES EMPRUNT
    public class BorrowRule
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        // REGLE DE GESTION : Ajout de la durée du prêt
        public int LoanDuration { get; set; }
        // REGLE DE GESTION : Ajout du délai toléré
        public int DelayTolerated { get; set; }
        // REGLE DE GESTION : Ajout de l'interdiction d'emprunter
        public int ProhibitionToBorrow { get; set; }
        // REGLE DE GESTION : Ajout du nombre maximum d'emprunts
        public int MaxBorrowing { get; set; }
        // NOUVELLE REGLE DE GESTION : Ajout du montant de l'amende par jour en cas de retard
        [Column(TypeName = "decimal(20, 5)")]
        public decimal FinePerDayForLateReturn { get; set; }
        // NOUVELLE REGLE DE GESTION : Ajout du montant de l'amende en cas de dégradation
        [Column(TypeName = "decimal(20, 5)")]
        public decimal FineForDamage { get; set; }
        // NOUVELLE REGLE DE GESTION : Ajout du pourcentage à ajouter à la valeur des ouvrages en cas de perte
        [Column(TypeName = "decimal(20, 5)")]
        public decimal PercentageToAddForLostItem { get; set; }

    }
}
