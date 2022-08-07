//----------------------------------------------------------------------- 
// Copyright (c) 2019 All rights reserved.
// </copyright>
// <author>Jorge Pertuz Egea/Jpertuz</author>
// <date>Agosto 2022</date>
//-----------------------------------------------------------------------

using Services.DTO.Request;
using Services.DTO.Response;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface ISecurityServicesDomain
    { 
        Task<ResultDto> LogIn(LoginDto LoginDto);

    }
}
