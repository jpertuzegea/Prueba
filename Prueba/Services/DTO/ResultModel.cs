﻿//----------------------------------------------------------------------- 
// Copyright (c) 2019 All rights reserved.
// </copyright>
// <author>Jorge Pertuz Egea/Jpertuz</author>
// <date>Agosto 2022</date>
//-----------------------------------------------------------------------

namespace Services.DTO
{
    public class ResultModel
    {
        public bool HasError { get; set; }
        public string? Messages { get; set; }
        public object? Data { get; set; }

    }

}
