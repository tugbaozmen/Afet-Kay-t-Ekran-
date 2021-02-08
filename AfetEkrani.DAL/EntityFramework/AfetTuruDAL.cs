using AfetEkrani.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfetEkrani.DAL.EntityFramework
{
   public class AfetTuruDAL<TEntity> : BaseDAL<TEntity>, IBaseDAL<TEntity>
         where TEntity : BaseEntity
    {
        AfetEkraniDBContext context;
        public AfetTuruDAL()
        {
            context = new AfetEkraniDBContext();
        }

        public AfetTuru GetAfetTuru(int id)
        {
            return context.AfetTuru.SingleOrDefault(a => a.AfetTuruId == id);
        }
    }
}
