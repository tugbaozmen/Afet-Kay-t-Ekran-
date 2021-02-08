using AfetEkrani.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfetEkrani.DAL.EntityFramework.Mapping
{
    class BeldeMapping: EntityTypeConfiguration<Belde>
    {
        public BeldeMapping()
        {
            Property(a => a.BeldeAdi)
                .HasMaxLength(40)
                .IsRequired();

            //HasRequired(a => a.Ilce)
            //    .WithMany(a => a.Beldeler)
            //    .HasForeignKey(a => a.IlceId)
            //    .WillCascadeOnDelete(false);
        }
    }
}
