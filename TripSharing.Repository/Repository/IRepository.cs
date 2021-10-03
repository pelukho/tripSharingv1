using System.Collections.Generic;
using TripSharing.Domain.Models;

namespace TripSharing.Repository.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();

        T Get(int Id);

        void Insert(T entity);

        void Uprate(T entity);

        void Remove(T entity);

        void SaveChanges();
    }
}