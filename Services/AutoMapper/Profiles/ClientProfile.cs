using AutoMapper;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.AutoMapper.Profiles
{
    public class ClientProfile : Profile
    {
        public ClientProfile()
        {
            CreateMap<ClientAddDto, Client>().ForMember(x => x.CreatedDate, opt => opt.MapFrom(x => DateTime.Now));
            CreateMap<ClientUpdateDto, Client>().ForMember(x => x.CreatedDate, opt => opt.MapFrom(x => DateTime.Now));
            CreateMap<Client, ClientUpdateDto>();
        }
    }
}
