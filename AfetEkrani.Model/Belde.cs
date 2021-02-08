using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfetEkrani.Model
{
    public class Belde : BaseEntity
    {
        public Belde()
        {
            Adresler = new HashSet<Adres>();
        }
        public int BeldeId { get; set; }
        public string BeldeAdi { get; set; }
        public int IlceId { get; set; }

        //Navigation Prop
        public ICollection<Adres> Adresler { get; set; }
    }
}
