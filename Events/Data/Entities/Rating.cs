namespace Events.Data.Entities
{
    public class Rating
    {
        public DateTime DateCreated { get; set; }
        public int Id { get; set; }
        public int UserId { get; set; }
        public int Grade { get; set; }
        public int EventId { get; set; }
    }
}
