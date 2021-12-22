using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CataclysmAPI.Models
{
    public partial class Store
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("storeName")]
        [StringLength(20)]
        public string StoreName { get; set; }
        [Column("storeIncome")]
        public int? StoreIncome { get; set; }
    }
}
