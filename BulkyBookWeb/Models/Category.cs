using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyBookWeb.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name  { get; set; }
        [DisplayName ("Display Order")]
        [Range(1,100,ErrorMessage ="Enter Between 1-100 orders Only!")]
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;

    }
}
