using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstAssignment
{
    [Table("Member")]
    public class Member
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MemberId { set; get; }

        [Column(TypeName ="varchar(20)")]
        public string MemberName { set; get; }
    }
}
