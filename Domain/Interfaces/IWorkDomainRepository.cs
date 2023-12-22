using Domain.Entities.Works;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IWorkDomainRepository<TModel> : ICommonRepository<WorkDomain, TModel>
    {

    }
}
