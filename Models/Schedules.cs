namespace Hospital_Appointment_Management_System.Models
{
    public class Schedules : PrimaryKeyConstant
    {
        public string? ConsultationDay {  get; set; }
        public string? ConsultationTime { get; set; }

        public int? DoectorId {  get; set; }
        public Doctors? Doctors { get; set; }
    }
}
