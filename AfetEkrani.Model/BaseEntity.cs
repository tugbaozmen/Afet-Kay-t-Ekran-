using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfetEkrani.Model
{
   public class BaseEntity
    {
        public BaseEntity()
        {
            AktifMi = true;
            OlusturulmaTarihi = DateTime.Now;
        }
        public bool AktifMi { get; set; }
        public DateTime OlusturulmaTarihi { get; set; }
    }
}
