namespace Hospital_Appointment_Management_System.Models
{
    public class Countries : PrimaryKeyConstant
    {
        public string? CountryName {  get; set; }
        public List<Cities> Cities { get; set; }
    }
}
