using AfetEkrani.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfetEkrani.DAL.EntityFramework.Mapping
{
    class IlceMapping: EntityTypeConfiguration<Ilce>
    {
        public IlceMapping()
        {
            Property(a => a.IlceAdi)
                .HasMaxLength(40)
                .IsRequired();


            //HasRequired(a => a.Il)
            //    .WithMany(a => a.Ilceler)
            //    .HasForeignKey(a => a.IlId)
            //    .WillCascadeOnDelete(false);
        }
    }
}
