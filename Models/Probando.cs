using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TodoListEvaluacion.Models
{
    public class Probando
    {
        [Required(ErrorMessage ="Escriba el nombre de la tarea")]
        public string Nombre  { get; set; }

        [Required(ErrorMessage = "Describa el detalle de la tarea")]
        public string Detalle { get; set; }

        [Required(ErrorMessage ="Seleccione la fecha de registro")]
        [DataType(DataType.Date)]
        public DateTime fecharegistro { get; set; }

        public int idPrioridad { get; set; }

    }
}
