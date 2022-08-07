//----------------------------------------------------------------------- 
// Copyright (c) 2019 All rights reserved.
// </copyright>
// <author>Jorge Pertuz Egea/Jpertuz</author>
// <date>Agosto 2022</date>
//-----------------------------------------------------------------------

namespace Services.DTO.Request
{
    public class LoginDto
    {
        public string UserName { get; set; }
        public string? Password { get; set; }
        public bool IsLogued { get; set; }
        public string? Token { get; set; }
    }
}
