using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Domain.Enumerations;

namespace Domain.Entities.Persons
{
    public class Person
    {
        [Key] public int Id { get; set; }

        [StringLength(50)] public string FirstName { get; set; } = null!;

        [StringLength(50)] public string LastName { get; set; } = null!;
        [Column(TypeName = "nvarchar")][StringLength(10)] public PersonStatu Statu { get; set; } = default!;

    }
}
