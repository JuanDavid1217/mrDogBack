namespace mrdog_api.Models;
public class Tallas_mascota
{
    public int Id_talla {get; set;}
    public string Talla {get; set;} = string.Empty;
    public int Aumento_precio {get; set;}
}

/*
Insert Into tallas_mascota Values('Chico', 0);
Insert Into tallas_mascota Values('Mediano', 5);
Insert Into tallas_mascota Values('Grande', 10);
Insert Into tallas_mascota Values('Gigante', 15);
 */