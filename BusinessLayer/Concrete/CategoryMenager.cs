 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using Database.Abstract;
using Database.EntityFramework;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CategoryMenager : ICategoryService
       
    {
        ICategory _categoryDal;
    

        public CategoryMenager(ICategory categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void CategoryAdd(Category category)
        {
            _categoryDal.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
           _categoryDal.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
          _categoryDal.Update(category);
        }

        public Category GetById(int id)
        {
            return _categoryDal.GetByID(id);
        }

        public List<Category> GetList()
        {
            return _categoryDal.GetListAll();
        }
    }
}
