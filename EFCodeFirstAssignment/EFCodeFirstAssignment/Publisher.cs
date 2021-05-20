using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstAssignment
{
    [Table("Publisher")]
    public class Publisher
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PublisherId { set; get; }

        [Column(TypeName ="varchar(20)")]
        public string PublisherName { set; get; }

        [Column(TypeName ="varchar(20)")]
        public string PublisherCountry { set; get; }

        public ICollection<Book> PublisherBooks { set; get; }
    }
}
