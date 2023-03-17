using System;

namespace prueba_willinton_morales.Models
{
    /// <summary>
    /// Modelo con los datos del paciente
    /// </summary>
    public class PacienteModel
    {
        /// <summary>
        /// Id del tipo de documento. Tipo Entero
        /// </summary>
		public int IdTipoDocumento { get; set; }
        /// <summary>
        /// Número de documento. Tipo string
        /// </summary>
		public string NumeroDocumento { get; set; }
        /// <summary>
        /// Nombres del Paciente. Tipo string
        /// </summary>
	    public string Nombres { get; set; }
        /// <summary>
        /// Apellidos del paciente. Tipo string
        /// </summary>
        public string Apellidos { get; set; }
        /// <summary>
        /// Correo electrónico del paciente. Tipo string
        /// </summary>
        public string   Correo { get; set; }
        /// <summary>
        /// Número Telefónico del paciente. Tipo string
        /// </summary>
        public string Telefono { get; set; }
        /// <summary>
        /// Fecha de nacimiento del paciente. Tipo DateTime
        /// </summary>
        public DateTime FechaNacimiento { get; set; }
        /// <summary>
        /// Estado de la afiliacion. Tipo bool
        /// </summary>
        public bool EstadoAfiliacion { get; set; }
    }
}
