using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ASP_Databáze.Models
{
    public class Movie
    {
        public int MovieId { get; set; }

        [Required(ErrorMessage = "Název filmu je povinný.")]
        [MinLength(2, ErrorMessage = "Název filmu musí mít alespoň 2 znaky.")]
        public required string Title { get; set; }

        [Range(1888, 2100, ErrorMessage = "Rok vydání musí být mezi 1888 a 2100.")]
        public int year { get; set; }

        [Required(ErrorMessage = "Délka filmu je povinná.")]
        public long Length { get; set; }
    }
}
