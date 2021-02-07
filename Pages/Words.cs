using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KuDictionary_Client.Models;
using KuDictionary_Client.Services;
using Microsoft.AspNetCore.Components;

namespace KuDictionary_Client.Pages
{
    public partial class Words
    {
        public IEnumerable<KuDictionary> kuDictionaries { get; set; }

       [Inject]
       public IKuDictionaryService KuDictionaryService { get; set; }

        protected async override Task OnInitializedAsync()
        {
           kuDictionaries=(await KuDictionaryService.GetAllWords()).ToList();
        }


    }
}