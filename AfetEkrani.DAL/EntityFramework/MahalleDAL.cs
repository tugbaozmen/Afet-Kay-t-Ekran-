using AfetEkrani.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfetEkrani.DAL.EntityFramework
{
    public class MahalleDAL<TEntity> : BaseDAL<TEntity>, IBaseDAL<TEntity>
         where TEntity : BaseEntity
    {
        AfetEkraniDBContext context;
        public MahalleDAL()
        {
            context = new AfetEkraniDBContext();
        }

        public Mahalle GetMahalle(int id)
        {
            return context.Mahalle.SingleOrDefault(a => a.MahalleId == id);
        }
    }
}
