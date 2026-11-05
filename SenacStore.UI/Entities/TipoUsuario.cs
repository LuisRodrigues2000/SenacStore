namespace SenacStore.Domain.Entities
{
    public class TipoUsuario
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; }

    }
}
