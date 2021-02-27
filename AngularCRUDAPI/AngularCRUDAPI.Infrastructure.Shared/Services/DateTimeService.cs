using AngularCrudApi.Application.Interfaces;
using System;

namespace AngularCrudApi.Infrastructure.Shared.Services
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}
