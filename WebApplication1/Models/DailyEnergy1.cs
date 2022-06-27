using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    [Table("daily_Energy1")]
    public partial class DailyEnergy1
    {
        [Column("nDate")]
        [StringLength(50)]
        [Unicode(false)]
        public string? NDate { get; set; }
        [Column("nDay")]
        public int? NDay { get; set; }
        [Column("E_SD1")]
        public float? ESd1 { get; set; }
        [Column("E_SD2")]
        public float? ESd2 { get; set; }
        [Column("E_SD34")]
        public float? ESd34 { get; set; }
        [Column("E_SD5")]
        public float? ESd5 { get; set; }
        [Column("E_SD6")]
        public float? ESd6 { get; set; }
        [Column("E_SD7")]
        public float? ESd7 { get; set; }
        [Column("E_SD8")]
        public float? ESd8 { get; set; }
        [Column("E_SD10")]
        public float? ESd10 { get; set; }
        [Column("E_SD11")]
        public float? ESd11 { get; set; }
        [Column("E_SD12")]
        public float? ESd12 { get; set; }
        [Column("Import_today")]
        public float? ImportToday { get; set; }
        [Column("Export_today")]
        public float? ExportToday { get; set; }
        [Column("T_Import")]
        public float? TImport { get; set; }
        [Column("T_Export")]
        public float? TExport { get; set; }
        [Key]
        [Column("ID")]
        public int Id { get; set; }
    }
}
