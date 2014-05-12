using System.ComponentModel.DataAnnotations;
namespace Entities
{
    public class Bank : BaseEntity
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
    }
}
