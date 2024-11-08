namespace Hospital_Appointment_Management_System.Models
{
    public class Departments : PrimaryKeyConstant {
        public string? DepartmentName {  get; set; }
        public List<Doctors> Doctors { get; set; }

        public ICollection<HospitalDepartment> HospitalDepartments { get; set; }

    }
}
