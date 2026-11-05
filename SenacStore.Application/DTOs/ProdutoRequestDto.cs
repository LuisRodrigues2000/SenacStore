namespace SenacStore.Application.DTOs
{
    public class ProdutoRequestDto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public Guid CategoriaId { get; set; }
    }
}
