﻿using ApiCatalogo.Context;
using ApiCatalogo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiCatalogo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly AppDbContext? _context;

        public ProdutosController(AppDbContext contex) 
        {
            _context = contex;
        }

        [HttpGet("primeiro")]
        public ActionResult<Produto> GetPrimeiro()
        {
            var produto = _context?.Produtos?.FirstOrDefault();
            if (produto is null)
            {
                return NotFound();
            }
            return produto;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Produto>> Get() 
        {
            var produtos = _context?.Produtos?.AsNoTracking().ToList();
            if(produtos is null) 
            {
                return NotFound();
            }
            return produtos;
        }

        [HttpGet("{id}/{param2}", Name="ObterProduto")]
        public ActionResult<Produto> Get(int id, string param2)
        {
            var parametro = param2;

            var produto = _context?.Produtos?.AsNoTracking().FirstOrDefault(p => p.ProdutoId == id);
            if (produto is null)
            {
                return NotFound("Produto não encontrado ! ");
            }
            return produto;
        }

        [HttpPost]
        public ActionResult Post(Produto produto)
        {   
            if(produto is null) 
                return BadRequest();             

            _context?.Produtos?.Add(produto);
            _context?.SaveChanges();

           return new CreatedAtRouteResult("ObterProduto",
               new {id = produto?.ProdutoId}, produto);
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Produto produto)
        {
            if (id != produto.ProdutoId) 
                return BadRequest();

            _context.Entry(produto).State = EntityState.Modified;
            _context?.SaveChanges();

            return Ok(produto);
        }

        [HttpDelete]
        public ActionResult Delete(int id) 
        {
            var produto = _context?.Produtos?.FirstOrDefault(p => p.ProdutoId == id);

            if (produto is null)
                return NotFound("Produto não encontrado");

            _context?.Produtos?.Remove(produto);
            _context?.SaveChanges();

            return Ok(produto);
        }
    }
}
