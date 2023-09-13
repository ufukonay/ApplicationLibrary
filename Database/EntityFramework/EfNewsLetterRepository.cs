using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Abstract;
using Database.Repositories;
using EntityLayer.Concrete;

namespace Database.EntityFramework
{
    public class EfNewsLetterRepository : GenericRepository<NewsLetter>,INewsLetterDal
    { 
    
    }
    
}
