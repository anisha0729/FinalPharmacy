namespace FinalPharmacy.Models.Customer
{
    public class MedicalHistory
    {
        public Guid MedicalHistoryId { get; set; }

        // Foreign key to link with Customer
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }

        public string Condition { get; set; }
        public DateTime DiagnosisDate { get; set; }
    }
}
