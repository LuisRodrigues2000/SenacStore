using System;
using System.Collections.Generic;
using System.Text;

namespace SenacStore.Application.DTOs
{
    public class UsuarioDto
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; }
        public string Email { get; set; }
        public Guid TipoUsuarioId { get; set; }

    }
}
