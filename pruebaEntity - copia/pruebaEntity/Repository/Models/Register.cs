
using System.ComponentModel.DataAnnotations;

namespace pruebaEntity.Repository.Models
{
    public class Register
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(password), ErrorMessage ="Password and Confirm password did not match")]
        public string confirmPassword { get; set; }
    }
}
