using System.ComponentModel.DataAnnotations;

namespace TestPermutacionesCubanEngenier.Models
{
    public class Permutation
    {
        [Required(ErrorMessage = "Debe proporcionar una lista de 3 números separados por comas.")]
        [RegularExpression(@"^\d+(,\s*\d+){2}$", ErrorMessage = "Por favor ingrese una lista válida de 3 números enteros separados por comas.")]
        public string Numbers { get; set; }
    }
}
