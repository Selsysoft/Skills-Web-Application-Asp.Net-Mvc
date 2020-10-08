using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace SKILLS.Models.classes
{
    public class CONTEXT : DbContext
    {
        public DbSet<SKILL> SKILLS { get; set; }
    }
}