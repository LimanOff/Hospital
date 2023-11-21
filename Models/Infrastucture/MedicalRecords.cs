namespace Hospital.Models.Infrastucture
{
    public class MedicalRecords
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
        public string MedicalHistory { get; set; } // Анамнез болезни
        public string TestResults { get; set; } // Результаты обследований
        public string Diagnoses { get; set; }
        public string Recommendations { get; set; }
        public string Medications { get; set; }
    }
}
