namespace TecnoStore.Models;

public class CategoriaDto
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public string? Slug { get; set; }
}

public class MarcaDto
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
}

// Referencia mínima a un producto: dentro de otros objetos (por ejemplo, una imagen)
// la API solo envía el id y el sku, no el producto completo.
public class ProductoRefDto
{
    public int Id { get; set; }
    public string? Sku { get; set; }
}

public class ProductoDto
{
    public int Id { get; set; }
    public string? Sku { get; set; }
    public string? Nombre { get; set; }
    public string? Slug { get; set; }
    public string? Modelo { get; set; }
    public string? Descripcion { get; set; }
    public decimal PrecioLista { get; set; }
    public decimal? PrecioOferta { get; set; }
    public int? GarantiaMeses { get; set; }
    public CategoriaDto? Categoria { get; set; }
    public MarcaDto? Marca { get; set; }
}

public class ProductoImagenDto
{
    public int Id { get; set; }
    public string Url { get; set; } = "";
    public int Orden { get; set; }
    public ProductoRefDto? Producto { get; set; }
}