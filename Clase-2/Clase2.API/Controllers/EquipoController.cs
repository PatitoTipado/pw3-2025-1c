using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Clase2.Logica;
using Clase2.Entidad;

namespace Clase2.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipoController : ControllerBase
    {
        IEquipoServicio EquipoServicio;

        public EquipoController(IEquipoServicio equipoServicio)
        {
            this.EquipoServicio = equipoServicio;
        }

        [HttpGet]
        public IActionResult GetResultados()
        {
            var equipos = this.EquipoServicio.ObtenerEquipos();
            if (equipos == null || !equipos.Any())
            {
                return NotFound("No hay resultados disponibles.");
            }
            return Ok(equipos);
        }
        [HttpPost]
        public IActionResult AgregarResultado([FromBody] Equipo equipo)
        {
            if (equipo == null)
            {
                return BadRequest("El resultado no puede ser nulo.");
            }
            this.EquipoServicio.AgregarEquipo(equipo);
            return CreatedAtAction(nameof(GetResultados), new { id = equipo.nombre }, equipo);
        }

        [HttpDelete("{nombre}/{pais}")]
        public IActionResult EliminarEquipo(string nombre, string pais)
        {
            var equipo = new Equipo() ;
            equipo.nombre = nombre ;
            equipo.pais = pais ;
            var resultado = this.EquipoServicio.eliminarEquipo(equipo);

            if (resultado)
            {
                return Ok("El equipo fue eliminado.");
            }

            return BadRequest("No se pudo eliminar el equipo por que no se encontro");
        }
    }
}
