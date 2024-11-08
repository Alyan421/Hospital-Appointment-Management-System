namespace Hospital_Appointment_Management_System.Models
{
    public class Patients : PrimaryKeyConstant
    {
        public string? PatientName { get; set; }
        public string? DOB { get; set; }

        public int? UsersId { get; set; }
        public Users Users { get; set; }
        public int? AppointmentId { get; set; }
        public Appointments Appointments { get; set; }
    }
}
