using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TaskWebJob.Models
{
    [Table("DATOSWEBJOB")]
    public class WebJob
    {
        [Key]
        [Column("IDTITULAR")]
        public int IdTitular { get; set; }
        [Column("TITULO")]
        public string Titulo { get; set; }
        [Column("ENLACE")]
        public string Enlace { get; set; }
        [Column("DESCRIPCION")]
        public string Descripcion { get; set; }
        [Column("FECHA")]
        public DateTime Fecha { get; set; }
    }
}
