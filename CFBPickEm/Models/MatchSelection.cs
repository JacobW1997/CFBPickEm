using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CFBPickEm.Models
{
    [Table("MatchSelection")]
    public partial class MatchSelection
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [StringLength(64)]
        [Unicode(false)]
        public string? WinningTeamName { get; set; }
        [StringLength(64)]
        [Unicode(false)]
        public string? LosingTeamName { get; set; }
        public bool? WinningPrediction { get; set; }
        [Column("UserID")]
        public int? UserId { get; set; }
    }
}
