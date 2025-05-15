﻿using AutoMapper;
using Sigma.Application.Interfaces;
using Sigma.Domain.Dtos;
using Sigma.Domain.Entities;
using Sigma.Domain.Interfaces.Repositories;

namespace Sigma.Application.Services
{
    public class ProjetoService : IProjetoService
    {
        private readonly IMapper _mapper;
        private readonly IProjetoRepository _projetoRepository;
        public ProjetoService(IMapper mapper, IProjetoRepository projetoRepository)
        {
            _mapper = mapper;
            _projetoRepository = projetoRepository;
        }

        public async Task<bool> Inserir(ProjetoNovoDto model)
        {
            return await _projetoRepository.Inserir(_mapper.Map<Projeto>(model));
        }

        public async Task<List<Projeto>> getAll() 
        {
            return await _projetoRepository.getAll();
        }
    }
}
