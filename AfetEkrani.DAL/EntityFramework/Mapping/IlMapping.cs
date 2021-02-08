using AfetEkrani.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfetEkrani.DAL.EntityFramework.Mapping
{
    class IlMapping: EntityTypeConfiguration<Il>
    {
        public IlMapping()
        {
            Property(a => a.IlAdi)
                .HasMaxLength(40)
                .IsRequired();
        }
    }
}
