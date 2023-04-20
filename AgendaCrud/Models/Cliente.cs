using System;
using System.Collections.Generic;

namespace AgendaCrud.Models;

public partial class Cliente
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Email { get; set; }

    public string? Numero { get; set; }

    public string? Empresa { get; set; }
}
