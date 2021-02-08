using AfetEkrani.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfetEkrani.DAL.EntityFramework
{
    public class IlDAL<TEntity> : BaseDAL<TEntity>, IBaseDAL<TEntity>
         where TEntity : BaseEntity
    {
        AfetEkraniDBContext context;
        public IlDAL()
        {
            context = new AfetEkraniDBContext();
        }

        public Il GetIl(int id)
        {
            return context.Il.SingleOrDefault(a => a.IlId == id);
        }

    }
}
