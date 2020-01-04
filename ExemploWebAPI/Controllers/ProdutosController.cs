using ExemploWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExemploWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private static List<Produto> produtos = new List<Produto>();

        [HttpGet]
        public List<Produto> Get()
        {
            return produtos;
        }
        public void Post (string nome, string quantidade, string preco )
        {

            produtos.Add(new Produto(nome, quantidade, preco));
        }
      }
}