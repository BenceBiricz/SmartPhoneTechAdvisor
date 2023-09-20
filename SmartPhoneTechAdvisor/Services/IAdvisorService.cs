using SmartPhoneTechAdvisor.Models;
namespace SmartPhoneTechAdvisor.Services
{
    public interface IAdvisorService
    {
        Task<AiPhoneSpec> GetPhoneSpecsAsync(string phone);
    }
}
