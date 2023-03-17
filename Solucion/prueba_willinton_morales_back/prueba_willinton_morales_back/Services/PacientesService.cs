using Microsoft.AspNetCore.Http;

using prueba_willinton_morales.Interfaces;
using prueba_willinton_morales.Models;
using System.Data.SqlClient;
using System.Net.Http;

namespace prueba_willinton_morales.Services
{
    public class PacientesService : IPacientes
    {
        /// <summary>
        /// Método para crear paciente
        /// </summary>
        /// <param name="paciente">Datos del paciente a crear</param>
        /// <returns>Respueta con mensaje, estado y datos</returns>
        public Respuesta CrearPaciente(PacienteModel paciente)
        {
            using(SqlConnection sqlcn = new SqlConnection(DbConnection.Connection))
            {
                /*
                 * SP de creación
                 */
                SqlCommand cmd = new SqlCommand("sp_CrearPaciente", sqlcn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("IdTipoDocumento", paciente.IdTipoDocumento);
                cmd.Parameters.AddWithValue("NumeroDocumento", paciente.NumeroDocumento);
                cmd.Parameters.AddWithValue("Nombres", paciente.Nombres);
                cmd.Parameters.AddWithValue("Apellidos", paciente.Apellidos);
                cmd.Parameters.AddWithValue("Correo", paciente.Correo);
                cmd.Parameters.AddWithValue("Telefono", paciente.Telefono);
                cmd.Parameters.AddWithValue("FechaNacimiento", paciente.FechaNacimiento);
                cmd.Parameters.AddWithValue("EstadoAfiliacion", paciente.EstadoAfiliacion);
                var respuesta = new Respuesta();
                try
                {
                    sqlcn.Open();
                    cmd.ExecuteNonQuery();

                    respuesta.Mensaje = "Paciente creado correctamente";
                    respuesta.Estado = true;

                    return respuesta;
                }
                catch (System.Exception ex)
                {
                    respuesta.Mensaje = "Error al crear paciente";
                    respuesta.Estado = false;
                    respuesta.Data = ex.ToString();

                    return respuesta;
                }
            }
        }

        /// <summary>
        /// Metodo para Actualizar Paciente
        /// </summary>
        /// <param name="id">Id del paciente a actualizar</param>
        /// <param name="paciente">Datos del paciente a actualizar</param>
        /// <returns>Respueta con mensaje, estado y datos</returns>
        public Respuesta ActualizarPaciente(int id, PacienteModel paciente)
        {
            using (SqlConnection sqlcn = new SqlConnection(DbConnection.Connection))
            {
                /*
                 * SP de actualizacion
                 */
                SqlCommand cmd = new SqlCommand("sp_ActualizarPaciente", sqlcn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("id", id);
                cmd.Parameters.AddWithValue("IdTipoDocumento", paciente.IdTipoDocumento);
                cmd.Parameters.AddWithValue("NumeroDocumento", paciente.NumeroDocumento);
                cmd.Parameters.AddWithValue("Nombres", paciente.Nombres);
                cmd.Parameters.AddWithValue("Apellidos", paciente.Apellidos);
                cmd.Parameters.AddWithValue("Correo", paciente.Correo);
                cmd.Parameters.AddWithValue("Telefono", paciente.Telefono);
                cmd.Parameters.AddWithValue("FechaNacimiento", paciente.FechaNacimiento);
                cmd.Parameters.AddWithValue("EstadoAfiliacion", paciente.EstadoAfiliacion);

                var respuesta = new Respuesta();
                try
                {
                    sqlcn.Open();
                    cmd.ExecuteNonQuery();
                    respuesta.Mensaje = "Paciente actualizado correctamente";
                    respuesta.Estado = true;

                    return respuesta;
                }
                catch (System.Exception ex)
                {
                    respuesta.Mensaje = "Error al actualizar paciente";
                    respuesta.Estado = false;
                    respuesta.Data = ex.ToString();

                    return respuesta;
                }
            }
        }

        /// <summary>
        /// Método para Eliminar Paciente
        /// </summary>
        /// <param name="id">Id del paciente a Eliminar</param>
        /// <returns>Respueta con mensaje, estado y datos</returns>
        Respuesta IPacientes.EliminarPaciente(int id)
        {
            using (SqlConnection sqlcn = new SqlConnection(DbConnection.Connection))
            {
                /*
                 * SP de eliminación
                 */
                SqlCommand cmd = new SqlCommand("sp_EliminarPaciente", sqlcn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("id", id);

                var respuesta = new Respuesta();
                try
                {
                    sqlcn.Open();
                    cmd.ExecuteNonQuery();
                    respuesta.Mensaje = "Paciente eliminado correctamente";
                    respuesta.Estado = true;

                    return respuesta;
                }
                catch (System.Exception ex)
                {
                    respuesta.Mensaje = "Error al eliminar paciente";
                    respuesta.Estado = false;
                    respuesta.Data = ex.ToString();

                    return respuesta;
                }
            }
        }
    }
}
