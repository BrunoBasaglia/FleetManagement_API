using GestaoDeFrota.Application.Interface;
using GestaoDeFrota.Domain.Entities;
using GestaoDeFrota.Domain.Interfaces.Services;

namespace GestaoDeFrota.Application.Services
{
    public class ClasseAppService : AppServiceBase<Classe>, IClasseAppService
    {
        public IClasseService _classeService;

        public ClasseAppService(IClasseService classeService) : base(classeService)
        {
            _classeService = classeService;
        }
    }
}
