using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebPromotion.Models;
using WebPromotion.ViewModels.ConsultHistoryView;

namespace WebPromotion.DAL.ConsultationDAL
{
    public class ConsultationDALClass : IConsultation
    {
        private readonly DBPromotionExerciseContext _context;

        public ConsultationDALClass(DBPromotionExerciseContext context)
        {
            _context = context;
        }
        

        public ConsultHistory Create(ConsultHistory entity)
        {
            try
            {
                var consultHistory = new ConsultHistory
                {
                    CustomerId = entity.CustomerId,
                    DealerId = entity.DealerId,
                    SalesPersonId = entity.SalesPersonId,
                    Budget = entity.Budget,
                    ConsultDate = entity.ConsultDate,
                    Note = entity.Note
                };

                _context.ConsultHistories.Add(consultHistory);
                _context.SaveChanges();

                return consultHistory;
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log them)
                throw new Exception("Error creating consultation history", ex);
            }
        }

        public async Task<ConsultHistory> CreateAsyncConsultHistoryGuest(ConsultHistoryInsertGuestViewModels model)
        {
            using (var transaction = await _context.Database.BeginTransactionAsync())
            {
                try
                {
                    // Debug: Log input model
                    Console.WriteLine($"Input model: {JsonSerializer.Serialize(model)}");
                    
                    // Validate DealerId exists
                    if (model.DealerId == 0)
                    {
                        throw new ArgumentException("DealerId is required and must be valid");
                    }
                    
                    var dealerExists = await _context.Dealers.AnyAsync(d => d.DealerId == model.DealerId);
                    if (!dealerExists)
                    {
                        throw new ArgumentException($"Dealer with ID {model.DealerId} does not exist");
                    }
                    
                    var customer = new Customer
                    {
                        FirstName = model.FirstName,
                        LastName = model.LastName,
                        Email = model.Email,
                        PhoneNumber = model.PhoneNumber,
                        CustomerId = 0 // Assuming CustomerId is auto-generated
                    };

                    Console.WriteLine($"Creating customer: {JsonSerializer.Serialize(customer)}");
                    Console.WriteLine($"Customer details: FirstName={customer.CustomerId}, LastName={customer.LastName}, Email={customer.Email}, PhoneNumber={customer.PhoneNumber}");

                    _context.Customers.Add(customer);
                    await _context.SaveChangesAsync();

                    var consultHistory = new ConsultHistory
                    {
                        DealerId = model.DealerId,
                        Budget = model.Budget,
                        ConsultDate = model.ConsultDate,
                        Note = model.Note,
                        CustomerId = customer.CustomerId, // Link to the newly created customer
                        SalesPersonId = null
                    };

                    Console.WriteLine("Creating consultation history for guest:" + JsonSerializer.Serialize(consultHistory));

                    _context.ConsultHistories.Add(consultHistory);
                    await _context.SaveChangesAsync();

                    var notification = new Notification
                    {
                        DealerId = model.DealerId,
                        ConsultHistoryId = consultHistory.ConsultHistoryId,
                        Message = $"New consultation history created for {model.Email} {model.FirstName} {model.LastName} on {consultHistory.ConsultDate.ToShortDateString()} at dealer {model.DealerId}",
                        Priority = 1,
                        NotificationType = "ConsultationRequest",
                        CreatedAt = DateTime.UtcNow

                    };

                    Console.WriteLine("Creating notification: " + JsonSerializer.Serialize(notification));

                    _context.Notifications.Add(notification);
                    await _context.SaveChangesAsync();

                    await transaction.CommitAsync();

                    return consultHistory;
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    throw new Exception("Error creating consultation history for guest", ex);
                }
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ConsultHistory> GetAll()
        {
            throw new NotImplementedException();
        }

        public ConsultHistory GetById(int id)
        {
            throw new NotImplementedException();
        }

        public ConsultHistory Update(ConsultHistory entity)
        {
            throw new NotImplementedException();
        }
    }
}