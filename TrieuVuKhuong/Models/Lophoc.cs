﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrieuVuKhuong.Models
{
    [Table("Lophoc")]
    public class Lophoc
    {
        [Key]
        public int MaLop { get; set; }

        [Required]
        [StringLength(50)]
        public string TenLop { get; set; }
    }
}