using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CFBPickEm.Models
{
    public partial class Result
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        public int? Wins { get; set; }
        public int? Losses { get; set; }
        public int? Ties { get; set; }
        public double? Score { get; set; }
        [Column("UserID")]
        public int? UserId { get; set; }
    }
}
