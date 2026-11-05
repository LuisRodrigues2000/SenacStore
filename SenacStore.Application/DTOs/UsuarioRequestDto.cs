using System.Text.Json.Serialization;

namespace SenacStore.Application.DTOs
{
    public class UsuarioRequestDto
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        //summary: The password is optional, as it may not be provided in certain scenarios, such as when updating user information without changing the password.
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Senha { get; set; }

        public Guid TipoUsuarioId { get; set; }
    }
}
