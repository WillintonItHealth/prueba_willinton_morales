using Microsoft.AspNetCore.Mvc;
using prueba_willinton_morales.Interfaces;
using prueba_willinton_morales.Models;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace prueba_willinton_morales.Controllers
{
    
    [ApiController]
    public class PacientesController : ControllerBase
    {
        public readonly IPacientes pacientes;

        public PacientesController(IPacientes pacientes)
        {
            this.pacientes = pacientes;
        }

        /// <summary>
        /// Crear Paciente
        /// </summary>
        /// <param name="data"></param>
        [HttpPost]
        [Route("api/CrearPaciente")]
        public Respuesta Post([FromBody] PacienteModel data)
        {
            return pacientes.CrearPaciente(data);
        }

        /// <summary>
        /// Actualizar Paciente
        /// </summary>
        /// <param name="id"></param>
        /// <param name="data"></param>
        [HttpPut]
        [Route("api/ActualizarPaciente/{id}")]
        public Respuesta Put([FromRoute]int id, [FromBody] PacienteModel data)
        {
            return pacientes.ActualizarPaciente(id, data);
        }

        /// <summary>
        /// Eliminar Paciente
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete]
        [Route("api/EliminarPaciente/{id}")]
        public Respuesta Delete([FromRoute]int id)
        {
            return pacientes.EliminarPaciente(id);
        }
    }
}
