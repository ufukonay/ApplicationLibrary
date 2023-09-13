using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Database.Abstract;
using Database.Concrete;

namespace Database.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        //silme işlemi 
        public void Delete(T t)
        {
            using var c = new Context();
            c.Remove(t);
            c.SaveChanges();
        }
        //Ide göre çağırma
        public T GetByID(int id)
        {
            using var c = new Context();
            return c.Set<T>().Find(id);
        }
        //bütün verileri çekme 
        public List<T> GetListAll()
        {
            using var c = new Context();
            return c.Set<T>().ToList();
        }
        //ekleme işlemi
        public void Insert(T t)
        {
            using var c = new Context();
            c.Add(t);
            c.SaveChanges();
        }

        public List<T>GetListAll(Expression<Func<T, bool>> filter)
        {
            using var c = new Context();
            return c.Set<T>().Where(filter).ToList();
        }
        //güncelleme
        public void Update(T t)
        {
            using var c = new Context();
            c.Update(t);
            c.SaveChanges();
        }
    }
}
