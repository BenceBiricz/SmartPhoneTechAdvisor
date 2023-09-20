using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SmartPhoneTechAdvisor.HttpClients;
using SmartPhoneTechAdvisor.Models;

namespace SmartPhoneTechAdvisor.Pages
{
    public class CompareTableModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public List<string> Phones { get; set; } = new();

        public List<AiPhoneSpec> PhonesSpecs { get; set; } = new();

        private readonly IAiAdvisor _aiAdvisor;

        public CompareTableModel(IAiAdvisor aiAdvisor)
        {
            _aiAdvisor = aiAdvisor;
        }
        public async Task OnGet()
        {
            foreach (var phone in Phones)
            {
                var phoneSpecs = await _aiAdvisor.GetAiPhoneSpecAsync(phone);
                PhonesSpecs.Add(phoneSpecs);
            }
        }
    }
}
