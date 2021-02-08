using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfetEkrani.Model
{
    public class Il:BaseEntity
    {
        public Il()
        {
            Adresler = new HashSet<Adres>();
        }
        public int IlId { get; set; }
        public string IlAdi { get; set; }

        //Navigation Prop
        public ICollection<Adres> Adresler { get; set; }
    }
}
