using Microsoft.EntityFrameworkCore;
using TicketApp.Core.Entities;
using TicketApp.Core.Interfaces;
using Microsoft.AspNetCore.JsonPatch;
using TicketApp.Infrastructure.Data;

namespace TicketApp.Infrastructure.Repository
{
    public class TripScheduleRepository: BaseRepository<TripSchedule>,ITripScheduleRepository
    {
        private readonly AppDbContext _context;
        public TripScheduleRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _context = appDbContext;
        }
         public async Task<IEnumerable<TripScheduleDetail>> GetTripScheduleDetailsByTripId(int Id)
        {
            
            //Get the trip schedules
            var query = from tripSchedule in _context.TripSchedules
                        join trip in _context.Trips on tripSchedule.tripId equals trip.Id
                        join schedule in _context.Schedules on tripSchedule.scheduleId equals schedule.Id
                        join train in _context.Trains on tripSchedule.trainId equals train.Id
                        join tripStatus in _context.TripStatuses on tripSchedule.tripStatusId equals tripStatus.Id
                        where trip.Id == Id
                        select new TripScheduleDetail
                        {
                            tripId = trip.Id,
                            tripScheduleId = tripSchedule.Id,
                            trainNo = train.trainNo,
                            trainId = train.Id,
                            scheduleId = schedule.Id,
                            tripStatusId = tripStatus.Id,
                            tripPriceId = trip.tripPriceId,
                            statusName = tripStatus.statusName,
                            departureStation = trip.departureStation,
                            arrivalStation = trip.arrivalStation,
                            numberOfStops = trip.numberOfStops,
                            numberOfSeats = tripSchedule.numberOfSeats,
                            departureTime = schedule.departureTime,
                            arrivalTime = schedule.arrivalTime

                        };

            var results =  await query.ToListAsync();
            return results;

        }

        public async Task<TripScheduleDetail> GetTripScheduleDetailsByTripScheduleId(int Id)
        {

            //Get the trip schedules
            var query = from tripSchedule in _context.TripSchedules
                        join trip in _context.Trips on tripSchedule.tripId equals trip.Id
                        join schedule in _context.Schedules on tripSchedule.scheduleId equals schedule.Id
                        join train in _context.Trains on tripSchedule.trainId equals train.Id
                        join tripStatus in _context.TripStatuses on tripSchedule.tripStatusId equals tripStatus.Id
                        where tripSchedule.Id == Id
                        select new TripScheduleDetail
                        {
                            tripId = trip.Id,
                            tripScheduleId = tripSchedule.Id,
                            trainNo = train.trainNo,
                            trainId = train.Id,
                            scheduleId = schedule.Id,
                            tripStatusId = tripStatus.Id,
                            tripPriceId = trip.tripPriceId,
                            statusName = tripStatus.statusName,
                            departureStation = trip.departureStation,
                            arrivalStation = trip.arrivalStation,
                            numberOfStops = trip.numberOfStops,
                            numberOfSeats = tripSchedule.numberOfSeats,
                            departureTime = schedule.departureTime,
                            arrivalTime = schedule.arrivalTime

                        };

            var results = await query.SingleOrDefaultAsync();
            return results;

        }

        public async Task UpdateTripSeatsNo(int Id, JsonPatchDocument tripSchedule)
        {
            var updateTripSchedule = await GetById(Id);
            if (updateTripSchedule != null)
            {
                tripSchedule.ApplyTo(updateTripSchedule);
                await _context.SaveChangesAsync();
            }
        }

    }
}
