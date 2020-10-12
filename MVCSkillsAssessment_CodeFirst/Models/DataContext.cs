using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCSkillsAssessment_CodeFirst.Models
{
    public class DataContext:DbContext
    {
        public DataContext() : base("name=DataContext") { }
           
        public DbSet<User> users { get; set; }

        }
    }
