using AfetEkrani.DAL.EntityFramework;
using AfetEkrani.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfetEkrani.BLL
{
    public class AfetBLL:IBaseService<Afet>
    {
        AfetDAL<Afet> afetDAL;
        public AfetBLL()
        {
            afetDAL = new AfetDAL<Afet>();
        }

        public bool Add(Afet entity)
        {
            try
            {
                TarihKontrol(entity.BaslangicTarihi, entity.BitisTarihi);
                return afetDAL.Add(entity) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Delete(Afet entity)
        {
            try
            {
                return afetDAL.Delete(entity) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Afet> GetAll()
        {
            try
            {
                return afetDAL.GetAll().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Afet GetById(int id)
        {
            try
            {
                return afetDAL.Get(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Update(Afet entity)
        {
            try
            {
                return afetDAL.Update(entity) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void TarihKontrol(DateTime bas, DateTime bit)
        {
            if (bas>bit)
            {
                throw new Exception("Bitiş tarihi başlangıç tarihinden önce olamaz.");
            }
        }

        public TimeSpan TarihlerArasindakiFark(DateTime bas, DateTime bit)
        {
            try
            {
                return afetDAL.TarihlerArasindakiFark(bas, bit);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
