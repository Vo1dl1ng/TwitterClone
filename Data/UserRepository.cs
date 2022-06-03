using TwitterClone.Models;

namespace TwitterClone.Data
{
    public class UserRepository
    {

        private readonly TweetDbContext _udb;

        public UserRepository()
        {
            _udb = new TweetDbContext();
        }

        public List<User> GetAllUsers()
        {
            return _udb.Users.ToList();
        }

        public void CreateUser(User user)
        {
            using (var db = _udb)
            {
                db.Users.Add(user);
                db.SaveChanges();
            }
        }

        public User UpdateUser(int id, User user)
        {
            User userToUpdate;

            using (var db = _udb)
            {
                userToUpdate = db.Users.FirstOrDefault(x => x.Id == id);

                if (userToUpdate == null)
                {
                    return null;
                }

                userToUpdate.Id = id;
                userToUpdate.UserName = user.UserName;
                userToUpdate.TwitterHandle = user.TwitterHandle;
                userToUpdate.ImageURL = user.ImageURL;

                db.SaveChanges();

                return userToUpdate;

            }
        }

        public bool DeleteUser(int id)
        {
            User userToDelete;

            using (var db = _udb)
            {
                userToDelete = db.Users.FirstOrDefault(x => x.Id == id);

                if (userToDelete == null)
                {
                    // false = delete failure
                    return false;
                }
                else
                {
                    db.Users.Remove(userToDelete);
                    db.SaveChanges();
                    return true;
                }
            }
        }

    }
}
