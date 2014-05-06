using System.ComponentModel.DataAnnotations;
namespace Entities
{
    public class Bank
    {
        [Key]
        public int BankId { get; set; }

        [Required]
        [MaxLength(30)]
        public string Naam { get; set; }
    }
}
