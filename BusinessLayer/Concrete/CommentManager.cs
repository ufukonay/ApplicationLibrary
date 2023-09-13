using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using Database.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommetDal _CommentDal;

        public CommentManager(ICommetDal commentDal)
        {
            _CommentDal = commentDal;
        }

        public void CommentAdd(Comment comment)
        {
            _CommentDal.Insert(comment);
        }

        public List<Comment> GetList(int id)
        {
            return _CommentDal.GetListAll(x=> x.BlogID==id);
        }

       
    }
}
