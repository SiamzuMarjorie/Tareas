using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TodoListEvaluacion.Models
{
    [Table("PRIORIDADES")]
    public  class Prioridad
    {
        [Key]
        [Column("id")]
        public int id { get; set; }

        [Column("descripcion")]
        public string descripcion { get; set; }

    }
}
