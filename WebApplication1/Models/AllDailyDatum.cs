using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    [Keyless]
    [Table("all_daily_data")]
    public partial class AllDailyDatum
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("nMinute")]
        public int? NMinute { get; set; }
        [Column("nHour")]
        public int? NHour { get; set; }
        [Column("nDay")]
        public int? NDay { get; set; }
        [Column("nMonth")]
        public int? NMonth { get; set; }
        [Column("nYear")]
        public int? NYear { get; set; }
        [Column("total_E", TypeName = "decimal(12, 0)")]
        public decimal? TotalE { get; set; }
        [Column("daily_E", TypeName = "decimal(12, 0)")]
        public decimal? DailyE { get; set; }
        [Column("AC_pow_max", TypeName = "decimal(12, 0)")]
        public decimal? AcPowMax { get; set; }
        [Column("DC_pow_max", TypeName = "decimal(12, 0)")]
        public decimal? DcPowMax { get; set; }
        [Column("Specific_E", TypeName = "decimal(12, 2)")]
        public decimal? SpecificE { get; set; }
        [Column("today_PR", TypeName = "decimal(2, 2)")]
        public decimal? TodayPr { get; set; }
        [Column("total_terif", TypeName = "decimal(12, 0)")]
        public decimal? TotalTerif { get; set; }
        [Column("E_SD1", TypeName = "decimal(12, 0)")]
        public decimal? ESd1 { get; set; }
        [Column("E_SD2", TypeName = "decimal(12, 0)")]
        public decimal? ESd2 { get; set; }
        [Column("E_SD34", TypeName = "decimal(12, 0)")]
        public decimal? ESd34 { get; set; }
        [Column("E_SD5", TypeName = "decimal(12, 0)")]
        public decimal? ESd5 { get; set; }
        [Column("E_SD6", TypeName = "decimal(12, 0)")]
        public decimal? ESd6 { get; set; }
        [Column("E_SD7", TypeName = "decimal(12, 0)")]
        public decimal? ESd7 { get; set; }
        [Column("E_SD8", TypeName = "decimal(12, 0)")]
        public decimal? ESd8 { get; set; }
        [Column("E_SD10", TypeName = "decimal(12, 0)")]
        public decimal? ESd10 { get; set; }
        [Column("E_SD11", TypeName = "decimal(12, 0)")]
        public decimal? ESd11 { get; set; }
        [Column("E_SD12", TypeName = "decimal(12, 0)")]
        public decimal? ESd12 { get; set; }
        [Column("Import_today", TypeName = "decimal(12, 0)")]
        public decimal? ImportToday { get; set; }
        [Column("Export_today", TypeName = "decimal(12, 0)")]
        public decimal? ExportToday { get; set; }
        [Column("T_Import", TypeName = "decimal(12, 0)")]
        public decimal? TImport { get; set; }
        [Column("T_Export", TypeName = "decimal(12, 0)")]
        public decimal? TExport { get; set; }
    }
}
