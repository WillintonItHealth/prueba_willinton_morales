using prueba_willinton_morales_back.Models;

namespace prueba_willinton_morales_back.Interfaces
{
    public interface IPacientes
    {
        Respuesta CrearPaciente(PacienteModel paciente);
        Respuesta ActualizarPaciente(int id, PacienteModel paciente);
        Respuesta EliminarPaciente(int id);
    }
}
