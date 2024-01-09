using Microsoft.AspNetCore.Mvc;

namespace Catalogo.API.Controllers;

[ApiController]
[Route("api/[catalog]")]
public class CatalogController : ControllerBase
{
    //GET api/values
    [HttpGet("GetProductos")]
    public ActionResult<IList<Producto>> GetProductos(){
        var resultado = new List<Producto>
        {
            new() { ProductoId = 1, Descripcion = "Prod1", Precio = 10 },
            new() { ProductoId = 2, Descripcion = "Prod2", Precio = 100 },
            new() { ProductoId = 3, Descripcion = "Prod3", Precio = 1000 }
        };
        return resultado;
    }
    
    public class Producto{
        public int? ProductoId { get; set; }
        public string? Descripcion { get; set; }
        public decimal? Precio { get; set; }
    }
}
