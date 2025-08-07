using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DealerApi.Entities.Models;

namespace DealerApi.Application.Interface
{
    public interface ITestDriveServices
    {
        public Task<TestDrive> CreateTestDriveGuestAsync(
            Customer dataCustomer,
            TestDrive testDrive,
            DealerCar dataDealerCar
        );
    }
}