using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace APP.MODELS
{
    [Table("SinhVien")]
    public class SinhViens
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }
        [Column("TenSinhVien")]
        public string tenSinhVien { get; set; }
        [Column("GioiTinh")]
        public int? gioiTinh { get; set; }
        [Column("NgaySinh")]
        public string? ngaySinh { get; set; }
        [Column("QueQuan")]
        public string? queQuan { get; set; }
        [Column("MaLop")]
        public int? maLop { get; set; }
    }
}
