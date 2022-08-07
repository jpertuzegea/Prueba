//----------------------------------------------------------------------- 
// Copyright (c) 2019 All rights reserved.
// </copyright>
// <author>Jorge Pertuz Egea/Jpertuz</author>
// <date>Agosto 2022</date>
//-----------------------------------------------------------------------


using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entitys
{
    public class OFFICE
    {
        [Key]
        public int? OfficeId { get; set; }
        public string Name { get; set; }

    }
}
