using System;
using DealerApi.Entities.Models;

namespace DealerApi.DAL.Interfaces 
{
    public interface ITestDrive : ICrud<TestDrive>
    {
        public Task<TestDrive> CreateTestDriveGuestAsync(
            Customer dataCustomer,
            TestDrive testDrive,
            DealerCar dataDealerCar
        );

    }
}