using Lajada.Domain.Entities;
using Lajada.Domain.IRepository.IGenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lajada.Domain.IRepository
{
    public interface IPersonalInformationRepository: IGenericRepository<Personal_Information>, IDisposable
    {

    }
}
