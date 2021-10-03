using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TripSharing.Domain.Models;
using System.Linq;

namespace TripSharing.Repository.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private DbSet<T> entities;

        public Repository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
            entities = _applicationDbContext.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }

        public T Get(int Id)
        {
            return entities.SingleOrDefault(c => c.Id == Id);
        }

        public void Insert(T entity)
        {
            if (entities == null)
            {
                throw new ArgumentException("empty entity");
            }

            entities.Add(entity);
        }

        public void Uprate(T entity)
        {
            if (entities == null)
            {
                throw new ArgumentException("empty entity");
            }

            entities.Update(entity);
        }

        public void Remove(T entity)
        {
            if (entities == null)
            {
                throw new ArgumentException("empty entity");
            }

            entities.Remove(entity);
        }

        public void SaveChanges()
        {
            _applicationDbContext.SaveChanges();
        }
    }
}