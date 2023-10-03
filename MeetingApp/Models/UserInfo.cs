using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
      public class UserInfo
      {
        public int Id {get;set;}
        [Required(ErrorMessage ="Ad Alanı Zorunlu")]
        public string?  Name { get; set; }
           [Required(ErrorMessage ="Telefon Zorunlu.")]
        public string? Phone { get; set; }
           [Required(ErrorMessage ="E mail Zorunlu")]
           [EmailAddress(ErrorMessage ="Lutfen Email Adresinizin  doğru girdiğnizden emin olun")]

        public string? Email { get; set; }
           [Required (ErrorMessage="Toplantı Katılım Durumunuzu Giriniz.")]
        public bool? WillAttend{get;set;}


      }
}