namespace SenacStore.Application.DTOs
{
    public class LoginRespostaDto
    {
        public string Token { get; set; } = string.Empty;
        public UsuarioDto? Usuario { get; set; }

    }
}
