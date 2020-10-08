using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SKILLS.Models.classes
{
    public class SKILL
    {
        [Key]
        public int ID { get; set; }
        public string ACIKLAMA { get; set; }
        public byte DEGER { get; set; }
    }
}