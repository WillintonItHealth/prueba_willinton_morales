using prueba_willinton_morales.Models;

namespace prueba_willinton_morales.Interfaces
{
    public interface IPacientes
    {
        Respuesta CrearPaciente(PacienteModel paciente);
        Respuesta ActualizarPaciente(int id, PacienteModel paciente);
        Respuesta EliminarPaciente(int id);
    }
}
