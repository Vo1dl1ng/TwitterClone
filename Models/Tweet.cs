namespace TwitterClone.Models
{
    public class Tweet
    {

        public int Id { get; set; }
        public int UserId { get; set; }
        public string Message { get; set; }
        public int Likes { get; set; }
        public int Shares { get; set; }
        public DateTime PostedTime { get; set; }
        public List<Tweet> Comments { get; set; }

    }
}
