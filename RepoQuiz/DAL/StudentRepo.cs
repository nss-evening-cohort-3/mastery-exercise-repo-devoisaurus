using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RepoQuiz.Models;

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

        public List<Student> GetAllStudents()
        {
            List<Student> StudentList = Context.Students.ToList();
            return StudentList;
        }

        public Student GetStudentById(int Id)
        {
            var student = Context.Students.FirstOrDefault(S => S.StudentID == Id);
            return student;
        }
    }
}