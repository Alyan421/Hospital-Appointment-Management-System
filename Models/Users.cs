using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Hospital_Appointment_Management_System.Models
{
    public class Users : PrimaryKeyConstant
    {
        public string? UserName {  get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}
