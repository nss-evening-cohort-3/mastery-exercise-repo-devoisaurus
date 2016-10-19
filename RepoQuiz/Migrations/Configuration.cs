namespace RepoQuiz.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RepoQuiz.DAL.StudentContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RepoQuiz.DAL.StudentContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Students.AddOrUpdate(
                s => s.FirstName,
                new Student { FirstName = "Rosalyn", LastName = "Davies", Major = "Chemistry" },
                new Student { FirstName = "Pamela", LastName = "Banks", Major = "Psychology" },
                new Student { FirstName = "Timothy", LastName = "Rigby", Major = "Microbiology" },
                new Student { FirstName = "Crispin", LastName = "Linwood", Major = "Drama" },
                new Student { FirstName = "Keri", LastName = "Mathers", Major = "Art History" },
                new Student { FirstName = "Tanya", LastName = "Poole", Major = "Pre-law" },
                new Student { FirstName = "Dunston", LastName = "Roberts", Major = "Anthropology" },
                new Student { FirstName = "Renee", LastName = "Fairchild", Major = "Forensic Science" },
                new Student { FirstName = "Lucas", LastName = "Wilkinson", Major = "History" },
                new Student { FirstName = "Corrine", LastName = "Hunter", Major = "Philosophy" }
                );
        }
    }
}
