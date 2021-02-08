using AfetEkrani.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfetEkrani.DAL.EntityFramework.Mapping
{
    class AfetTuruMapping: EntityTypeConfiguration<AfetTuru>
    {
        public AfetTuruMapping()
        {
            Property(a => a.TurAdi)
                .HasMaxLength(30)
                .IsRequired();
        }
    }
}
