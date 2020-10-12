namespace MVCSkillsAssessment_CodeFirst.Migrations
{
    using MVCSkillsAssessment_CodeFirst.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVCSkillsAssessment_CodeFirst.Models.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MVCSkillsAssessment_CodeFirst.Models.DataContext context)
        {
          //Seed The Database with Dummy Data 

            context.users.AddOrUpdate(p=>p.UserID,
                new User
                {
                    Name = "Bradley",
                    Surname = "Van Zyl",
                    Email = "bradleyvanzyl2@gmail.com",
                    Password = "Abcd@1234",
                    ConfirmPassword = "Abcd@1234",
                    Country="South Africa",
                    FavouriteColour = "Red",
                    Birthday = "1996/01/22",
                    Cellphone = "0793767813",
                    Comments = "Comment From Seed."
                });
        }
    }
}
