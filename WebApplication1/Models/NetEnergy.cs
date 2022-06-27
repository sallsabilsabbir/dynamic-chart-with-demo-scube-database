using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    [Keyless]
    [Table("net_energy")]
    public partial class NetEnergy
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
        [Column("Net_Energy")]
        [StringLength(15)]
        [Unicode(false)]
        public string? NetEnergy1 { get; set; }
        [Column("E_SD1")]
        [StringLength(15)]
        [Unicode(false)]
        public string? ESd1 { get; set; }
        [Column("E_SD2")]
        [StringLength(15)]
        [Unicode(false)]
        public string? ESd2 { get; set; }
        [Column("E_SD34")]
        [StringLength(15)]
        [Unicode(false)]
        public string? ESd34 { get; set; }
        [Column("E_SD5")]
        [StringLength(15)]
        [Unicode(false)]
        public string? ESd5 { get; set; }
        [Column("E_SD6")]
        [StringLength(15)]
        [Unicode(false)]
        public string? ESd6 { get; set; }
        [Column("E_SD7")]
        [StringLength(15)]
        [Unicode(false)]
        public string? ESd7 { get; set; }
        [Column("E_SD8")]
        [StringLength(15)]
        [Unicode(false)]
        public string? ESd8 { get; set; }
        [Column("E_SD10")]
        [StringLength(15)]
        [Unicode(false)]
        public string? ESd10 { get; set; }
        [Column("E_SD11")]
        [StringLength(15)]
        [Unicode(false)]
        public string? ESd11 { get; set; }
        [Column("E_SD12")]
        [StringLength(15)]
        [Unicode(false)]
        public string? ESd12 { get; set; }
        [Column("T_Import")]
        [StringLength(15)]
        [Unicode(false)]
        public string? TImport { get; set; }
        [Column("T_Export")]
        [StringLength(15)]
        [Unicode(false)]
        public string? TExport { get; set; }
    }
}
