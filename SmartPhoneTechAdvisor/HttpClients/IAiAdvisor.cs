using Refit;
using SmartPhoneTechAdvisor.Models;

namespace SmartPhoneTechAdvisor.HttpClients
{
    public interface IAiAdvisor
    {
        [Get("/{phone}")]
        Task<AiPhoneSpec> GetAiPhoneSpecAsync(string phone);
    }
}
