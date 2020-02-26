using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GestaoDeFrota.Application.Interface;
using GestaoDeFrota.Domain.Entities;
using GestaoDeFrota.MVC.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GestaoDeFrota.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculosController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IVeiculoAppService _veiculoAppService;
        private readonly IOrigemAppService _origemAppService;
        private readonly ICambioAppService _cambioAppService;
        private readonly ICategoriaAppService _categoriaAppService;
        private readonly IClasseAppService _classeAppService;
        private readonly ICombustivelAppService _combustivelAppService;
        private readonly IModeloAppService _modeloAppService;
        private readonly IMotorAppService _motorAppService;
        private readonly IFabricanteAppService _fabricanteAppService;
        private readonly IImagemAppService _imagemAppService;

        private readonly IHostingEnvironment _env;

        public VeiculosController(IMapper mapper, IVeiculoAppService veiculo, ICambioAppService cambio, IOrigemAppService origem,
            ICategoriaAppService categoria, IClasseAppService classe, ICombustivelAppService combustivel, IModeloAppService modelo,
            IMotorAppService motor, IFabricanteAppService fabricante, IImagemAppService imagem, IHostingEnvironment env)
        {
            _mapper = mapper;
            _cambioAppService = cambio;
            _veiculoAppService = veiculo;
            _origemAppService = origem;
            _categoriaAppService = categoria;
            _classeAppService = classe;
            _combustivelAppService = combustivel;
            _modeloAppService = modelo;
            _motorAppService = motor;
            _fabricanteAppService = fabricante;
            _imagemAppService = imagem;
            _env = env;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var veiculoViewModel = _mapper.Map<IEnumerable<Veiculo>, IEnumerable<VeiculoViewModel>>(_veiculoAppService.Veiculos());
                return Ok(veiculoViewModel);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Banco de Dados Falhou");
            }
        }

        [HttpGet("{Id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var veiculo = _veiculoAppService.Veiculo(id);
                var veiculoViewModel = _mapper.Map<Veiculo, VeiculoViewModel>(veiculo);
                return Ok(veiculoViewModel);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Banco de Dados Falhou");
            }
        }
    }
}