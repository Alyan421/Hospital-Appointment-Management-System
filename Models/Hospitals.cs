using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital_Appointment_Management_System.Models
{
    public class Hospitals : PrimaryKeyConstant
    {
        public string? Name { get; set; }
        public string? ContactInfo { get; set; }
        public int? CityId { get; set; }
        public Cities? Cities { get; set; }
        public ICollection<HospitalDepartment> HospitalDepartments { get; set; }
        public ICollection<HospitalDoctors> HospitalDoctors { get; set; }
    }
}
