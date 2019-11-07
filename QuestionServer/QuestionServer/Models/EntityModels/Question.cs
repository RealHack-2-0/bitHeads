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
    public class Question
    {
        public Question()
        {
            QuestionId = Guid.NewGuid();
        }

        [Key]
        public Guid QuestionId { get; set; }

        [Required, StringLength(100)]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public Guid CreatedUserID { get; set; }

        public Boolean isAnswered { get; set; }

        public Guid AcceptedAnswerId { get; set; }
        [ForeignKey("AnswerId")]
        public Answer AcceptedAnswer { get; set; }
        [JsonIgnore]
        public List<Answer> Answers { get; set; }
        public int UpvoteCount { get; set; }
        public int DownvoteCount { get; set; }


    }
}
