using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CataclysmAPI.Models
{
    public partial class User
    {
        [Key]
        [Required]
        public long id { get; set; }
        [Column("token")]
        [Required]
        public int Token { get; set; }
        [Column("date", TypeName = "datetime")]
        public DateTime Date { get; set; }
        [Column("customRole")]
        public byte CustomRole { get; set; }
    }
}
