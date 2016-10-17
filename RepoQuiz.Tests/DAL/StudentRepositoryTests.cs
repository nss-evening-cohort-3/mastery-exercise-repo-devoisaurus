using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RepoQuiz.DAL;
using RepoQuiz.Models;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;

namespace RepoQuiz.Tests.DAL
{
    [TestClass]
    public class StudentRepositoryTests
    {
        Mock<StudentContext> student_context;
        Mock<DbSet<Student>> student_table;
        private List<Student> students;
        private Student student1;
        private Student student2;

        [TestInitialize]
        public void Intialize()
        {
            student_context = new Mock<StudentContext>();
            student_table = new Mock<DbSet<Student>>();
            student1 = new Student
            {
                FirstName = "Mary",
                LastName = "Sue",
                Major = "Physics"
            };

            student2 = new Student
            {
                FirstName = "Joey",
                LastName = "Jones",
                Major = "Gym"
            };
            students = new List<Student> { student1, student2 };
            student_context.Setup(x => x.Students).Returns(student_table.Object);

            ConnectMocksToDatabase();
        }

        public void ConnectMocksToDatabase()
        {
            var queryable_list = students.AsQueryable();

            student_table.As<IQueryable<Student>>().Setup(a => a.Provider).Returns(queryable_list.Provider);
            student_table.As<IQueryable<Student>>().Setup(a => a.Expression).Returns(queryable_list.Expression);
            student_table.As<IQueryable<Student>>().Setup(a => a.ElementType).Returns(queryable_list.ElementType);
            student_table.As<IQueryable<Student>>().Setup(a => a.GetEnumerator()).Returns(queryable_list.GetEnumerator());
        }

        [TestCleanup]
        public void Cleanup()
        {
            student_context = null;
            student_table = null;
            students = null;
        }
    }
}
