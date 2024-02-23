using KodlamaIOAssignment.DataAccess.Abstracts;
using KodlamaIOAssignment.DataAccess.Concretes;
using KodlamaIOAssignment.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOAssignment.Business;

public class CategoryManager : ICategoryDal
{
    private readonly ICategoryDal _categoryDal;

    public CategoryManager(CategoryDal _categoryDal)
    {
        _categoryDal = _categoryDal;
    }

    public void Add(Category category)
    {
        _categoryDal.Add(category);
    }

    public void Delete(int id)
    {
        _categoryDal.Delete(id);
    }

    public void Update(Category category)
    {
        _categoryDal.Update(category);
    }

    public List<Category> GetAll()
    {
        return _categoryDal.GetAll();
    }

}
