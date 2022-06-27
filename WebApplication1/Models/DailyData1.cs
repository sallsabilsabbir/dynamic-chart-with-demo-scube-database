using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    [Keyless]
    [Table("daily_data1")]
    public partial class DailyData1
    {
        [Column("nDate")]
        [StringLength(50)]
        [Unicode(false)]
        public string? NDate { get; set; }
        [Column("nDay")]
        public int? NDay { get; set; }
        [Column("total_E")]
        public float? TotalE { get; set; }
        [Column("daily_E")]
        public float? DailyE { get; set; }
        [Column("AC_pow_max")]
        public float? AcPowMax { get; set; }
        [Column("DC_pow_max")]
        public float? DcPowMax { get; set; }
        [Column("specific_E")]
        public float? SpecificE { get; set; }
        [Column("today_PR")]
        public float? TodayPr { get; set; }
        [Column("total_terif")]
        public float? TotalTerif { get; set; }
        [Column("ID")]
        public int Id { get; set; }
    }
}
