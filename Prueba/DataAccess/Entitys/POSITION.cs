using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entitys
{
    public class POSITION
    {
        [Key]
        public int? PositionId { get; set; }
        public string Name { get; set; }
    }
}
