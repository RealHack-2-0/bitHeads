using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionServer.Models.EntityModels
{
    public class QuestionResourceModel
    {

        public Guid QuestionId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public Guid CreatedUserID { get; set; }
        public Boolean isAnswered { get; set; }

        public AnswerResourceModel AcceptedAnswer { get; set; }

        public List<AnswerResourceModel> Answers { get; set; }
        public int UpvoteCount { get; set; }
        public int DownvoteCount { get; set; }


    }
}
