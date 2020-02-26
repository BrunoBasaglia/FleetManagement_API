using GestaoDeFrota.Application.Interface;
using GestaoDeFrota.Domain.Entities;
using GestaoDeFrota.Domain.Interfaces.Services;

namespace GestaoDeFrota.Application.Services
{
    public class ModeloAppService : AppServiceBase<Modelo>, IModeloAppService
    {
        public IModeloService _modeloService;

        public ModeloAppService(IModeloService modeloService) : base(modeloService)
        {
            _modeloService = modeloService;
        }
    }
}
