using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using TicketApp.Core.Interfaces;
using TicketApp.Infrastructure.Data;

namespace TicketApp.Infrastructure.Repository
{
    public static class dependencyInjection   //DI Container
    {
        public static IServiceCollection AddProvider(this IServiceCollection services, ConfigurationManager configuration)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"))); //connect to a SQL Server database
            services.AddScoped<AppDbContext>();
            services.AddScoped<IAccountRepository, AccountRepository>(); //creates an instance on AccountRepository whenever IAccountRepository is requested
            services.AddScoped<IBookingRepository, BookingRepository>();
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
