namespace Hospital_Appointment_Management_System.Models
{
    public class HospitalDoctors : PrimaryKeyConstant
    {
        public int? HospitalId { get; set; }
        public int? DoctorsId { get; set; }

        public Hospitals Hospitals { get; set; }
        public Doctors Doctors { get; set; }

    }
}
