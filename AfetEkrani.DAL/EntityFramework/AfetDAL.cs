using AfetEkrani.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfetEkrani.DAL.EntityFramework
{
   public class AfetDAL<TEntity> : BaseDAL<TEntity>, IBaseDAL<TEntity>
         where TEntity : BaseEntity
    {
        AfetEkraniDBContext context;
        public AfetDAL()
        {
            context = new AfetEkraniDBContext();
        }

        public Afet GetAfet(int id)
        {
            return context.Afet.SingleOrDefault(a => a.AfetId == id);
        }

        public TimeSpan TarihlerArasindakiFark(DateTime bas, DateTime bit)
        {
            TimeSpan ts = (Convert.ToDateTime(bas) - Convert.ToDateTime(bit));
            return ts;
        }

    }
}
