using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudEntityFramework.Models
{
    public class Usuario
    {
        //en este apartado indicamos que es una llave primaria
    [Key]
        public  int Id {get; set;}

        [Required(ErrorMessage ="El Nombre es Requerido")]
        public string Nombre { get; set; }

        [Required(ErrorMessage ="El Teléfono es Requerido")]
        [Display(Name ="Teléfono")]
        public int Telefono { get; set;  }

        [Required(ErrorMessage ="El Celular es Requerido")]
        public int Celuar { get; set; }

        [Required(ErrorMessage ="El Email es Requerido")]
        public string Email { get; set;  }
    }
}
