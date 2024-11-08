namespace Hospital_Appointment_Management_System.Models
{
    public class HospitalDepartment : PrimaryKeyConstant
    {
        public int HospitalId { get; set; }
        public int DepartmentId { get; set; }
        public Hospitals Hospitals { get; set; }
        public Departments Departments { get; set; }

    }
}
