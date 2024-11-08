namespace Hospital_Appointment_Management_System.Models
{
    public class Feedback : PrimaryKeyConstant
    {
        public int? Stars {  get; set; }
        public string? Description { get; set; }

        public int? AppointmentId {  get; set; }
        public Appointments Appointments { get; set; }
    }
}
