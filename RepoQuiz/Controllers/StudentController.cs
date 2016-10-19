using RepoQuiz.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RepoQuiz.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            StudentRepo student_repo = new StudentRepo();
            ViewBag.Students = student_repo.GetAllStudents();
            return View();
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            StudentRepo student_repo = new StudentRepo();
            ViewBag.Students = student_repo.GetStudentById(id);
            return View();
        }

    }
}
