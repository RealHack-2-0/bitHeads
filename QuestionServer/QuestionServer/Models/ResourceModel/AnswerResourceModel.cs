using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionServer.Models.EntityModels
{
    public class AnswerResourceModel
    {
        public Guid AnswerId { get; set; }
        public string Content { get; set; }
        public int UpvoteCount { get; set; }
        public int DownvoteCount { get; set; }
        public Guid CreatedUserID { get; set; }
        public Guid QuestionId { get; set; }

    }


}
