using System.Net.Http.Json;
using TecnoStore.Models;

namespace TecnoStore.Services;

public class TiendaApi(HttpClient http)
{
    // Una página de productos + el total (viene en el encabezado X-Total-Count)
    public async Task<(List<ProductoDto> Items, int Total)> GetProductosAsync(int page = 0, int size = 12)
    {
        using var resp = await http.GetAsync($"api/productos?page={page}&size={size}");
        resp.EnsureSuccessStatusCode();
        var items = await resp.Content.ReadFromJsonAsync<List<ProductoDto>>() ?? new();
        var total = resp.Headers.TryGetValues("X-Total-Count", out var v)
                    && int.TryParse(v.FirstOrDefault(), out var t) ? t : items.Count;
        return (items, total);
    }

    public async Task<List<CategoriaDto>> GetCategoriasAsync() =>
        await http.GetFromJsonAsync<List<CategoriaDto>>("api/categorias") ?? new();

    public async Task<List<ProductoImagenDto>> GetImagenesAsync() =>
        await http.GetFromJsonAsync<List<ProductoImagenDto>>("api/producto-imagens") ?? new();
}