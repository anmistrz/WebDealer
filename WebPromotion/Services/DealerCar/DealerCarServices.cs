using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http.Json;
using WebPromotion.Models;
using WebPromotion.Services.DTO;
using System.Text.Json;

namespace WebPromotion.Services.DealerCar
{
    public class DealerCarServices : IDealerCarServices
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public DealerCarServices(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
            // Assuming the base URL for the API is set in the configuration
            _httpClient.BaseAddress = new Uri(_configuration["ApiBaseUrl"] ?? "");

        }


        public IDealerCarServices Create(IDealerCarServices entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IDealerCarServices> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDealerCarServices GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IDealerCarServices Update(IDealerCarServices entity)
        {
            throw new NotImplementedException();
        }


        //response method to fetch dealer car options by status


        public async Task<IEnumerable<DealerCarUnitOptionsDTO>> GetOptionsDealerCarUnitByStatusAsync(string status)
        {
            var response = await _httpClient.GetAsync($"DealerCar/options-by-status/{status}");
            Console.WriteLine($"Response Data: {response}");
            if (!response.IsSuccessStatusCode)
            {
                // Prefer not to throw System.Exception directly
                return Enumerable.Empty<DealerCarUnitOptionsDTO>();
            }

            var apiData = await response.Content.ReadAsStringAsync();
            Console.WriteLine($"API Data: {apiData}");
            if (string.IsNullOrEmpty(apiData))
            {
                return Enumerable.Empty<DealerCarUnitOptionsDTO>();
            }

            var apiOptions = JsonSerializer.Deserialize<List<DealerCarUnitOptionsDTO>>(apiData, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });



            Console.WriteLine($"Deserialized Options: {JsonSerializer.Serialize(apiOptions)}");
            return apiOptions ?? Enumerable.Empty<DealerCarUnitOptionsDTO>();
        }
    }
}
