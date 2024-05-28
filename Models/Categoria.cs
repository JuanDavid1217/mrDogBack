namespace mrdog_api.Models;
public class Categorias
{
    public int Id_categoria {get; set;}
    public string Categoria {get; set;} = string.Empty;
}

/*
Insert Into categorias Values ('Alimentos');
Insert Into categorias Values ('Medicina Veterinaria');
Insert Into categorias Values ('Accesorios y Juguetes');
*/