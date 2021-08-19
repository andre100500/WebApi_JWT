using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi_JWT.Entities;

namespace WebApi_JWT.Services
{
    public interface IEfRepository<T> where T : BaseEntity
    {
        List<T> GetAll();
        T GetById(Guid id);
        Task<Guid> Add(T entity);
        T DeleteById(Guid id);
    }
}