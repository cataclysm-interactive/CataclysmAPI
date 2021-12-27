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
        [Column("factionName")]
        public string FactionName { get; set; }
        [Column("factionIncome")]
        public int? FactionIncome { get; set; }
        [Column("factionMembers")]
        public string FactionMembers { get; set; }
        [Column("factionLandClaim")]
        public string FactionLandClaim { get; set; }
        [Column("factionLogo")]
        public string FactionLogo { get; set; }

        public int attack { get; set; }
        public int defense { get; set; }
        public int utility { get; set; }
    }
}
