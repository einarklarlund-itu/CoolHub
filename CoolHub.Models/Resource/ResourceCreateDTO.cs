namespace CoolHub.Models
{
    public class ResourceCreateDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public int TopicId { get; set; }
    }
}