using AfetEkrani.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfetEkrani.DAL.EntityFramework
{
    public class IlceDAL<TEntity> : BaseDAL<TEntity>, IBaseDAL<TEntity>
         where TEntity : BaseEntity
    {
        AfetEkraniDBContext context;
        public IlceDAL()
        {
            context = new AfetEkraniDBContext();
        }

        public Ilce GetIlce(int id)
        {
            return context.Ilce.SingleOrDefault(a => a.IlceId == id);
        }

        //public List<Ilce> IleGoreIlceGetir(int id)
        //{
        //    return context.Ilce.Where(a => a.IlId == id).ToList();


        //}
    }
}
