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
        public long Id { get; set; }
        [Column("token")]
        public int Token { get; set; }
        [Column("date", TypeName = "date")]
        public DateTime Date { get; set; }
        [Column("customRole")]
        public byte CustomRole { get; set; }
    }
}
