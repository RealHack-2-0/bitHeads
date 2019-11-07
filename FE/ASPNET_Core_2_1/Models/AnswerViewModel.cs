using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET_Core_2_1.Models
{
    public class AnswerViewModel
    {
        public string Content { get; set; }
        public string CreatedUserID { get; set; }
        public string QuestionId { get; set; }
    }
}
