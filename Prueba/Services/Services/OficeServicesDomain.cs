using DataAccess.Entitys;
using DataAccess.Interfaces;
using Microsoft.Extensions.Logging;
using Services.DTO.Response;
using Services.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Services
{
    public class OficeServicesDomain : IOficeServicesDomain
    {

        private readonly IUnitOfWork unitofwork;
        private readonly ILogger<OficeServicesDomain> logger;

        public OficeServicesDomain(IUnitOfWork _unitofwork, ILogger<OficeServicesDomain> logger)
        {
            this.unitofwork = _unitofwork;
            this.logger = logger;
        }


        public async Task<ResultDto> SelectOfices()
        {
            ResultDto ResultDto = new ResultDto();
            IEnumerable<OFFICE> List = await unitofwork.GetRepository<OFFICE>().Get();

            var select = List.Select(x => new { Value = x.OfficeId, Text = x.Name }).ToList();

            ResultDto.HasError = false;
            ResultDto.Messages = "Listado Oficinas Con Exito";
            ResultDto.Data = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(select, "Value", "Text");

            return ResultDto;
        }

    }
}
