using System.ComponentModel.DataAnnotations;

namespace WebApplication2.ViewModels
{
    public class RegisterVM
    {
        public string FullName { get; set; }
        public string UserName { get; set; }
        [Required,DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
        [Required, DataType(DataType.Password),Compare(nameof(Password))]
        public string CheckPassword { get; set; }
    }
}
