using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UI.Areas.Genero.ViewModels
{
    public class GeneroViewModel
    {
        [Key]
        public long GeneroId { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Nome { get; set; }
    }
}