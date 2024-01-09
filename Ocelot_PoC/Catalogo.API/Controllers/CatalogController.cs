using Microsoft.AspNetCore.Mvc;

namespace Catalogo.API.Controllers;

[ApiController]
[Route("api/[catalog]")]
public class CatalogController : ControllerBase
{
    //GET api/values
    [HttpGet("GetProductos")]
    public ActionResult<> GetProductos(){
        return resultado;
    }
    
    public class Producto{
        public int? ProductoId { get; set; }
        public string? Descripcion { get; set; }
        public decimal? Precio { get; set; }
    }
}
