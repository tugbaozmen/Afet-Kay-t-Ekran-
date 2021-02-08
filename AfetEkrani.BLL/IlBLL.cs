using AfetEkrani.DAL.EntityFramework;
using AfetEkrani.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfetEkrani.BLL
{
    public class IlBLL:IBaseService<Il>
    {
        IlDAL<Il> ilDAL;

        public IlBLL()
        {
            ilDAL = new IlDAL<Il>();
        }

        public bool Add(Il entity)
        {
            try
            {
                return ilDAL.Add(entity) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Delete(Il entity)
        {
            try
            {
                return ilDAL.Delete(entity) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Il> GetAll()
        {
            try
            {
                return ilDAL.GetAll().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Il GetById(int id)
        {
            try
            {
                return ilDAL.Get(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Update(Il entity)
        {
            try
            {
                return ilDAL.Update(entity) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
