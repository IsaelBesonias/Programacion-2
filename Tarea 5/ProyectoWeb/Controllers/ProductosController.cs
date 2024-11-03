
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;

public class ProductosController : Controller
{
    private readonly IHttpClientFactory _httpClientFactory;

    public ProductosController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IActionResult> Index()
    {
        var client = _httpClientFactory.CreateClient("api");
        var response = await client.GetStringAsync("productos");
        var productos = JsonSerializer.Deserialize<List<Producto>>(response);
        return View(productos);
    }

    // Placeholder for additional CRUD methods for Create, Edit, and Delete.
}