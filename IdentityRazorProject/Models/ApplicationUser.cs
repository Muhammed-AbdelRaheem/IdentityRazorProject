using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace IdentityRazorProject.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required,MaxLength(40)]
        public string FirstName { get; set; }
        [Required, MaxLength(40)]

        public string LastName { get; set; }
        public byte[]? ProfilePicture { get; set; }
    }
}
