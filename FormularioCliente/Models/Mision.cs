using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ApiWindows.Models
{
   
    public class Mision
    {
       
        public int idMision { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int nTripulantes { get; set; }
        public int nNaves { get; set; }
        public int duracionDias { get; set; }
        public Boolean estatus { get; set; }
        public int idCuerpoCeleste { get; set; }
    }
}
