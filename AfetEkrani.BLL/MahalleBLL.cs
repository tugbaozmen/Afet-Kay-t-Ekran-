using AfetEkrani.DAL.EntityFramework;
using AfetEkrani.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfetEkrani.BLL
{
    public class MahalleBLL:IBaseService<Mahalle>
    {

        MahalleDAL<Mahalle> mahalleDAL;

        public MahalleBLL()
        {
            mahalleDAL = new MahalleDAL<Mahalle>();
        }

        public bool Add(Mahalle entity)
        {
            try
            {
                return mahalleDAL.Add(entity) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Delete(Mahalle entity)
        {
            try
            {
                return mahalleDAL.Delete(entity) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Mahalle> GetAll()
        {
            try
            {
                return mahalleDAL.GetAll().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Mahalle GetById(int id)
        {
            try
            {
                return mahalleDAL.Get(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Update(Mahalle entity)
        {
            try
            {
                return mahalleDAL.Update(entity) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
