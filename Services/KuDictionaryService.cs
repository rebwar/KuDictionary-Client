using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using KuDictionary_Client.Models;

namespace KuDictionary_Client.Services
{
    public class KuDictionaryService : IKuDictionaryService
    {
        private readonly HttpClient _httpClient;

        public KuDictionaryService(HttpClient httpClient)
        {
            _httpClient=httpClient;
        }
        public async Task<IEnumerable<KuDictionary>> GetAllWords()
        {
            var apiResponse=await _httpClient.GetStreamAsync("api/dictionary");
            return await JsonSerializer.DeserializeAsync<IEnumerable<KuDictionary>>(apiResponse,new JsonSerializerOptions(){PropertyNameCaseInsensitive=true});


        }

        public async Task<KuDictionary> GetWord(string word)
        {
            var apiResponse=await _httpClient.GetStreamAsync($"api/dictionary/{word}");
            return await JsonSerializer.DeserializeAsync<KuDictionary>(apiResponse,new JsonSerializerOptions{PropertyNameCaseInsensitive=true});
        }
    }
}