using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstApp
{
    [Table("Product")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductId { set; get; }
        public string ProductName { set; get; }
        [ForeignKey("CategoryId")]
        public Category ProductCategory { set; get; }
        [Column(TypeName ="numeric(10,2)")]
        public decimal? ProductPrice { set; get; }
    }
}
