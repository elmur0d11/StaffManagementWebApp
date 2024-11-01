using StaffManagement.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Http;
using StaffManagement.Attributes;

namespace StaffManagement.ViewModels
{
    public class HomeCreateViewModel
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("First Name")]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Last Name")]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Email is not valid")]
        [DisplayName("Email")]
        public string Email { get; set; }

        [Required]
        [DisplayName("Department")]
        public Departments? Department { get; set; }

        [MaxFileSize(1000)]
        [AllowedExtensions(new string[] {".jpg", ".png"})]
        public IFormFile Photo { get; set; }
    }
}
