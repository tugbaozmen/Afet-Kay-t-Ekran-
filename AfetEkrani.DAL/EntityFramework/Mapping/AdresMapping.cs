using AfetEkrani.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfetEkrani.DAL.EntityFramework.Mapping
{
    class AdresMapping: EntityTypeConfiguration<Adres>
    {
        public AdresMapping()
        {

            HasRequired(a => a.Il)
                .WithMany(a => a.Adresler)
                .HasForeignKey(a => a.IlId);

            HasRequired(a => a.Ilce)
                .WithMany(a => a.Adresler)
                .HasForeignKey(a => a.IlceId);

            HasRequired(a => a.Mahalle)
                .WithMany(a => a.Adresler)
                .HasForeignKey(a => a.MahalleId);

            HasRequired(a => a.Belde)
                .WithMany(a => a.Adresler)
                .HasForeignKey(a => a.BeldeId);
        }
    }
}
