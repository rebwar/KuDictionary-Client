using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using KuDictionary_Client.Models;

namespace KuDictionary_Client.Services
{
    public interface IKuDictionaryService
    {
         Task<IEnumerable<KuDictionary>> GetAllWords();

         Task<KuDictionary> GetWord(string word);

         
    }
}