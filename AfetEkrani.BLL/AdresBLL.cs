using AfetEkrani.DAL.EntityFramework;
using AfetEkrani.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfetEkrani.BLL
{
    public class AdresBLL : IBaseService<Adres>
    {
        AdresDAL<Adres> adresDAL;

        public AdresBLL()
        {
            adresDAL = new AdresDAL<Adres>();
        }

        public bool Add(Adres entity)
        {
            try
            {
                return adresDAL.Add(entity) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Delete(Adres entity)
        {
            try
            {
                return adresDAL.Delete(entity) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Adres> GetAll()
        {
            try
            {
                return adresDAL.GetAll().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Adres GetById(int id)
        {
            try
            {
                return adresDAL.Get(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Update(Adres entity)
        {
            try
            {
                return adresDAL.Update(entity) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
