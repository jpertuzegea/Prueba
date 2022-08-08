//----------------------------------------------------------------------- 
// Copyright (c) 2019 All rights reserved.
// </copyright>
// <author>Jorge Pertuz Egea/Jpertuz</author>
// <date>Agosto 2022</date>
//-----------------------------------------------------------------------

using DataAccess.Entitys;
using DataAccess.Interfaces;
using Microsoft.Extensions.Logging;
using Services.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Services
{
    public class DivisionServicesDomain : IDivisionServicesDomain
    {

        private readonly IUnitOfWork unitofwork;
        private readonly ILogger<DivisionServicesDomain> logger;

        public DivisionServicesDomain(IUnitOfWork _unitofwork, ILogger<DivisionServicesDomain> logger)
        {
            this.unitofwork = _unitofwork;
            this.logger = logger;
        }


        public async Task<DIVISION> GetDivisionByDivisionId(int id)
        {
            try
            {
                var divi = (await unitofwork.GetRepository<DIVISION>().Get(x => x.DivisionId == id)).FirstOrDefault();
                return divi;
            }
            catch (Exception Error)
            {
                return null;
            } 
        }

    }
}
