using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionServer.Models.EntityModels
{
    public class Answer
    {
        public Answer()
        {
            AnswerId = Guid.NewGuid();
        }

        [Key]
        public Guid AnswerId { get; set; }
        [Required]
        public string Content { get; set; }
        public int UpvoteCount { get; set; }
        public int DownvoteCount { get; set; }
        [Required]
        public Guid CreatedUserID { get; set; }
        public Guid QuestionId { get; set; }

    }


}
