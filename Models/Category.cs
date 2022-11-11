using System.ComponentModel.DataAnnotations;

namespace MomoWebApplication.Models
{
    public class Category
    {
        [Key] // Makes Primary Key
        public int Id { get; set; }
        [Required] // Makes Input Mandatory 
        public String Item { get; set; }
        public int Amount { get; set; }

        public double Cost { get; set; }

    }
}
