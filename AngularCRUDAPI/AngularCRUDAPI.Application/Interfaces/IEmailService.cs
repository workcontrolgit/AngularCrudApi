using AngularCrudApi.Application.DTOs.Email;
using System.Threading.Tasks;

namespace AngularCrudApi.Application.Interfaces
{
    public interface IEmailService
    {
        Task SendAsync(EmailRequest request);
    }
}