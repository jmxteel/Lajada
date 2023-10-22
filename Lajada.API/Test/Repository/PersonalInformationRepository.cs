using Lajada.Domain.Context;
using Lajada.Domain.Entities;
using Lajada.Domain.IRepository;
using Lajada.Domain.IRepository.IGenericRepository;
using Lajada.Domain.Repository.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lajada.Domain.Repository
{
    public class PersonalInformationRepository: GenericRepository<Personal_Information>,IPersonalInformationRepository
    {
        public PersonalInformationRepository(LajadaDbContext context) : base(context) 
        { 
        }
        
    }
}
