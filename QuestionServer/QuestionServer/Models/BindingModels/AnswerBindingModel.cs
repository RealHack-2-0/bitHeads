using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionServer.Models.EntityModels
{
    public class AnswerBindingModel
    {

        [Required]
        public string Content { get; set; }
        public Guid CreatedUserID { get; set; }
        public Guid QuestionId { get; set; }

    }


}
