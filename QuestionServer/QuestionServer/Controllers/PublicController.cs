using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductAPI.Models.Context;
using QuestionServer.Models.EntityModels;

namespace QuestionServer.Controllers
{
    
    public class PublicController : Controller

    {
        private readonly APIContext _context;
        public PublicController(APIContext context)
        {
            _context = context;
        }
        // GET api/values


        [HttpGet("public")]
        public ActionResult<QuestionResourceModel> Get(String token,String tags)
        {
            if (token == null) {
                return Unauthorized();
              
            }
            List<String> Tags_ = tags.Split(",").ToList();
            List<QuestionResourceModel> questionlist = new List<QuestionResourceModel>();
            var questions = _context.Questions.Where(i => Tags_.Contains(i.Tag)).ToList();
            foreach (var question in questions)
            {
                var thisquestion = new QuestionResourceModel { QuestionId = question.QuestionId, Title = question.Title, Content = question.Content, UpvoteCount = question.UpvoteCount, DownvoteCount = question.DownvoteCount, Tag = question.Tag };
                questionlist.Add(thisquestion);
            }
            return Ok(new { data = questionlist });
        }



        // POST: api/
        [HttpPost("public")]
        public async Task<ActionResult<Question>> PostQuestion(String token, QuestionBindingModel question)
        {
            if (token == null)
            {
                return Unauthorized();
            }

            Question newquestion = new Question
            {
                Title = question.Title,
                Content = question.Content,
                CreatedUserID = question.CreatedUserID,
                Tag = question.Tag
            };

            _context.Questions.Add(newquestion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetQuestion", new { id = newquestion.QuestionId }, question);
        }
    }
}