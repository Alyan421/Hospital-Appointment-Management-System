namespace Hospital_Appointment_Management_System.Models
{
    public class Doctors : PrimaryKeyConstant
    {
        public int? AvgConsultTime { get; set; }
        public string? DoctorName {  get; set; }
        public string? DOB {  get; set; }
        public List<Schedules> Schedules { get; set; }
        public int? Department_id { get; set; }
        public Departments? Departments { get; set; }
        public ICollection<HospitalDoctors> HospitalDoctors { get; set; }
    }
}
