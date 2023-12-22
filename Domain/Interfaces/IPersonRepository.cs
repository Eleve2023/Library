using Domain.Entities.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IPersonRepository<TModel> : ICommonRepository<Person, TModel>
    {
    }
}
