using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public partial class ChartsTable
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string PanelName { get; set; } = null!;
        public int PanelEnergy { get; set; }
    }
}
