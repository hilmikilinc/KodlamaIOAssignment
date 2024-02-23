using KodlamaIOAssignment.DataAccess.Abstracts;
using KodlamaIOAssignment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOAssignment.DataAccess.Concretes
{
    public class InstructorDal : IInstructorDal
    {
        List<Instructor> _instructors;
        public InstructorDal()
        {
            Instructor instructor = new Instructor();
            instructor.Id = 1;
            instructor.FirstName = "Engin";
            instructor.LastName = "Demiroğ";

            Instructor ınstructor = new Instructor();
            instructor.Id = 2;
            instructor.FirstName = "Halit Enes";
            instructor.LastName = "Kalaycı";
         

            _instructors = new List<Instructor> { instructor };

        }

        public void Add(Instructor instructor)
        {
            _instructors.Add(instructor);
        }

        public void Delete(Instructor instructor)
        {
            Console.WriteLine("Eğitmen silindi.");
        }

        public List<Instructor> GetAll()
        {
            return _instructors;
        }

        public void Update(Instructor instructor)
        {
            Console.WriteLine("Eğitmen güncellendi.");
        }
    }
}
