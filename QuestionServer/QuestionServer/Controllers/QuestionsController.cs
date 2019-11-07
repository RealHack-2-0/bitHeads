using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductAPI.Models.Context;
using QuestionServer.Models.EntityModels;

namespace QuestionServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        private readonly APIContext _context;

        public QuestionsController(APIContext context)
        {
            _context = context;
        }

        // GET: api/Questions
        [HttpGet]
        public async Task<ActionResult<QuestionResourceModel>> GetQuestions()
        {
            var allQuestions =  await _context.Questions.ToListAsync();
            List<QuestionResourceModel> questionlist = new List<QuestionResourceModel>();
            foreach (var question in allQuestions)
            {
                var thisquestion = new QuestionResourceModel { QuestionId = question.QuestionId, Title = question.Title, Content = question.Content, UpvoteCount =question.UpvoteCount, DownvoteCount =question.DownvoteCount, Tag =question.Tag };
                questionlist.Add(thisquestion);
            }
            return Ok(new { data =  questionlist});
        }

        // GET: api/Questions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<QuestionResourceModel>> GetQuestion(Guid id)
        {
            var question = await _context.Questions.FindAsync(id);
            var answers = await _context.Answers.Where(f => f.QuestionId == id).ToListAsync();
            AnswerResourceModel AcceptedAnswer = null;
            if (question.isAnswered) {
                var bestanswer = _context.Answers.Where(f => f.AnswerId == question.AcceptedAnswerId).FirstOrDefault();
                AcceptedAnswer = new AnswerResourceModel { AnswerId = bestanswer.AnswerId, Content = bestanswer.Content };
            }

            List<AnswerResourceModel> answerlist = new List<AnswerResourceModel>();
            foreach (var ans in answers) {
                var thisanswer = new AnswerResourceModel { AnswerId = ans.AnswerId, Content = ans.Content };
                answerlist.Add(thisanswer);
            }
            

            if (question == null)
            {
                return NotFound();
            }

            var return_question = new QuestionResourceModel
            {
                QuestionId = question.QuestionId,
                Title = question.Title,
                Content =question.Content,
                CreatedUserID =question.CreatedUserID,
                isAnswered = question.isAnswered,
                AcceptedAnswer = AcceptedAnswer,
                Answers = answerlist,
                UpvoteCount =question.UpvoteCount,
                DownvoteCount =question.DownvoteCount,
                Tag = question.Tag
            }; 

            return return_question;
        }

        // PUT: api/Questions/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutQuestion(Guid id, QuestionBindingModel updated_question)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var question = await _context.Questions.FindAsync(id);

            if (question == null)
            {
                return NotFound();
            }

            question.Title = updated_question.Title;
            question.Content = updated_question.Content;

            _context.Entry(question).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QuestionExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Questions
        [HttpPost]
        public async Task<ActionResult<Question>> PostQuestion(QuestionBindingModel question)
        {
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

        // DELETE: api/Questions/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Question>> DeleteQuestion(Guid id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var question = await _context.Questions.FindAsync(id);
            if (question == null)
            {
                return NotFound();
            }

            _context.Questions.Remove(question);
            await _context.SaveChangesAsync();

            return question;
        }

        private bool QuestionExists(Guid id)
        {
            return _context.Questions.Any(e => e.QuestionId == id);
        }

        [HttpGet("acceptanswer")]
        public async Task<IActionResult> AcceptAnswer(Guid questionId, Guid answerId)
        {
            if (questionId == null || answerId==null)
            {
                return BadRequest();
            }

            var question = await _context.Questions.FindAsync(questionId);
            var answer = await _context.Answers.FindAsync(answerId);

            if (question == null || answer == null)
            {
                return NotFound();
            }

            question.isAnswered = true;
            question.AcceptedAnswerId = answerId;
            _context.Entry(question).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QuestionExists(questionId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpGet("upvote")]
        public async Task<IActionResult> Upvote(Guid id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var question = await _context.Questions.FindAsync(id);

            if (question == null)
            {
                return NotFound();
            }

            question.UpvoteCount = question.UpvoteCount + 1;
            _context.Entry(question).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QuestionExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok();
        }

        [HttpGet("downvote")]
        public async Task<IActionResult> Downvote(Guid id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var question = await _context.Questions.FindAsync(id);

            if (question == null)
            {
                return NotFound();
            }

            question.DownvoteCount = question.DownvoteCount + 1;
            _context.Entry(question).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QuestionExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok();
        }

        [HttpGet("public")]
        public ActionResult<QuestionResourceModel> Get(String token, String tags)
        {
            if (token == null)
            {
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
