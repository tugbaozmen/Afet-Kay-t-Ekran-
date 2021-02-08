using AfetEkrani.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfetEkrani.DAL.EntityFramework.Mapping
{
    class AdresDetayMapping : EntityTypeConfiguration<AdresDetay>
    {
        public AdresDetayMapping()
        {
            HasRequired(a => a.Afet)
                .WithMany(a => a.AdresDetaylari)
                .HasForeignKey(a => a.AfetId);

            HasRequired(a => a.Adres)
                .WithMany(a => a.AdresDetaylari)
                .HasForeignKey(a => a.AdresId);
        }
    }
}
