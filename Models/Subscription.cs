using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Models
{
    public class Subscription
    {
       public int Id { get; set; } 
         [Required(ErrorMessage = "CallBack URL is required")]
    [Url(ErrorMessage = "Invalid URL format")]
       public string? CallBackURL { get; set; }
       public bool SendAll { get; set; }
       public int retryAttempts { get; set; }
       public bool active { get; set; }

       public List<string>  SelectedEvents { get; set; } 
        public DateTime CreationTime { get; set; }

    }
}