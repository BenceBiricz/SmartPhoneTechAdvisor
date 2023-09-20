using SmartPhoneTechAdvisor.Models;
using SmartPhoneTechAdvisor.HttpClients;

namespace SmartPhoneTechAdvisor.Services
{
    public class AdvisorService: IAdvisorService
    {
        private readonly IAiAdvisor _aiAdvisor;

        public Task<AiPhoneSpec> GetPhoneSpecsAsync(string phone)
        {
            throw new NotImplementedException();
        }
    }
}
