using AfetEkrani.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfetEkrani.DAL.EntityFramework.Mapping
{
    class MahalleMapping: EntityTypeConfiguration<Mahalle>
    {
        public MahalleMapping()
        {
            Property(a => a.MahalleAdi)
                .HasMaxLength(50)
                .IsRequired();

            //HasRequired(a => a.Ilce)
            //    .WithMany(a => a.Mahalleler)
            //    .HasForeignKey(a => a.IlceId)
            //    .WillCascadeOnDelete(false);
        }
    }
}
