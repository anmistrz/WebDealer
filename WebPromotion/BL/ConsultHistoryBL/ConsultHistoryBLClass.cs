using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using WebPromotion.DAL.ConsultationDAL;
using WebPromotion.DAL.CustomerDAL;
using WebPromotion.Models;
using WebPromotion.ViewModels.ConsultHistoryView;

namespace WebPromotion.BL.ConsultHistoryBL
{
    public class ConsultHistoryBLClass : IConsultHistoryBL
    {
        private readonly IConsultation _consultationDAL;
        private readonly ICustomer _customerDAL;

        public ConsultHistoryBLClass(IConsultation consultationDAL, ICustomer customerDAL)
        {
            _consultationDAL = consultationDAL;
            _customerDAL = customerDAL;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ConsultHistoryViewModels> GetAllConsultHistories()
        {
            throw new NotImplementedException();
        }

        public ConsultHistoryViewModels GetConsultHistoryById(int id)
        {
            throw new NotImplementedException();
        }

        public ConsultHistoryInsertViewModels InsertConsultHistory(ConsultHistoryInsertViewModels model)
        {
            throw new NotImplementedException();
        }

        public async Task<ConsultHistoryInsertGuestViewModels> InsertConsultHistoryGuestAsync(ConsultHistoryInsertGuestViewModels model)
        {
            try
            {
                Console.WriteLine($"Received model: {JsonSerializer.Serialize(model)}");
                var newConsultHistoryGuest = new ConsultHistoryInsertGuestViewModels
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    PhoneNumber = model.PhoneNumber,
                    Budget = model.Budget ?? 0, // Default to 0 if null
                    ConsultDate = model.ConsultDate,
                    Note = model.Note,
                    DealerId = model.DealerId,
                };
                var consultHistory = await _consultationDAL.CreateAsyncConsultHistoryGuest(newConsultHistoryGuest);
                return new ConsultHistoryInsertGuestViewModels
                {
                    CustomerId = consultHistory.CustomerId ?? 0,
                    DealerId = consultHistory.DealerId,
                    SalesPersonId = consultHistory.SalesPersonId ?? 0,
                    Budget = consultHistory.Budget,
                    ConsultDate = consultHistory.ConsultDate,
                    Note = consultHistory.Note
                };

            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log them)
                throw new Exception("Error inserting consultation history for guest", ex);
            }
        }

        public ConsultHistoryInsertGuestViewModels InsertConsultHistoryGuest(ConsultHistoryInsertGuestViewModels model)
        {
            return InsertConsultHistoryGuestAsync(model).Result;
        }

        public ConsultHistoryUpdateViewModels UpdateConsultHistory(ConsultHistoryUpdateViewModels model)
        {
            throw new NotImplementedException();
        }
    }

    
}