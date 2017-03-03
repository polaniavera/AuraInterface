using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuraInterface.Models
{
    public class SectorServicio
    {
       public SectorServicio()
        {
            this.NormaSector = new HashSet<NormaSector>();
            //this.Servicio = new HashSet<Servicio>();
        }

        public int IdSectorServicio { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int IdEstado { get; set; }

        public ICollection<NormaSector> NormaSector { get; set; }
        //public virtual ICollection<Servicio> Servicio { get; set; }
    }
}