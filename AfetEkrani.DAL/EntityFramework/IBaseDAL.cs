using AfetEkrani.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfetEkrani.DAL.EntityFramework
{
    interface IBaseDAL<TEntity>
      where TEntity : BaseEntity
    {
            int Add(TEntity entity);
            int Update(TEntity entity);
            int Delete(TEntity entity);
            TEntity Get(int id);
            ICollection<TEntity> GetAll();
    }
}
