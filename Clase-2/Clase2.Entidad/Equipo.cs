using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2.Entidad
{
    public class Equipo
    {
        public string nombre { get; set; }
        public string pais { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is Equipo equipo &&
                   nombre == equipo.nombre &&
                   pais == equipo.pais;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(nombre, pais);
        }
    }
}
