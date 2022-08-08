//----------------------------------------------------------------------- 
// Copyright (c) 2019 All rights reserved.
// </copyright>
// <author>Jorge Pertuz Egea/Jpertuz</author>
// <date>Agosto 2022</date>
//-----------------------------------------------------------------------

using DataAccess.Entitys;
using Services.DTO.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IPositionServicesDomain
    {
        Task<POSITION> GetPositionByPositionId(int id);

        Task<ResultDto> SelectPosition();
        

    }
}
