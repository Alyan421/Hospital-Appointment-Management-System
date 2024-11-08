namespace Hospital_Appointment_Management_System.Models
{
    public class Appointments : PrimaryKeyConstant
    {
        public int? PatientId {  get; set; }
        public Patients Patient { get; set; }

        public int? ScheduleId {  get; set; }
        public Schedules Schedules { get; set; }
    }
}
