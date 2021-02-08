using AfetEkrani.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfetEkrani.DAL.EntityFramework
{
    public class BeldeDAL<TEntity> : BaseDAL<TEntity>, IBaseDAL<TEntity>
         where TEntity : BaseEntity
    {
        AfetEkraniDBContext context;
        public BeldeDAL()
        {
            context = new AfetEkraniDBContext();
        }

        public Belde GetBelde(int id)
        {
            return context.Belde.SingleOrDefault(a => a.BeldeId == id);
        }
    }
}
