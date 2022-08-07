//----------------------------------------------------------------------- 
// Copyright (c) 2019 All rights reserved.
// </copyright>
// <author>Jorge Pertuz Egea/Jpertuz</author>
// <date>Agosto 2022</date>
//-----------------------------------------------------------------------

namespace PruebaApi.Models
{
    public class RequestSalaryDto
    {
        public int OfficeId { get; set; }
        public int Grade { get; set; }
        public int Position { get; set; }
    }
}
