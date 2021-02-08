using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfetEkrani.Model
{
    public class Mahalle:BaseEntity
    {
        public Mahalle()
        {
            Adresler = new HashSet<Adres>();
        }
        public int MahalleId { get; set; }
        public string MahalleAdi { get; set; }
        public int IlceId { get; set; }

        //Navigation Prop
        public ICollection<Adres> Adresler { get; set; }
    }
}
