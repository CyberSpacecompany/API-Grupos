using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Grupos.Models
{
    public class Usuario
    {
        public int IDusuario { get; set; }
        public string nombreUsuario { get; set; }
        public int Edad { get; set; }
        public string CorreoElectronico { get; set; }
        public bool tipo_de_usuario { get; set; }
        public string fotoPerfil { get; set; }
        public string biografia { get; set; }
        private DateTime _fechaCreacion;

        public DateTime fechaCreacion
        {
            get { return _fechaCreacion.Date; }  // Solo la parte de la fecha
            set { _fechaCreacion = value; }
        }
    }
}