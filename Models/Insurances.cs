namespace Hospital_Appointment_Management_System.Models
{
    public class Insurances : PrimaryKeyConstant
    {
        public string? CompanyName {  get; set; }
        public string? InsuranceType {  get; set; }
        public int? PatientId { get; set; }
        public Patients Patient { get; set; }
    }
}
