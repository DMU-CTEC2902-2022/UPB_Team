using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment2.Models;


namespace Assignment2.Controllers
{
    public class CourseController : Controller
    {


        private List<Course> courses = new List<Course>()
       {

           new Course { CourseId = 1,
           CourseName = "Computer Science",
           CourseDescription = "Abc"

           },

           new Course { CourseId = 2,
           CourseName = "Software Engineering",
           CourseDescription = "Abc"

           },

           new Course { CourseId = 3,
           CourseName = "Cyber Security",
           CourseDescription = "Abc"

           }
       };
        public ActionResult Details(int? id)

        {

            if (id == null) return new HttpNotFoundResult();

            Course selectedCourse = courses.First(p => p.CourseId == id);



            if (selectedCourse == null) return new HttpNotFoundResult();

            return View(selectedCourse);

        }
        public ActionResult Index()

        {

            return View(courses);

        }
        // GET: Edit/id

        public ActionResult Edit(int? id)

        {

            if (id == null) return new HttpNotFoundResult();

            Course selectedCourse = courses.First(p => p.CourseId == id);

            if (selectedCourse == null) return new HttpNotFoundResult();

            return View(selectedCourse);

        }


    }



}