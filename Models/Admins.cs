using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital_Appointment_Management_System.Models
{
    public class Admins : PrimaryKeyConstant
    {
        public int? HospitalId { get; set; }
        public Hospitals? Hospitals { get; set; }
        public int? UserId { get; set; }
        public Users? Users { get; set; }
    }
}
