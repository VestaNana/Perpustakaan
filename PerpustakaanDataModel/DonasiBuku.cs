namespace PerpustakaanDataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DonasiBuku")]
    public partial class DonasiBuku
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Key]
        [StringLength(10)]
        public string KodeDonasi { get; set; }

        [Required]
        [StringLength(10)]
        public string NamaPenerbit { get; set; }

        [Required]
        [StringLength(50)]
        public string NamaDonatur { get; set; }

        [Required]
        [StringLength(10)]
        public string KodePetugas { get; set; }

        [Required]
        [StringLength(50)]
        public string NamaPetugas { get; set; }

        public DateTime TglDonasi { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime? Created { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }

        public DateTime? Modified { get; set; }

        public virtual Petugas Petugas { get; set; }
    }
}
