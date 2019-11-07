using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET_Core_2_1.Models
{
    public class QuestionDetailandAndQuestion
    {
        public QuestionResponse QuestionList { get; set; }
        public String Title { get; set; }
        public String Content { get; set; }

        public String Tag { get; set; }

    }
}
