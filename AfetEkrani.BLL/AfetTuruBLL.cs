using AfetEkrani.DAL.EntityFramework;
using AfetEkrani.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfetEkrani.BLL
{
    public class AfetTuruBLL : IBaseService<AfetTuru>
    {
        AfetTuruDAL<AfetTuru> turuDAL;
        public AfetTuruBLL()
        {
            turuDAL = new AfetTuruDAL<AfetTuru>();
        }
        public bool Add(AfetTuru entity)
        {
            try
            {
                return turuDAL.Add(entity) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Delete(AfetTuru entity)
        {
            try
            {
                return turuDAL.Delete(entity) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<AfetTuru> GetAll()
        {
            try
            {
                return turuDAL.GetAll().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public AfetTuru GetById(int id)
        {
            try
            {
                return turuDAL.Get(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Update(AfetTuru entity)
        {
            try
            {
                return turuDAL.Update(entity) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
