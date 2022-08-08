//----------------------------------------------------------------------- 
// Copyright (c) 2019 All rights reserved.
// </copyright>
// <author>Jorge Pertuz Egea/Jpertuz</author>
// <date>Agosto 2022</date>
//-----------------------------------------------------------------------

using DataAccess.Entitys;
using DataAccess.Interfaces;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Services.DTO.Response;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Services
{
    public class PositionServicesDomain : IPositionServicesDomain
    {

        private readonly IUnitOfWork unitofwork;
        private readonly ILogger<PositionServicesDomain> logger;

        public PositionServicesDomain(IUnitOfWork _unitofwork, ILogger<PositionServicesDomain> logger)
        {
            this.unitofwork = _unitofwork;
            this.logger = logger;
        }


        public async Task<POSITION> GetPositionByPositionId(int id)
        {
            try
            {
                var divi = (await unitofwork.GetRepository<POSITION>().Get(x => x.PositionId == id)).FirstOrDefault();
                return divi;
            }
            catch (Exception Error)
            {
                return null;
            }
        }


        public async Task<ResultDto> SelectPosition()
        {
            ResultDto ResultDto = new ResultDto();
            IEnumerable<POSITION> List = await unitofwork.GetRepository<POSITION>().Get();

            var select = List.Select(x => new { Value = x.PositionId, Text = x.Name }).ToList();

            ResultDto.HasError = false;
            ResultDto.Messages = "Listado Posiciones Con Exito";
            ResultDto.Data = new SelectList(select, "Value", "Text");

            return ResultDto;
        }
         

    }
}
