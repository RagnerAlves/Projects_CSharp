using APICatalogo.Context;
using APICatalogo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APICatalogo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CategoriaController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("produtos")]

        public ActionResult<IEnumerable<Categoria>> GetCategoriasProdutos()
        {
            return _context.Categorias.Include(p => p.Produtos).ToList();
        }

        [HttpGet]
        
        public ActionResult<IEnumerable<Categoria>> Get()
        {
            return _context.Categorias.ToList();
        }

        [HttpGet("{id:int}", Name = "ObterCategoria")]

        public ActionResult<Categoria> Get(int id)
        {
            var categoria = _context.Categorias.FirstOrDefault(p => p.CategoriaID == id);

            if(categoria == null)
            {
                return NotFound("Categoria não encontrada.");
            }

            return Ok(categoria);
        }


        [HttpPost]
        public ActionResult Post(Produto categoria)
        {
            if (categoria is null)
                return BadRequest();

            _context.Produtos?.Add(categoria);
            _context.SaveChanges();

            return new CreatedAtRouteResult("ObterCategoria", 
                new { id = categoria.ProdutoId }, categoria);
        }


        [HttpPut("{id:int}")]

        public ActionResult Put(int id, Produto categoria)
        {
            if (id != categoria.ProdutoId)
            {
                return BadRequest();
            }

            _context.Entry(categoria).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(categoria);
        }

        [HttpDelete("{id:int}")]

        public ActionResult Delete(int id)
        {
            var categoria = _context.Categorias?.FirstOrDefault(p => p.CategoriaID == id);

            if (categoria is null)
            {
                return NotFound("Cattegoria não localizado.");
            }

            _context.Remove(categoria);
            _context.SaveChanges();

            return Ok(categoria);
        }
    }
}
