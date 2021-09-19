using AspNetRestApiContainer.Application.Interfaces;
using System;

namespace AspNetRestApiContainer.Infrastructure.Shared.Services
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}