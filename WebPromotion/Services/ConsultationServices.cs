using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebPromotion.Models;
using WebPromotion.Services.DTO;
using WebPromotion.ViewModels.ConsultHistoryView;

namespace WebPromotion.Services.Consultation
{
    public class ConsultationServices : IConsultationServices
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;
        public ConsultationServices(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
            _httpClient.BaseAddress = new Uri(_configuration["ApiBaseUrl"]);
        }


        public Task<ConsultHistory> CreateAsyncConsultHistoryGuest(ConsultationInsertGuestDTO model)
        {
           try 
           {
                var jsonContent = JsonSerializer.Serialize(model);
                var content = new StringContent(jsonContent, System.Text.Encoding.UTF8, "application/json");

                Console.WriteLine($"Request Data: {jsonContent}");

               var response = _httpClient.PostAsync("ConsultHistory/create-guest", content).Result;
               if (response.IsSuccessStatusCode)
               {
                   return response.Content.ReadFromJsonAsync<ConsultHistory>();
               }
               else
               {
                   throw new Exception($"Error creating consult history: {response.ReasonPhrase}");
               }
           }
           catch (Exception ex)
           {
               throw new Exception($"An error occurred while creating consult history: {ex.Message}", ex);
           }
        }
    }
}