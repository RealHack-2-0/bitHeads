using Microsoft.EntityFrameworkCore;
using QuestionServer.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Models.Context
{
    public class APIContext : DbContext
    {

        public APIContext(DbContextOptions<APIContext> options) : base(options)
        {

        }

        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }



    }
}
