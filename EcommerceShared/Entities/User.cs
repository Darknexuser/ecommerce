using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecommerce.Shared.Enums;
using Microsoft.AspNetCore.Identity;

namespace Ecommerce.Shared.Entities
{
    public class User :IdentityUser
    {
        [Display(Name = "El Documento es obligatorio")]
        [Required(ErrorMessage ="El campo {0} Es obligatorio ")]
        [MaxLength(100)]
        public string Document { get; set; }

        [Display(Name = "Nombres")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener maximo (1) caracteres")]
        [Required(ErrorMessage = "El campo {0} Es obligatorio ")]

        public string FirstName { get; set; } = null;
        [Display(Name = "Apellidos")]

        [MaxLength(50, ErrorMessage = "El campo {0} debe tener maximo (1) caracteres")]
        [Required(ErrorMessage = "El campo {0} Es obligatorio ")]

        public string LastName { get; set; } = null;

        [Display(Name = "Direccion")]

        [MaxLength(50, ErrorMessage = "El campo {0} debe tener maximo (1) caracteres")]
        [Required(ErrorMessage = "El campo {0} Es obligatorio ")]

        public string Address { get; set; } = null;

        [Display(Name = "Tipo de Usuario")]
        public UserType UserType { get; set; }  
        public City? City { get; set; }
        [Display(Name = "Ciudad")]
        [Range(1, int.MaxValue, ErrorMessage = "Debes seleccionar una {0}. ")]
        public int CityId { get; set; }
        [Display(Name ="Usuario")]
        public string FullName => $"{FirstName} {LastName}";    









    }
}
