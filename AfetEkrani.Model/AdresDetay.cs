using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfetEkrani.Model
{
    public class AdresDetay:BaseEntity
    {
        public int AdresDetayId { get; set; }
        public int AdresId { get; set; }
        public int AfetId { get; set; }

        //Navigation Prop
        public Adres Adres { get; set; }
        public Afet Afet { get; set; }
    }
}
