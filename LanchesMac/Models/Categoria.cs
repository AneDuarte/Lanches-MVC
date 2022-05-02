using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50, ErrorMessage = "O tamanho máximo é 50 caracteres")]
        [Required(ErrorMessage = "Esse campo é obrigatório")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [StringLength(300, ErrorMessage = "O tamanho máximo é 300 caracteres")]
        [Required(ErrorMessage = "Esse campo é obrigatório")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        public List<Lanche> Lanches { get; set; }

        public Categoria()
        {

        }

        public Categoria(int id, string nome, string descricao)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
        }
    }
}