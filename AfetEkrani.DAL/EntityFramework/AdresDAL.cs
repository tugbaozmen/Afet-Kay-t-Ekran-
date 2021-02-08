using AfetEkrani.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfetEkrani.DAL.EntityFramework
{
    public class AdresDAL<TEntity> : BaseDAL<TEntity>, IBaseDAL<TEntity>
         where TEntity : BaseEntity
    {
        AfetEkraniDBContext context;
        public AdresDAL()
        {
            context = new AfetEkraniDBContext();
        }

        public Adres GetAdres(int id)
        {
            return context.Adres.SingleOrDefault(a => a.AdresId == id);
        }

    }
}
