using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TodoListEvaluacion.Models
{
    [Table("TAREAS")]
    public class Tarea
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required(ErrorMessage = "Escriba el nombre de la tarea")]
        public string Nombre { get; set; }
        public string Detalle { get; set; }
        public DateTime fecharegistro { get; set; }

        
        public int idPrioridad { get; set; }

        [ForeignKey("id")]
        public virtual  Prioridad Prioridad { get; set; }
    }
}
