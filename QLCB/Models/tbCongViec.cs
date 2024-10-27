using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace QLCB.Models
{
    [Table("tbCongViec")]
    public partial class tbCongViec
    {
        [Key]

        public int IdCongViec { get; set; }
        public string TenCongViec { get; set; }
        public DateTime NgayBD { get; set; }
        public DateTime NgayKT { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}
