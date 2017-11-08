namespace PerpustakaanDataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DetailPeminjaman")]
    public partial class DetailPeminjaman
    {
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string KodePeminjaman { get; set; }

        [Required]
        [StringLength(10)]
        public string KodeBuku { get; set; }

        [Required]
        [StringLength(100)]
        public string Nama { get; set; }

        public DateTime TglKembali { get; set; }

        [Required]
        [StringLength(20)]
        public string StatusKembali { get; set; }

        [Required]
        [StringLength(50)]
        public string JudulBuku { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime? Created { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }

        public DateTime? Modified { get; set; }

        public virtual Buku Buku { get; set; }

        public virtual Peminjaman Peminjaman { get; set; }
    }
}
