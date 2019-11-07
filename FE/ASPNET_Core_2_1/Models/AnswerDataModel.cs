using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET_Core_2_1.Models
{
    public class AnswerDataModel
    {
        public string AnswerId { get; set; }
        public string Content { get; set; }
        public int UpvoteCount { get; set; }
        public int DownvoteCount { get; set; }
        public string CreatedUserID { get; set; }
        public string QuestionId { get; set; }
    }
}
