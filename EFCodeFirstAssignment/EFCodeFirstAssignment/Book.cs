using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstAssignment
{
    [Table("Book")]
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BookId { set; get; }

        [Column(TypeName ="varchar(20)")]
        public string BookName { set; get; }

        [ForeignKey("PublisherId")]
        public Publisher Publisher { set; get; }
    }
}
