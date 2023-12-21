namespace Hospital.Models.Infrastucture
{
    public class Records
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public Patient Patient { get; set; }
        public User Doctor { get; set; }

        public DateTime AppointmentTime { get; set; }
    }
}
