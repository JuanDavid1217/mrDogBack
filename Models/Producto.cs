using System.ComponentModel.DataAnnotations.Schema;

namespace mrdog_api.Models;
public class Producto
{
    public long Id_producto {get; set;}
    public string Nombre {get; set;} = string.Empty;
    public string Descripcion {get; set;} = string.Empty;
    [Column(TypeName = "decimal(6, 2)")]
    public decimal Precio_venta {get; set;}
    public int Descuento {get; set;}
    public int Id_categoria {get; set;}
}

/*
Insert Into productos values ('Alimento para Perro Adulto Marca Nupec', 'Bolsa de Alimento para perro Adulto marca Nupec de 5kg', '1600.00', 10, 1);
Insert Into productos values ('Cama anti estrés para tu peludito.', 'Cama de algodón recubierta, anti estrés, diferentes colores', '500.00', 0, 3);
Insert Into productos values ('Analgésico Naxpet, solución Oral.', 'Analgésico canino, con efecto retardante plazo.', '250.00', 5, 2);
*/