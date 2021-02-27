using AngularCRUDAPI.Application.DTOs.Email;
using System.Threading.Tasks;

namespace AngularCRUDAPI.Application.Interfaces
{
    public interface IEmailService
    {
        Task SendAsync(EmailRequest request);
    }
}
