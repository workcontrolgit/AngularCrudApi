using AngularCRUDAPI.Application.Interfaces;
using System;

namespace AngularCRUDAPI.Infrastructure.Shared.Services
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}
