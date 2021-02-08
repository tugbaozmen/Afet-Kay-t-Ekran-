using AfetEkrani.DAL.EntityFramework.Mapping;
using AfetEkrani.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfetEkrani.DAL.EntityFramework
{
   public class AfetEkraniDBContext:DbContext 
    {
        public AfetEkraniDBContext(): base("name=AfetEkraniDBConnstr")
        {

        }

        public DbSet<Adres> Adres { get; set; }
        public DbSet<Afet> Afet { get; set; }
        public DbSet<AfetTuru> AfetTuru { get; set; }
        public DbSet<Il> Il { get; set; }
        public DbSet<Ilce> Ilce { get; set; }
        public DbSet<Mahalle> Mahalle { get; set; }
        public DbSet<Belde> Belde { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AfetMapping());
            modelBuilder.Configurations.Add(new AdresMapping());
            modelBuilder.Configurations.Add(new AfetTuruMapping());
            modelBuilder.Configurations.Add(new IlMapping());
            modelBuilder.Configurations.Add(new IlceMapping());
            modelBuilder.Configurations.Add(new MahalleMapping());
            modelBuilder.Configurations.Add(new BeldeMapping());


            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        }
    }
}
