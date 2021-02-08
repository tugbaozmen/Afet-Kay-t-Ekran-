namespace AfetEkrani.DAL.Migrations
{
    using AfetEkrani.Model;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AfetEkrani.DAL.EntityFramework.AfetEkraniDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(AfetEkrani.DAL.EntityFramework.AfetEkraniDBContext context)
        {
            //List<AfetTuru> afetTurleri = new List<AfetTuru>()
            //{
            //    new AfetTuru(){TurAdi="Sel"},
            //    new AfetTuru(){TurAdi="Deprem"},
            //    new AfetTuru(){TurAdi="Çığ"},
            //    new AfetTuru(){TurAdi="Toprak Kayması"},
            //    new AfetTuru(){TurAdi="Hortum"},
            //    new AfetTuru(){TurAdi="Yangın"}
            //};

            //context.AfetTuru.AddRange(afetTurleri);
            //context.SaveChanges();

        }
    }
}
