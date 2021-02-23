using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraLaboralBackend.Models
{
    public class Servicio
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [DataType(DataType.Text, ErrorMessage = "Debe ser un texto")]
        public string Tecnico { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [DataType(DataType.Text, ErrorMessage = "Debe ser un texto")]
        public string ServicioRealizado { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [Range(1, 52, ErrorMessage = "Un año tiene entre 1 52 semanas")]
        public int SemanaDelAno { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public string DiaDeLaSemana { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "Campo requerido")]        
        public int HoraInicial { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public int HoraFinal { get; set; }
                
        public int HorasDiurnas { get; set; }
                
        public int HorasNocturnas { get; set; }

    }
}
