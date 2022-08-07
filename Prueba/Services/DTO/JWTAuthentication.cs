//----------------------------------------------------------------------- 
// Copyright (c) 2019 All rights reserved.
// </copyright>
// <author>Jorge Pertuz Egea/Jpertuz</author>
// <date>Agosto 2022</date>
//-----------------------------------------------------------------------

namespace Services.DTO
{
    public class JWTAuthentication
    {
        public int ExpirationInMinutes { get; set; }
        public string Secret { get; set; }

    }
}
