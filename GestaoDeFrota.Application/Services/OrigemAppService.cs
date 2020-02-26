using GestaoDeFrota.Application.Interface;
using GestaoDeFrota.Domain.Entities;
using GestaoDeFrota.Domain.Interfaces.Services;

namespace GestaoDeFrota.Application.Services
{
    public class OrigemAppService : AppServiceBase<Origem>, IOrigemAppService
    {
        public IOrigemService _origemService;

        public OrigemAppService(IOrigemService origemService) : base(origemService)
        {
            _origemService = origemService;
        }
    }
}
