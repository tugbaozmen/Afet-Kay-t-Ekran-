using AfetEkrani.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfetEkrani.DAL.EntityFramework.Mapping
{
    class AfetMapping: EntityTypeConfiguration<Afet>
    {
        public AfetMapping()
        {
            Property(a => a.SeriNo)
                .HasMaxLength(13)
                .IsRequired();
            Property(a => a.GlideNo)
                .HasMaxLength(13)
                .IsRequired();

            HasRequired(a => a.AfetTuru)
                .WithMany(a => a.Afetler)
                .HasForeignKey(a => a.AfetTuruId);

        }
    }
}
