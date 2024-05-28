using System.ComponentModel.DataAnnotations.Schema;

namespace mrdog_api.Models;
public class Paquetes_estetica
{
    public int Id_paquete {get; set;}
    public string? Nombre {get; set;} = string.Empty;
    public string? Descripcion {get; set;} = string.Empty;
    
    [Column(TypeName = "decimal(6, 2)")]
    public decimal? Precio_base {get; set;} 
}

/*
Insert Into paquetes_estetica Values('Baño antipulgas.', 'Aplicación de baño con solución antipulgas.', 200.00);
Insert Into paquetes_estetica Values('Baño general.', 'Aplicación de baño general.', 150.00);
Insert Into paquetes_estetica Values('Baño general y Corte de pelo.', 'Aplicación de baño general y Corte de pelo (corte base).', 350.00);
Insert Into paquetes_estetica Values('Solo Corte de pelo.', 'Solo Corte de pelo (corte base).', 200.00);
*/