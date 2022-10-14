namespace Events.Data.Entities
{
    public class User
    {
        public DateTime DateJoined { get; set; }
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Grade { get; set; }
        public string City { get; set; }
    }
}
