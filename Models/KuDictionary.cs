using System.ComponentModel.DataAnnotations;

namespace KuDictionary_Client.Models
{
    public class KuDictionary
    {
        public int Id { get; set; }
        [Required]
        public string Kurdish { get; set; }
        [Required]
        public string Farsi { get; set; }
    }
}