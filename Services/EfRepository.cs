using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_JWT.Entities;
using WebApi_JWT.Utils;

namespace WebApi_JWT.Services
{
    public class EfRepository<T> : IEfRepository<T> where T : BaseEntity
    {
        private readonly UserDBContext   _context;
        //private readonly ILogger _logger;

        public EfRepository(UserDBContext context /*ILogger logger*/)
        {
            _context = context;
            //_logger = logger;
        }

        public async Task<Guid> Add(T entity)
        {
            var result = await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return result.Entity.Id;
        }

        public T DeleteById(Guid Id)
        {
                var result = _context.Set<T>().FirstOrDefault(x=> x.Id == Id);
                if (result == null)
                {
                    //_logger.LogError("Id incorect", Id);
                    return null;
                }
                else
                {
                    _context.Set<T>().Remove(result);
                    _context.SaveChanges();
                }
                 return result;
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(Guid Id)
        {
            var result = _context.Set<T>().FirstOrDefault(x => x.Id == Id);

            if (result == null)
            {
                //_logger.LogError("Id incorect", Id);
                return null;
            }
            return result;
        }
    }
}
