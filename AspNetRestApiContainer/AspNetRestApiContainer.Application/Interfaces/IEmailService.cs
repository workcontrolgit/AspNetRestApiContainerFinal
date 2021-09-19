using AspNetRestApiContainer.Application.DTOs.Email;
using System.Threading.Tasks;

namespace AspNetRestApiContainer.Application.Interfaces
{
    public interface IEmailService
    {
        Task SendAsync(EmailRequest request);
    }
}