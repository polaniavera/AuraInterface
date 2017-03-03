using System.Collections.Generic;

namespace AuraInterface.Models
{
    public class Norma
    { 
        public Norma()
        {
            this.NormaSector = new HashSet<NormaSector>();
        }

        public int IdNorma { get; set; }
        public string CodigoNorma { get; set; }
        public string NombreNorma { get; set; }
        public System.DateTime FechaNorma { get; set; }
        public int IdTipoNorma { get; set; }
        public int IdEntidadEmite { get; set; }
        public string UrlLink { get; set; }
        public string Descripcion { get; set; }
        public int IdNormaPadre { get; set; }
        public System.DateTime FechaInicio { get; set; }
        public int IdEstado { get; set; }

        public virtual ICollection<NormaSector> NormaSector { get; set; }
    }
}
