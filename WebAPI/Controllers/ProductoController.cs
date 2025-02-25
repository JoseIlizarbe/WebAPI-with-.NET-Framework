using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class ProductoController : ApiController
    {
        static Dictionary<int, Producto> productos = new Dictionary<int, Producto>();


        //GET api/producto
        public IEnumerable<Producto> Get()
        {
            return new List<Producto>(productos.Values);
        }

        //GET api/Producto/id
        public Producto Get(int id)
        {
            Producto encontrado;
            productos.TryGetValue(id, out encontrado);
            return encontrado;
        }

        //POST api/producto
        public bool Post([FromBody] Producto producto)
        {
            Producto encontrado;
            productos.TryGetValue(producto.IdProducto, out encontrado);
            if (encontrado == null)
            {
                productos.Add(producto.IdProducto, producto);
                return true;
            }
            else
            {
                return false;
            }
        }

        //DELETE api/Producto/id
        public bool Delete(int id)
        {
            return productos.Remove(id);
        }
    }
}
