using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPromotion.Business.Interface;
using WebPromotion.Models;
using WebPromotion.Services;
using WebPromotion.Services.DTO;

namespace WebPromotion.Business
{
    public class TestDriveBusiness : ITestDriveBusiness
    {
        private readonly ITestDriveService _testDriveService;

        public TestDriveBusiness(ITestDriveService testDriveService)
        {
            _testDriveService = testDriveService;
        }


        public Task<TestDrive> InsertTestDriveGuest(TestDriveInsertGuestDTO model)
        {
            try
            {
                return _testDriveService.CreateAsyncTestDriveGuest(model);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while inserting the test drive guest.", ex);

            }
        }
    }
}