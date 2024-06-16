using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SkillProfileWidget_CodeFirstEntity.Models.siniflar
{
    public class Skill
    {
        [Key]
        public int id { get; set; }
        public string Aciklama { get; set; }
        public byte Deger { get; set; }
        //sql byte karşılığı: tinyint

    }
}