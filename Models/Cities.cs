namespace Hospital_Appointment_Management_System.Models
{
    public class Cities : PrimaryKeyConstant
    {
        public string? CityName { get; set; }
        public int? CountryId { get; set; }
        public Countries? Countries { get; set; }

        public List<Hospitals> Hospitals { get; set; }
    }
}
