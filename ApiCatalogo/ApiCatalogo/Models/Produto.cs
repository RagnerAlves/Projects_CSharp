using ApiCatalogo.Validations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ApiCatalogo.Models;

public class Produto : IValidatableObject
{
    [Key]
    public int ProdutoId { get; set; }

    [Required(ErrorMessage="Nome é obrigatório.")]
    [StringLength(20, ErrorMessage="O nome deve ter entre 5 a 20 caracteres", MinimumLength =5)]
    [PrimeiraLetraMaiusculaAttribuite]
    public string? Nome { get; set; }

    [Required]
    [StringLength(10, ErrorMessage ="A descrição deve ter no máximo {1} caracteres")]
    public string? Descricao { get; set; }

    [Required]
    [Range(1,10000, ErrorMessage ="O preço deve estar entre {1} e {2}")]
    public double? Preco { get; set; }

    [StringLength(300, MinimumLength =10)]
    public string? ImagemUrl { get; set; }
    public float Estoque { get; set; }
    public DateTime DataCadastro { get; set; }

    public int CategoriaId { get; set; }

    [JsonIgnore]
    public Categoria? Categoria { get; set; }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (!string.IsNullOrEmpty(Nome))
        {
            var primeiraLetra = Nome.ToString()[0].ToString();
            if (primeiraLetra != primeiraLetra.ToUpper())
            {
                yield return new
                    ValidationResult("A primeira letra deve ser maíuscula",
                    new[]
                    {nameof(Nome)});
            }
        }

        if (Estoque <= 0) 
        {
            yield return new
                   ValidationResult("O estoque deve ser maior que zero",
                   new[]
                   {nameof(Estoque)});
        }
    }
}
