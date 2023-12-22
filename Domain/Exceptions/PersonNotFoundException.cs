using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions
{
    public class PersonNotFoundException(int id) : Exception($"No item found with id {id}")
    {
    }
}
