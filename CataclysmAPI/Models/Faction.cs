using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CataclysmAPI.Models
{
    public partial class Faction
    {
        [Key]
        [Column("id")]
        public long id { get; set; }
        [Column("factionName")]
        [StringLength(50)]
        public string FactionName { get; set; }
        [Column("factionIncome")]
        public int? FactionIncome { get; set; }
        [Required]
        [Column("factionMembers")]
        [StringLength(1000)]
        public string FactionMembers { get; set; }
        [Required]
        [Column("factionLandClaim")]
        [StringLength(1000)]
        public string FactionLandClaim { get; set; }
    }
}
