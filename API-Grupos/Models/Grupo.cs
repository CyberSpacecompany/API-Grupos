using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_Grupo.Models
{
    public class Grupo
    {
        public int IDgrupo { get; set; }
        public string nombre_grupo { get; set; }
        [MaxLength(50)]
        public string descripcion_grupo { get; set; }
        [MaxLength(150)]
        public string fotoDeGrupo { get; set; }
        public int creador { get; set; }
    }
}
