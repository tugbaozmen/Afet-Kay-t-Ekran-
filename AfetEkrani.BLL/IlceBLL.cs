using AfetEkrani.DAL.EntityFramework;
using AfetEkrani.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfetEkrani.BLL
{
    public class IlceBLL:IBaseService<Ilce>
    {
        IlceDAL<Ilce> ilceDAL;

        public IlceBLL()
        {
            ilceDAL = new IlceDAL<Ilce>();
        }

        public bool Add(Ilce entity)
        {
            try
            {
                return ilceDAL.Add(entity) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Delete(Ilce entity)
        {
            try
            {
                return ilceDAL.Delete(entity) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Ilce> GetAll()
        {
            try
            {
                return ilceDAL.GetAll().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Ilce GetById(int id)
        {
            try
            {
                return ilceDAL.Get(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Update(Ilce entity)
        {
            try
            {
                return ilceDAL.Update(entity) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public List<Ilce> IleGoreIlceGetir(int id)
        //{
        //    try
        //    {
        //        return ilceDAL.IleGoreIlceGetir(id);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
    }
}
