using Microsoft.AspNetCore.Mvc;

namespace Orden.API.Controllers;

[ApiController]
[Route("api/[Ordenes]")]
public class OrdenController : ControllerBase
{
    [HttpGet("GetOrdenPorClienteId/{id}")]
        public ActionResult<List<Orden>> GetOrdenPorClienteId(int id)
        {
            return ListaOrden().Where(p => p.ClienteId == id).ToList();           
        }
        [HttpPost("AddOrder")]
        public ActionResult<List<Orden>> AddOrden([FromBody] Orden orden)
        {           
            var resultado = ListaOrden();
            resultado.Add(orden);
            return resultado.ToList();
        }
        private IList<Orden> ListaOrden(){
 
            var resultado = new List<Orden>
            {
                new() { OrdenId = 1, ClienteId = 1, ClienteNombre = "Cliente 1" },
                new() { OrdenId = 2, ClienteId = 2, ClienteNombre = "Cliente 2" },
                new() { OrdenId = 3, ClienteId = 3, ClienteNombre = "Cliente 3" }
            };
 
            return resultado;
        }
 
}
public class Orden{
        public int? OrdenId { get; set; }
        public int? ClienteId { get; set; }
        public string? ClienteNombre { get; set; }
    }
