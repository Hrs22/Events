namespace Events.Data.Entities
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Type { get; set; }
        public List<Rating> Ratings{ get; set; }
        public double  AverageRating { get; set; }
        public string Address { get; set; }
        public string? Email { get; set; }
        public string? Website { get; set; }
        public int? PhoneNumber { get; set; }
        public string? SocialMedia { get; set; }
    }
}
