namespace PerpustakaanDataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Anggota")]
    public partial class Anggota
    {
        public Anggota()
        {
            Peminjaman = new HashSet<Peminjaman>();
            Pengembalian = new HashSet<Pengembalian>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Key]
        [StringLength(10)]
        public string KodeAnggota { get; set; }

        [Required]
        [StringLength(100)]
        public string Nama { get; set; }

        [Required]
        [StringLength(500)]
        public string Alamat { get; set; }

        [Required]
        [StringLength(30)]
        public string Email { get; set; }

        [Required]
        [StringLength(15)]
        public string Telepon { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime? Created { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }

        public DateTime? Modified { get; set; }

        public virtual Pendaftaran Pendaftaran { get; set; }

        public virtual ICollection<Peminjaman> Peminjaman { get; set; }

        public virtual ICollection<Pengembalian> Pengembalian { get; set; }
    }
}
