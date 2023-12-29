using ApiDani.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ApiDani.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase // Reemplaza "cliente" por "controller"
    {
        [HttpGet]
        [Route("listar")]
        public dynamic listarCliente()
        {
            List<Cliente> clientes = new List<Cliente>
            {
                new Cliente
                {
                    id = "1",
                    nombre = "Dani",
                    edad = "20",
                    correo = "Dani@gmail.com"
                },
                new Cliente
                {
                    id = "2",
                    nombre = "Marce",
                    edad = "21",
                    correo = "Marce@gmail.com"
                }
            };

            return clientes;
        }

        //[HttpPost]
        //[Route("guardar")]
        //public dynamic guardarCliente()
        //{

        //}
    }
}