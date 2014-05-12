using System.ComponentModel.DataAnnotations;
namespace Entities
{
    public  abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
