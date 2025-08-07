using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPromotion.Services.DTO;

namespace WebPromotion.Services.TestDrive
{
    public class TestDriveServices : ITestDriveService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public TestDriveServices(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
            _httpClient.BaseAddress = new Uri(_configuration["ApiBaseUrl"] ?? "");
        }

        public Models.TestDrive Create(Models.TestDrive entity)
        {
            throw new NotImplementedException();
        }

        public async Task<Models.TestDrive> CreateAsyncTestDriveGuest(TestDriveInsertGuestDTO model)
        {
           try 
           {
                var response = await _httpClient.PostAsJsonAsync("TestDrive/create-guest", model);
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<Models.TestDrive>();
                }
                else
                {
                    throw new Exception($"Error creating test drive: {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while creating the test drive guest.", ex);
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Models.TestDrive> GetAll()
        {
            throw new NotImplementedException();
        }

        public Models.TestDrive GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Models.TestDrive Update(Models.TestDrive entity)
        {
            throw new NotImplementedException();
        }
    }
}