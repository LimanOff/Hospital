namespace Hospital.Models.Infrastucture
{
    public class ResultOfReferral
    {
        public int Id { get; set; }
        public int ReferralId { get; set; }
        public Referral Referral { get; set; }

        public string Results { get; set; }
    }
}
