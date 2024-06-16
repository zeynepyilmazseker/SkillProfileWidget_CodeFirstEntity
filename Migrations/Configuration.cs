namespace SkillProfileWidget_CodeFirstEntity.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SkillProfileWidget_CodeFirstEntity.Models.siniflar.Context>
    {
        public Configuration()
        {
            //burası kendiliğinden false geliyor
            //true olmazsa yapılan güncellemeler update-database komutuyla veri tabanına yansımıyor.

            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(SkillProfileWidget_CodeFirstEntity.Models.siniflar.Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
