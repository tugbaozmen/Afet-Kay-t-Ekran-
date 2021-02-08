using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfetEkrani.Model
{
    public class Adres:BaseEntity
    {
        public Adres()
        {
            AdresDetaylari = new HashSet<AdresDetay>();
        }
        public int AdresId { get; set; }
        public int IlId { get; set; }
        public int IlceId { get; set; }
        public int MahalleId { get; set; }
        public int BeldeId { get; set; }

        //Navigation Property
        public ICollection<AdresDetay> AdresDetaylari { get; set; }
        public Il Il { get; set; }
        public Ilce Ilce { get; set; }
        public Mahalle Mahalle { get; set; }
        public Belde Belde { get; set; }
    }
}
