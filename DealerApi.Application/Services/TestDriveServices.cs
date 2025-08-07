using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DealerApi.Application.Interface;
using DealerApi.DAL.Interfaces;
using DealerApi.Entities.Models;

namespace DealerApi.Application.Services
{
    public class TestDriveServices : ITestDriveServices
    {
        private readonly ITestDrive _testDriveDAL;

        public TestDriveServices(ITestDrive testDriveDAL)
        {
            _testDriveDAL = testDriveDAL ?? throw new ArgumentNullException(nameof(testDriveDAL), "TestDrive DAL cannot be null");
        }

        public Task<TestDrive> CreateTestDriveGuestAsync(Customer dataCustomer, TestDrive dataTestDrive, DealerCar dataDealerCar)
        {
            try
            {
                if (dataCustomer == null)
                {
                    throw new ArgumentNullException(nameof(dataCustomer), "Customer cannot be null");
                }

                // Validate required fields
                if (string.IsNullOrWhiteSpace(dataCustomer.FirstName))
                    throw new ArgumentException("FirstName is required");
                if (string.IsNullOrWhiteSpace(dataCustomer.LastName))
                    throw new ArgumentException("LastName is required");
                if (string.IsNullOrWhiteSpace(dataCustomer.Email))
                    throw new ArgumentException("Email is required");
                if (string.IsNullOrWhiteSpace(dataCustomer.PhoneNumber))
                    throw new ArgumentException("PhoneNumber is required");
                if (dataDealerCar.DealerId <= 0)
                    throw new ArgumentException("DealerId must be greater than 0");

                var customer = new Customer
                {
                    FirstName = dataCustomer.FirstName,
                    LastName = dataCustomer.LastName,
                    Email = dataCustomer.Email,
                    PhoneNumber = dataCustomer.PhoneNumber,
                    UserName = "Guest",
                    IsGuest = true
                };

                var testDrive = new TestDrive
                {
                    Customer = customer,
                    DealerCarUnitId = dataTestDrive.DealerCarUnitId,
                    AppointmentDate = dataTestDrive.AppointmentDate,
                    Note = dataTestDrive.Note,
                    Status = "Pending"
                };

                Console.WriteLine($"TestDriveServices: Processing request for {dataCustomer.Email}");
                Console.WriteLine($"TestDriveServices: Customer Name: {dataCustomer.FirstName} {dataCustomer.LastName}");
                Console.WriteLine($"TestDriveServices: DealerCarId: {dataDealerCar.DealerCarId}, DealerId: {dataDealerCar.DealerId}");

                var dealerCar = new DealerCar
                {
                    DealerCarId = dataDealerCar.DealerCarId,
                    DealerId = dataDealerCar.DealerId
                };

                var result = _testDriveDAL.CreateTestDriveGuestAsync(customer, testDrive, dealerCar);

                if (result == null)
                {
                    throw new Exception("Failed to create test drive.");
                }

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating test drive: {ex.Message}");
                throw; // Re-throw the exception for further handling
            }
        }
    }
}