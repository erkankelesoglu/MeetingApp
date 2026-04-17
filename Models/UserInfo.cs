using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
    public class UserInfo
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Ad Alanı Zorunludur")]
        public string? Name { get; set; }

        [Required(ErrorMessage ="Telefon Alanı Zorunludur")]
        public string? Phone { get; set; }

        [Required(ErrorMessage ="Hatalı Email Formatı")]
        [EmailAddress]
        public string? Email { get; set; }
        
        [Required(ErrorMessage ="Katılım Durumunuzu Belirtiniz")]
        public bool? WillAttend { get; set; }

    }
    
}