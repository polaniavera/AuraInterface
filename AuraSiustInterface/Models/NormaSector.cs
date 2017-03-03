using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuraInterface.Models
{
    public class NormaSector
    {
        public int IdNormaSector { get; set; }
        public int IdNorma { get; set; }
        public int IdSectorServicio { get; set; }
        public int IdEstado { get; set; }

        public Norma NORMA { get; set; }
        public virtual SectorServicio SectorServicio { get; set; }
    }
}