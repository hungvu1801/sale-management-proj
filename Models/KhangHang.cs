namespace QuanLyBanHang.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhangHang")]
    public partial class KhangHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhangHang()
        {
            HoaDonBanHangs = new HashSet<HoaDonBanHang>();
        }

        [Key]
        [StringLength(10)]
        public string MaKH { get; set; }

        [Required]
        [StringLength(50)]
        public string TenKH { get; set; }

        [Required]
        [StringLength(20)]
        public string SDT { get; set; }

        [Required]
        [StringLength(200)]
        public string DiaCHi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDonBanHang> HoaDonBanHangs { get; set; }
    }
}
