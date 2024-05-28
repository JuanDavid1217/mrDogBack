namespace mrdog_api.Models;
public class Clientes
{
    public long Id_cliente {get; set;}
    public string Nombre {get; set;} = string.Empty;
    public string Telefono {get; set;} = string.Empty;
    public string Password {get; set;} = string.Empty;
}