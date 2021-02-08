using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfetEkrani.Model
{
    public class Ilce:BaseEntity
    {
        public Ilce()
        {
            Adresler = new HashSet<Adres>();
        }
        public int IlceId { get; set; }
        public string IlceAdi { get; set; }
        public int IlId { get; set; }

        //Navigation Prop
        public ICollection<Adres> Adresler { get; set; }
    }
}
