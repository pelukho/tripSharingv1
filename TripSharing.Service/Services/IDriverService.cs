using System.Collections;
using System.Collections.Generic;
using TripSharing.Domain.Models;

namespace TripSharing.Service.Services
{
    public interface IDriverService
    {
        IEnumerable<Driver> GetAllDrivers();

        Driver GetDriver(int Id);

        void InsertDriver(Driver driver);
        
        void UpdateDriver(Driver driver);
        
        void DeleteDriver(int Id);
    }
}