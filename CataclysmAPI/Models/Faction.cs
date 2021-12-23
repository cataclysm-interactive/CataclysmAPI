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
        [Required]
        public long id { get; set; }
        [Required]
        [Column("factionName")]
        public string FactionName { get; set; }
        [Required]
        [Column("factionIncome")]
        public int? FactionIncome { get; set; }
        [Required]
        [Column("factionMembers")]
        public string FactionMembers { get; set; }
        [Required]
        [Column("factionLandClaim")]
        public string FactionLandClaim { get; set; }
    }
}
