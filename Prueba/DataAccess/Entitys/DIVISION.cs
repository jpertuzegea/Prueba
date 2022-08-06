using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entitys
{
    public class DIVISION
    {
        [Key]
        public int? DivisionId { get; set; }
        public string Name { get; set; }
    }
}
