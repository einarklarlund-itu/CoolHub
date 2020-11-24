namespace CoolHub.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public User User { get; set; }
        public Resource Resource { get; set; } 
    }
}