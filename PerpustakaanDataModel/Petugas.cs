namespace PerpustakaanDataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Petugas
    {
        public Petugas()
        {
            DonasiBuku = new HashSet<DonasiBuku>();
            Pembelian = new HashSet<Pembelian>();
            Peminjaman = new HashSet<Peminjaman>();
            Pendaftaran = new HashSet<Pendaftaran>();
            Pengembalian = new HashSet<Pengembalian>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Key]
        [StringLength(10)]
        public string KodePetugas { get; set; }

        [Required]
        [StringLength(10)]
        public string Nama { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime? Created { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }

        public DateTime? Modified { get; set; }

        public virtual ICollection<DonasiBuku> DonasiBuku { get; set; }

        public virtual ICollection<Pembelian> Pembelian { get; set; }

        public virtual ICollection<Peminjaman> Peminjaman { get; set; }

        public virtual ICollection<Pendaftaran> Pendaftaran { get; set; }

        public virtual ICollection<Pengembalian> Pengembalian { get; set; }
    }
}
