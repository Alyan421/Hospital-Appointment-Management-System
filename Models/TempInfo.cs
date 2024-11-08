namespace Hospital_Appointment_Management_System.Models
{
    public class TempInfo : PrimaryKeyConstant
    {
        public double? Weight { get; set; }
        public double? Temperature {  get; set; }
        public int? AppointmentsId { get; set; }
        public Appointments Appointments { get; set; }

    }
}
