namespace LanchesMac.Models
{
    public class Lanche
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public string DescricaoCurta { get; set; }
        public string DescricaoLonga { get; set; }
        public string Imagem { get; set; }
        public string ImagemMiniatura { get; set; }
        public bool LanchePreferido { get; set; }
        public bool LancheDisponivel { get; set; }
        public virtual Categoria Categoria { get; set; }
        public int CategoriaId { get; set; }
    }
}