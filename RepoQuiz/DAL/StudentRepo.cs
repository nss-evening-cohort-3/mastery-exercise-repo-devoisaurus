using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepoQuiz.DAL
{
    public class StudentRepo
    {
        //Get all students
        //Get individual student by ID
        //Get all majors
        //Get major by student ID

        private StudentContext Context { get; set; }

        public StudentRepo(StudentContext context)
        {
            Context = context;
        }

        public StudentRepo()
        {
            Context = new StudentContext();
        }

    }
}