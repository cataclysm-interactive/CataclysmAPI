using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace CataclysmAPI.Models
{
    public partial class User
    {
        [Key]
        public int Id { get; set; }
        [Column("token")]
        public int Token { get; set; }
    }
}
