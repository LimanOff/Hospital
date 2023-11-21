namespace Hospital.Models.Infrastucture
{
    public class Referral
    {
        public int Id { get; set; }
        public int PatientID { get; set; }
        public Patient Patient { get; set; }

        public int WhatDoctorId { get; set; }
        public User WhatDoctor { get; set; }
        public int FromDoctorId { get; set; }
        public User FromDoctor { get; set; } 

        public string NameOfMedExam { get; set; }
        public string NameOfTreatment { get; set; }
    }
}
