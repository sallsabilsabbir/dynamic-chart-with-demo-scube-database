using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    [Keyless]
    [Table("wether_data")]
    public partial class WetherDatum
    {
        [Column("ID", TypeName = "decimal(12, 0)")]
        public decimal Id { get; set; }
        [Column("Cum_north")]
        public float? CumNorth { get; set; }
        [Column("Cum_south")]
        public float? CumSouth { get; set; }
        [Column("Cum_east")]
        public float? CumEast { get; set; }
        [Column("Cum_west")]
        public float? CumWest { get; set; }
        [Column("Cum_south15")]
        public float? CumSouth15 { get; set; }
        [Column("Cum_connect")]
        public float? CumConnect { get; set; }
        [Column("Cum_sum_correct")]
        public float? CumSumCorrect { get; set; }
        [Column("AC_kwh_norm")]
        public float? AcKwhNorm { get; set; }
    }
}
