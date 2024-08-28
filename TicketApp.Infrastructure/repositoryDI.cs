using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TicketApp.Core.Interfaces;
using TicketApp.Infrastructure.Data;
using TicketApp.Infrastructure.Repository;
using TicketApp.Core;


namespace TicketApp.Infrastructure
{
    public static class repositoryDI
    {
        public static IServiceCollection AddRepo(this IServiceCollection services, ConfigurationManager configurationManager)
        {
            //database context
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(configurationManager.GetConnectionString("DefaultConnection")));
            services.AddScoped<AppDbContext>();

            //repositories
            services.AddScoped<IAccountRepository, AccountRepository>(); //creates an instance on AccountRepository whenever IAccountRepository is requested
            services.AddScoped<IBookingRepository, BookingRepository>();
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IPaymentRepository, PaymentRepository>();
            services.AddScoped<ITrainRepository, TrainRepository>();
            services.AddScoped<ITripRepository, TripRepository>();
            services.AddScoped<IStationRepository, StationRepository>();
            services.AddScoped<ITripStationRepository, TripStationRepository>();
            services.AddScoped<ITripPriceRepository, TripPriceRepository>();
            //services.AddScoped<IScheduleRepository, ScheduleRepository>();
            //services.AddScoped<ITripGroupRepository, TripGroupRepository>();
            services.AddScoped<ITripScheduleRepository, TripScheduleRepository>();

            return services;
        }
    }
}
