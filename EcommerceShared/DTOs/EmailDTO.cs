using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Shared.DTOs
{
    public class EmailDTO
    {
        [Required(ErrorMessage = "El campo {0} Es requerido")]
        [EmailAddress(ErrorMessage = "El campo debe ser obligatorio")]
        [Display(Name = "Email")]

        public string Email { get; set; }
    }
}
