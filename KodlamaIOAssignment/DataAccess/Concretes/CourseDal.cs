using KodlamaIOAssignment.DataAccess.Abstracts;
using KodlamaIOAssignment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOAssignment.DataAccess.Concretes;

public class CourseDal : ICourseDal
{
   List<Course> _courses;

    public CourseDal()
    {
        Course course1 = new Course();
        course1.Id = 1;
        course1.CourseName = ".Net";
        course1.CourseDescription = "Senior yazılım geliştirici yetiştirme kampı";

        Course course2 = new Course();
        course2.Id = 2;
        course2.CourseName = "Python & Selenium";
        course2.CourseDescription = "Yazılım geliştirici yetiştirme kampı";

        Course course3 = new Course();
        course3.Id = 3;
        course3.CourseName = "Javascript";
        course3.CourseDescription = "Yazılım geliştirici yetiştirme kampı";

        Course course4 = new Course();
        course4.Id = 4;
        course4.CourseName = "Java + React";
        course4.CourseDescription = "Yazılım geliştirici Yetiştirme Kampı";

        Course course5 = new Course();
        course5.Id = 5;
        course5.CourseName = "C# + Angular";
        course5.CourseDescription = "Yazılım geliştirici yetiştirme kampı";

        Course course6 = new Course();
        course6.Id = 6;
        course6.CourseName = "Java";
        course6.CourseDescription = "Yazılım geliştirme yetiştirme kampı";

        _courses = new List<Course> { course1, course2, course3, course4,course5, course6 };
    }


    public List<Course> GetAll()
    {
        return _courses;
    }

    public void Add(Course course)
    {
        _courses.Add(course);
    }

    public void Delete(int id)
    {
        Console.WriteLine("Kurs Silindi.");
    }

    public void Update(Course course)
    {
        Console.WriteLine("Kurs Güncellendi.");
    }


}
