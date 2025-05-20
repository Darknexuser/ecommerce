using System;

using System.ComponentModel.DataAnnotations;


namespace Ecommerce.Shared.Entities
{
    public class country
    {
        public int Id { get; set; }
        [Display(Name="Pais")]
        [Required(ErrorMessage = "el campo es obligatorio")]
        [MaxLength(100)]
        public string Name { get; set; }

        public ICollection<State> States { get; set; }

        [Display(Name="Estados/Departamentos")]
        public int StatesNumber => States == null ? 0 : States.Count();

    }
}
