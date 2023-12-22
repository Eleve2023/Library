using Application.Dtos.Ouvrages;
using AutoMapper;
using Domain.Entities.Works;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Helpe
{
    public class MapperHelpe(IMapper mapper)
    {
        public TDistination GetT<TSource, TDistination>(TSource workTypeDto, TDistination workType )
        {
            return mapper.Map(workTypeDto, workType);
        }
    }
}
