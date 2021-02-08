using AfetEkrani.BLL;
using AfetEkrani.Model;
using AfetEkrani.UI.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AfetEkrani.UI.Controllers
{
    public class AfetEkraniController : Controller
    {
        AdresBLL _adresBLL;
        AfetTuruBLL _afetTuruBLL;
        IlBLL _ilBLL;
        IlceBLL _ilceBLL;
        MahalleBLL _mahalleBLL;
        BeldeBLL _beldeBLL;
        AfetBLL _afetBLL;
        public AfetEkraniController()
        {
            _adresBLL = new AdresBLL();
            _afetTuruBLL = new AfetTuruBLL();
            _ilBLL = new IlBLL();
            _ilceBLL = new IlceBLL();
            _mahalleBLL = new MahalleBLL();
            _beldeBLL = new BeldeBLL();
            _afetBLL = new AfetBLL();
        }
        public ActionResult Index()
        {

            List<Il> iller = new List<Il>();
            foreach (Il item in _ilBLL.GetAll())
            {
                iller.Add(item);
            }
            ViewBag.Il = new SelectList(iller, "IlId", "IlAdi");

            TumAfetTurleriGetir();
            OnayDurumlariGetir();
            AfetDetayAdresViewModel model = new AfetDetayAdresViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(AfetDetayAdresViewModel model, HttpPostedFileBase dosyaYolu)
        {
            List<Il> iller = new List<Il>();
            foreach (Il item in _ilBLL.GetAll())
            {
                iller.Add(item);
            }
            ViewBag.Il = new SelectList(iller, "IlId", "IlAdi");

            TumAfetTurleriGetir();
            OnayDurumlariGetir();

            string basePath = Server.MapPath("~\\App_Data\\uploads");
            if (!Directory.Exists(basePath))
                Directory.CreateDirectory(basePath);

            if (dosyaYolu.ContentLength > 0)
            {
                var dosyaAdi = Path.GetFileName(dosyaYolu.FileName);
                var path = Path.Combine(Server.MapPath("~/App_Data/uploads"), dosyaAdi);
                model.Afet.DosyaYolu = path;
                dosyaYolu.SaveAs(path);
            }

            string sure = _afetBLL.TarihlerArasindakiFark(model.Afet.BaslangicTarihi, model.Afet.BitisTarihi).ToString();
            model.Afet.Sure = sure;
            ViewBag.Sure = sure;
            model.Afet.AfetTuruId = model.AfetTuru.AfetTuruId;
            Adres adres = new Adres();
            adres.BeldeId = model.Belde.BeldeId;
            adres.IlId = model.Il.IlId;
            adres.IlceId = model.Ilce.IlceId;
            adres.MahalleId = model.Mahalle.MahalleId;
            try
            {
                _afetBLL.Add(model.Afet);
                _adresBLL.Add(adres);
                return RedirectToAction("KayitOlusturuldu");
            }
            catch (Exception ex)
            {
                ViewBag.Hata = ex.Message;
            }
            return View();
        }

        //Seçilen il id'sine göre ilçeleri getirme
        [HttpPost]
        public ActionResult IleGoreIlceGetir(int id)
        {
            List<Ilce> ilceler = new List<Ilce>();
            foreach (Ilce item in _ilceBLL.GetAll())
            {
                ilceler.Add(item);
            }
            List<Ilce> ilce = ilceler.Where(a => a.IlId == id).ToList();
            return Json(ilce, JsonRequestBehavior.AllowGet);
        }

        //Seçilen ilce id'sine göre mahalleleri getirme
        [HttpPost]
        public ActionResult IlceyeGoreMahalleGetir(int id)
        {
            List<Mahalle> mahalleler = new List<Mahalle>();
            foreach (Mahalle item in _mahalleBLL.GetAll())
            {
                mahalleler.Add(item);
            }
            List<Mahalle> mahalle = mahalleler.Where(a => a.IlceId == id).ToList();
            return Json(mahalle, JsonRequestBehavior.AllowGet);
        }

        //Seçilen ilce id'sine göre beldeleri getirme
        [HttpPost]
        public ActionResult IlceyeGoreBeldeGetir(int id)
        {
            List<Belde> beldeler = new List<Belde>();
            foreach (Belde item in _beldeBLL.GetAll())
            {
                beldeler.Add(item);
            }
            List<Belde> belde = beldeler.Where(a => a.IlceId == id).ToList();
            return Json(belde, JsonRequestBehavior.AllowGet);
        }

        //DropDown içerisine Afet Türü bilgileri getirilmiştir
        private void TumAfetTurleriGetir()
        {
            List<SelectListItem> tumAfetTurleri = new List<SelectListItem>();
            foreach (AfetTuru item in _afetTuruBLL.GetAll())
            {
                tumAfetTurleri.Add(new SelectListItem { Text = item.TurAdi, Value = item.AfetTuruId.ToString() });
            }
            ViewBag.AfetTurleri = tumAfetTurleri;
        }

        //Radio butonlara Onay Durum Bilgileri getirilmiştir.
        private void OnayDurumlariGetir()
        {
            string[] onayEnums = Enum.GetNames(typeof(OnayDurum));
            List<SelectListItem> onay = new List<SelectListItem>();
            foreach (string item in onayEnums)
            {
                onay.Add(new SelectListItem { Text = item, Value = item });
            }
            ViewBag.Onay = onayEnums;
        }

        public ActionResult KayitOlusturuldu()
        {
            return View();
        }




        //*************************************************************************

        //Tüm İlçe, Mahalle, Belde listelenmek istenirse dropdown içerisinde o zaman kullanılacaktır


        //private void TumIlceleriGetir()
        //{
        //    List<SelectListItem> tumIlceler = new List<SelectListItem>();
        //    foreach (Ilce item in _ilceBLL.GetAll())
        //    {
        //        tumIlceler.Add(new SelectListItem { Text = item.IlceAdi, Value = item.IlceId.ToString() });
        //    }
        //    ViewBag.Ilce = tumIlceler;
        //}

        //private void TumMahalleleriGetir()
        //{
        //    List<SelectListItem> tumMahalleler = new List<SelectListItem>();
        //    foreach (Mahalle item in _mahalleBLL.GetAll())
        //    {
        //        tumMahalleler.Add(new SelectListItem { Text = item.MahalleAdi, Value = item.MahalleId.ToString() });
        //    }
        //    ViewBag.Mahalle = tumMahalleler;
        //}

        //private void TumBeldeleriGetir()
        //{
        //    List<SelectListItem> tumBeldeler = new List<SelectListItem>();
        //    foreach (Belde item in _beldeBLL.GetAll())
        //    {
        //        tumBeldeler.Add(new SelectListItem { Text = item.BeldeAdi, Value = item.BeldeId.ToString() });
        //    }
        //    ViewBag.Belde = tumBeldeler;
        //}

        //********************************************************************


    }
}