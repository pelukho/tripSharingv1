using System.Collections.Generic;
using TripSharing.Domain.Models;
using TripSharing.Repository.Repository;

namespace TripSharing.Service.Services
{
    public class DriverService : IDriverService
    {
        private IRepository<Driver> _repository;

        public DriverService(IRepository<Driver> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Driver> GetAllDrivers()
        {
            return _repository.GetAll();
        }

        public Driver GetDriver(int Id)
        {
            return _repository.Get(Id);
        }

        public void InsertDriver(Driver driver)
        {
            _repository.Insert(driver);
            _repository.SaveChanges();
        }

        public void UpdateDriver(Driver driver)
        {
            _repository.Uprate(driver);
            _repository.SaveChanges();
        }

        public void DeleteDriver(int Id)
        {
            _repository.Remove(GetDriver(Id));
            _repository.SaveChanges();
        }
    }
}