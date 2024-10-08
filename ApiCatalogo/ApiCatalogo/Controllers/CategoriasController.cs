﻿using ApiCatalogo.Context;
using ApiCatalogo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace ApiCatalogo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        private readonly AppDbContext? _context;

        public AppDbContext? Context => _context;


        [HttpGet("produtos")]
        public ActionResult<IEnumerable<Categoria>> GetCategoriasProdutos() 
        {
            return _context.Categorias.Include(p =>  p.Produtos).ToList();
        }

        [HttpGet]
        public ActionResult<IEnumerable<Categoria>> Get() => _context.Categorias.Include(p => p.Produtos)
                                    .Where(c => c.CategoriaId <= 10).ToList();

        [HttpGet("{id:int}", Name = "ObterCategoria")]
        public ActionResult<Categoria> Get(int id)
        {
            var categoria = _context?.Categorias?.AsNoTracking().FirstOrDefault(p => p.CategoriaId == id);
            if (categoria == null)
            {
                return NotFound("Categoria não encontrada ! ");
            }
            return categoria;
        }

        [HttpPost]
        public ActionResult Post(Categoria categoria)
        {
            if (categoria is null)
                return BadRequest();

            _context?.Categorias?.Add(categoria);
            _context?.SaveChanges();

            return new CreatedAtRouteResult("ObterProduto",
                new { id = categoria?.CategoriaId }, categoria);
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Categoria categoria)
        {
            if (id != categoria.CategoriaId)
                return BadRequest();

            _context.Entry(categoria).State = EntityState.Modified;
            _context?.SaveChanges();

            return Ok(categoria);
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            var categoria = _context?.Categorias?.FirstOrDefault(p => p.CategoriaId == id);

            if (categoria is null)
                return NotFound("Produto não encontrado");

            _context?.Categorias?.Remove(categoria);
            _context?.SaveChanges();

            return Ok(categoria);
        }
    }
}
