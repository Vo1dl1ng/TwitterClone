using TwitterClone.Models;

namespace TwitterClone.Data
{
    public class TweetRepository
    {

        private readonly TweetDbContext _db;

        public TweetRepository()
        {
            _db = new TweetDbContext();
        }

        public List<Tweet> GetAllTweets()
        {
            return _db.Tweets.ToList();
        }

        public void CreateTweet(Tweet tweet)
        {
            using (var db = _db)
            {
                db.Tweets.Add(tweet);
                db.SaveChanges();
            }
        }

        public Tweet UpdateTweet(int id, Tweet tweet)
        {
            Tweet tweetToUpdate;

            using (var db = _db)
            {
                tweetToUpdate = db.Tweets.FirstOrDefault(x => x.Id == id);
            
                if(tweetToUpdate == null)
                {
                    return null;
                }

                tweetToUpdate.Comments = tweet.Comments;
                tweetToUpdate.Message = tweet.Message;
                tweetToUpdate.Shares = tweet.Shares;
                tweetToUpdate.Likes = tweet.Likes;
                tweetToUpdate.UserId = tweet.UserId;

                db.SaveChanges();

                return tweetToUpdate;

            }
        }

        public bool DeleteTweet(int id)
        {
            Tweet tweetToDelete;

            using (var db = _db)
            {
                tweetToDelete = db.Tweets.FirstOrDefault(x => x.Id == id);

                if(tweetToDelete == null)
                {
                    // false = delete failure
                    return false;
                }
                else
                {
                    db.Tweets.Remove(tweetToDelete);
                    db.SaveChanges();
                    return true;
                }
            }
        }

    }
}
