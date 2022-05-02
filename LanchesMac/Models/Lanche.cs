using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models
{
    [Table("Lanches")]
    public class Lanche
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50, ErrorMessage = "O tamanho máximo é 50 caracteres")]
        [Required(ErrorMessage = "Esse campo é obrigatório")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Esse campo é obrigatório")]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(3, 2)")]
        [Range(1, 999.99, ErrorMessage = "O preço deve estar entre 1.00 e 999.00")]
        public double Preco { get; set; }

        [Required(ErrorMessage = "Esse campo é obrigatório")]
        [Display(Name = "Descrição curta")]
        [StringLength(80, MinimumLength = 10, ErrorMessage = "O {0} deve ter no mínimo {1} caracteres e no máximo {2}")]
        public string DescricaoCurta { get; set; }

        [Required(ErrorMessage = "Esse campo é obrigatório")]
        [Display(Name = "Descrição longa")]
        [MinLength(25, ErrorMessage = "A descrição deve ter no mínimo {1} caracteres")]
        [MaxLength(300, ErrorMessage = "A descrição deve ter no máximo {1} caracteres")]
        public string DescricaoLonga { get; set; }

        [Display(Name = "Url da imagem")]
        [Required(ErrorMessage = "Esse campo é obrigatório")]
        [StringLength(200, ErrorMessage = "A URL deve ter até 200 caracteres")]
        public string Imagem { get; set; }

        [Display(Name = "Url da thumbnail")]
        [Required(ErrorMessage = "")]
        public string ImagemMiniatura { get; set; }
        public bool LanchePreferido { get; set; }
        public bool LancheDisponivel { get; set; }
        public virtual Categoria Categoria { get; set; }
        public int CategoriaId { get; set; }
    }
}