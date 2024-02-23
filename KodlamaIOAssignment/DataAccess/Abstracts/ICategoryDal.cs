using KodlamaIOAssignment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOAssignment.DataAccess.Abstracts;

public interface ICategoryDal
{
    List<Category> GetAll();

    void Add(Category categorty);

    void Delete(int id);

    void Update(Category category);

}
