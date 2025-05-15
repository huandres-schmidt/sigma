﻿using Microsoft.AspNetCore.Mvc;
using Sigma.Application.Interfaces;
using Sigma.Domain.Dtos;
using Sigma.Domain.Entities;
using System.Diagnostics.Contracts;

namespace Sigma.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjetoController : ControllerBase
    {
        private readonly IProjetoService _projetoService;

        public ProjetoController(IProjetoService projetoService)
        {
            _projetoService = projetoService;
        }

        [HttpPost]
        [Route("inserir")]
        public async Task<IActionResult> Inserir([FromBody] ProjetoNovoDto model)
        {
            return new JsonResult(await _projetoService.Inserir(model));
        }

        [HttpGet]
        [Route("get")]
        public async Task<List<Projeto>> getAll() 
        {
            return await _projetoService.getAll();
        }
    }
}
