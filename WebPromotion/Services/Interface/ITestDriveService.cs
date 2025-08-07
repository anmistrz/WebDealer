using System;
using WebPromotion.Models;
using WebPromotion.Services.DTO;

namespace WebPromotion.Services
{
    public interface ITestDriveService : ICrud<Models.TestDrive>
    {
        public Task<Models.TestDrive> CreateAsyncTestDriveGuest(TestDriveInsertGuestDTO model);
    }
}