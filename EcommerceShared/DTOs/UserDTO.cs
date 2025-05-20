using Ecommerce.Shared.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Shared.DTOs
{
    public class UserDTO : User 
    {
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        [Required(ErrorMessage ="El campo {0} Es requerido")]
        [StringLength(20,MinimumLength = 6, ErrorMessage ="El campo {0} dede tener {2} y {1} Caracteres")] 

        public string password { get; set; } = null;

        [Compare("Password", ErrorMessage ="la contraseña de confirmacion debe ser igual ")]
        [Display(Name = "Confirmacion Contraseña")]
        [DataType(DataType.Password)]

        [Required(ErrorMessage = "El campo {0} Es requerido")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "El campo {0} dede tener {2} y {1} Caracteres")]


        public string firstName { get; set; } = null;
    }
}
