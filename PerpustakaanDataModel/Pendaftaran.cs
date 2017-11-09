namespace PerpustakaanDataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pendaftaran")]
    public partial class Pendaftaran
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Key]
        [StringLength(10)]
        public string KodeKartu { get; set; }

        [Required]
        [StringLength(10)]
        public string KodePetugas { get; set; }

        public DateTime TglPembuatan { get; set; }

        public DateTime TglExpired { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime? Created { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }

        public DateTime? Modified { get; set; }

        public virtual Anggota Anggota { get; set; }

        public virtual Petugas Petugas { get; set; }
    }
}
