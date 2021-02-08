using AfetEkrani.DAL.EntityFramework;
using AfetEkrani.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfetEkrani.BLL
{
    public class BeldeBLL : IBaseService<Belde>
    {
        BeldeDAL<Belde> beldeDAL;

        public BeldeBLL()
        {
            beldeDAL = new BeldeDAL<Belde>();
        }
        public bool Add(Belde entity)
        {
            try
            {
                return beldeDAL.Add(entity) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Delete(Belde entity)
        {
            try
            {
                return beldeDAL.Delete(entity) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Belde> GetAll()
        {
            try
            {
                return beldeDAL.GetAll().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Belde GetById(int id)
        {
            try
            {
                return beldeDAL.Get(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Update(Belde entity)
        {
            try
            {
                return beldeDAL.Update(entity) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
