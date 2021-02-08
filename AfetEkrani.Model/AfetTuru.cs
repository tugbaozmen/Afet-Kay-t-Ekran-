using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfetEkrani.Model
{
   public class AfetTuru:BaseEntity
    {
        public AfetTuru()
        {
            Afetler = new HashSet<Afet>();
        }
        public int AfetTuruId { get; set; }
        public string TurAdi { get; set; }

        //Navigation Property
        public ICollection<Afet> Afetler { get; set; }
    }
}
