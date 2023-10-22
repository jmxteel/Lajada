using AutoMapper;
using Lajada.Domain.Entities;
using Lajada.Domain.IRepository;
using Lajada.Domain.Repository;
using Lajada.Services.IServiceRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lajada.Services.ServiceRepository
{
    public class PersonalInformationService: GenericService<Personal_Information>, IPersonalInformationService
    {
        private readonly IPersonalInformationRepository _personalInformationRepository;
        private readonly IMapper _mapper;

        public PersonalInformationService(IPersonalInformationRepository personalInformationRepository, IMapper mapper): base(personalInformationRepository, mapper)
        {
            _personalInformationRepository = personalInformationRepository;   
            _mapper = mapper;
        }
    }
}
