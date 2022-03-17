using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CataclysmAPI.Models
{
    public partial class Map
    {
        [Key]
        [Required]
        [Column("plotNum")]
        public int plotNum { get; set; }

        [Column("plotOwner")]
        public long plotOwner { get; set; }
        [Column("plotType")]
        [Required]
        public byte plotType { get; set; }
    }
}
