﻿using KodlamaIOAssignment.DataAccess.Abstracts;

using KodlamaIOAssignment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOAssignment.Business;

public class InstructorManager :IInstructorDal
{
   private readonly IInstructorDal _instructorDal;

    public InstructorManager(IInstructorDal instructorDal)
    {
        _instructorDal = instructorDal;
    }

    public void Add(Instructor instructor)
    {
        _instructorDal.Add(instructor);
    }

    public void Delete(Instructor instructor)
    {
        _instructorDal.Delete(instructor);
    }

    public List<Instructor> GetAll()
    {
        return _instructorDal.GetAll();
    }

    public void Update(Instructor instructor)
    {
        _instructorDal.Add(instructor);
    }
}
