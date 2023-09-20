using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Shared.Entities
{
    public class Country
    {
        public int Id { get; set; }
        [Display(Name = "Pais")] //son etiquetas del  nombre de campo
        [MaxLength(100, ErrorMessage = "El campo{0} debe contener únicamente 100 caracteres")]//es la longitud de caracteres de campo
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string? Name { get; set; }    //? (indica que hace un salto de nulos)



    }
}
