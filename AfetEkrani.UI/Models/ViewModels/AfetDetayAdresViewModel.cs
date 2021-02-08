using AfetEkrani.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AfetEkrani.UI.Models.ViewModels
{
    public class AfetDetayAdresViewModel
    {
        public Adres Adres { get; set; }
        public Afet Afet { get; set; }
        public AfetTuru AfetTuru { get; set; }
        public Il Il { get; set; }
        public Ilce Ilce { get; set; }
        public Mahalle Mahalle { get; set; }
        public Belde Belde { get; set; }

    }
}