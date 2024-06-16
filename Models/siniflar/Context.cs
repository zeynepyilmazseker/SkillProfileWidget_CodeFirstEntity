using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace SkillProfileWidget_CodeFirstEntity.Models.siniflar
{
    public class Context : DbContext
    {
        public DbSet<Skill> Skills { get; set; }
    }
}