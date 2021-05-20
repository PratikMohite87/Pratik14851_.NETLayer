using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstAssignment
{
    [Table("Review")]
    public class Review
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReviewId { set; get; }

        [ForeignKey("BookId")]
        public Book Book { set; get; }

        [ForeignKey("MemberId")]
        public Member Member { set; get; }

        [Column(TypeName = "varchar(20)")]
        public string ReviewText { set; get; }
    }
}
