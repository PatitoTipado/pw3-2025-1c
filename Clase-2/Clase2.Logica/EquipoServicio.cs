using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase2.Entidad;

namespace Clase2.Logica
{
    public interface IEquipoServicio
    {
        void AgregarEquipo(Equipo equipo);
        List<Equipo> ObtenerEquipos();
        bool eliminarEquipo(Equipo equipo);
    }

    public class EquipoServicio : IEquipoServicio
    {
        private List<Equipo> _equipos;

        public EquipoServicio()
        {
            _equipos = new List<Equipo>();
        }
        public void AgregarEquipo(Equipo equipo)
        {
            _equipos.Add(equipo);
        }

        public bool eliminarEquipo(Equipo equipo)
        {

            if (_equipos.Contains(equipo))
            {

                return _equipos.Remove(equipo);
            }

            return false;
        }

        public List<Equipo> ObtenerEquipos()
        {
            return _equipos;
        }

    }
}
