using Microsoft.AspNetCore.Mvc;
using TwitterClone.Data;
using TwitterClone.Models;

namespace TwitterClone.Controllers
{
    public class UserController
    {

        [Route("api/UserController")]
        [Controller]
        public class TweetController : ControllerBase
        {
            // localhost:5000/api/getalltweets

            private readonly UserRepository _rep;

            public TweetController()
            {
                _rep = new UserRepository();
            }

            //make something to add likes

            [HttpGet]
            public List<User> GetAllUsers()
            {
                return _rep.GetAllUsers();
            }

            [HttpGet]
            [Route("{id}")]
            public string GetUserById(int id)
            {
                return $"this is the {id}";
            }

            [HttpPost]
            public void CreateTweet([FromBody] User user)
            {
                if (ModelState.IsValid)
                {
                    _rep.CreateUser(user);
                }
            }

            [HttpPut]
            [Route("{id}")]
            //möguleg villa, ef svo ,athuga 08 - http put mynband, mínúta 22:50 (eitthvað cycle/loop dótterí)
            public IActionResult UpdateTweet(int id, [FromBody] User user)
            {

                try
                {
                    User updatedUser = _rep.UpdateUser(id, user);

                    if (updatedUser == null)
                    {
                        return NotFound();
                    }
                    else
                    {
                        return CreatedAtAction(nameof(UpdateTweet), new { id = updatedUser.Id }, updatedUser);
                    }
                }
                catch (Exception)
                {
                    return StatusCode(500);
                }


            }

            [HttpDelete]
            [Route("{id}")]
            public ActionResult<User> DeleteUser(int id)
            {

                try
                {
                    bool deleteSuccesfull = _rep.DeleteUser(id);


                    if (!deleteSuccesfull)
                    {
                        return NotFound();
                    }
                    else
                    {
                        return NoContent();
                    }
                }
                catch (Exception)
                {
                    return StatusCode(500);
                }




            }

        }

    }
}
