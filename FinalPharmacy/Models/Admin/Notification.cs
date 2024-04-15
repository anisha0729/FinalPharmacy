namespace FinalPharmacy.Models.Admin
{
    public class Notification
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsRead { get; set; }

        // Constructor
        public Notification()
        {
            CreatedAt = DateTime.Now;
            IsRead = false; // By default, notifications are unread
        }
    }
}
