using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enumerations
{
    public enum PersonStatu
    {
        [EnumMember(Value = @"Teacher")]
        Teacher = 0,
        [EnumMember(Value = @"Student")]
        Student = 1,
        [EnumMember(Value = @"Staff")]
        Staff = 2
    }
}
