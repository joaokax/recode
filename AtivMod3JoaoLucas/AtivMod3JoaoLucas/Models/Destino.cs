using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AgenciaViagens.Models
{
    public class Destino
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Partida { get; set; }

        [Required]
        public string Chegada { get; set; }

        [Required]
        public string Ida { get; set; }

        [Required]
        public string Volta { get; set; }
    }
}
