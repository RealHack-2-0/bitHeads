using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET_Core_2_1.Models
{
    public class QuestionDataModel
    {
        public Guid QuestionId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public Guid CreatedUserID { get; set; }
        public bool isAnswered { get; set; }

        public AnswerDataModel AcceptedAnswer { get; set; }

        public List<AnswerDataModel> Answers { get; set; }
        public int UpvoteCount { get; set; }
        public int DownvoteCount { get; set; }


    }
}
