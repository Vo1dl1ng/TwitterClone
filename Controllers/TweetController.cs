using Microsoft.AspNetCore.Mvc;
using TwitterClone.Data;
using TwitterClone.Models;

namespace TwitterClone.Controllers
{
    [Route("api/TweetController")]
    [Controller]
    public class TweetController : ControllerBase
    {
        // localhost:5000/api/getalltweets

        private readonly TweetRepository _rep;

        public TweetController()
        {
            _rep = new TweetRepository();
        }

        //make something to add likes

        [HttpGet]
        public List<Tweet> GetAllTweets()
        {
            return _rep.GetAllTweets();
        }

        [HttpGet]
        [Route("{id}")]
        public string GetTweetById(int id)
        {
            return $"this is the {id}";
        }

        [HttpPost]
        public void CreateTweet([FromBody]Tweet tweet)
        {
            if (ModelState.IsValid)
            {
                _rep.CreateTweet(tweet);
            }
        }

        [HttpPut]
        [Route("{id}")]
        //möguleg villa, ef svo ,athuga 08 - http put mynband, mínúta 22:50 (eitthvað cycle/loop dótterí)
        public IActionResult UpdateTweet(int id,[FromBody] Tweet tweet)
        {

            try
            {
                Tweet updatedTweet = _rep.UpdateTweet(id, tweet);

                if(updatedTweet == null)
                {
                    return NotFound();
                }
                else
                {
                    return CreatedAtAction(nameof(UpdateTweet), new { id = updatedTweet.Id }, updatedTweet);
                }
            }
            catch (Exception)
            {
                return StatusCode(500);
            }


        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult<Tweet> DeleteTweet(int id)
        {

            try
            {
                bool deleteSuccesfull = _rep.DeleteTweet(id);


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
