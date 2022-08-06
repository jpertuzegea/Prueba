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
