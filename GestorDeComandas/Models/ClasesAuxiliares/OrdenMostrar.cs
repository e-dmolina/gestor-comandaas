using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeComandas.ClasesAuxiliares
{
   class OrdenMostrar
   {
      public int id { get; set; }
      public string nombre { get; set; }
      public string direccion { get; set; }
      public decimal total { get; set; }
      public string observacion { get; set; }
      public Nullable<System.DateTime> fecha { get; set; }
      public Nullable<System.TimeSpan> hora { get; set; }
      public string estado { get; set; }
   }
}
