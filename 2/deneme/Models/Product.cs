using System.ComponentModel.DataAnnotations;

namespace deneme.Models
{
    public class Product
    {
        [Required(ErrorMessage ="lütfen product name gir")]
        [StringLength(100,ErrorMessage ="max 100 karakter giriniz")]
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        [EmailAddress(ErrorMessage ="email formatında gir")]
        public string Email { get; set; }
    }
}
