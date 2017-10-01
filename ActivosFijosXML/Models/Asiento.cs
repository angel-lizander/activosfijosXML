using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivosFijosXML.Models
{
    public class Asiento
    {
        public int NoAsiento { get; set; }
        public string Descripcion { get; set; } = string.Empty;
        public DateTime Fecha { get; set; } = DateTime.Now;
        public string Cuenta { get; set; }
        public string TipoMoviemiento { get; set; }
        public double Monto { get; set; }
    }
}