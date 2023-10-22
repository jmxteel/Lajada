using AutoMapper;
using Lajada.Domain.Entities;
using Lajada.Domain.IRepository.IGenericRepository;
using Lajada.Services.IServiceRepository;
using Lajada.Services.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lajada.Services.ServiceRepository
{
    public class GenericService<TEntity>: IGenericService<TEntity> where TEntity : class
    {
        private readonly IGenericRepository<TEntity> _genericRepository;
        private readonly IMapper _mapper;

        public GenericService(IGenericRepository<TEntity> genericRepository, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }

        public async Task<TEntity?> GetByIdAsync(int id)
        {
            var result = await _genericRepository.GetByIdAsync(id);
            return _mapper.Map<TEntity>(result);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            var result = await _genericRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<TEntity>>(result);

        }

        public Task AddAsync(TEntity entity)
        {
            return _genericRepository.AddAsync(entity);
        }

        public Task UpdateAsync(TEntity entity)
        {
            return _genericRepository.UpdateAsync(entity);
        }

        public Task DeleteAsync(TEntity entity)
        {
            return _genericRepository.DeleteAsync(entity);
        }
    }
}
