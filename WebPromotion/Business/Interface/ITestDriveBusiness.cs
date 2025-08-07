using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPromotion.Services.DTO;

namespace WebPromotion.Business.Interface
{
    public interface ITestDriveBusiness
    {
        public Task<Models.TestDrive> InsertTestDriveGuest(TestDriveInsertGuestDTO model);
    }
}