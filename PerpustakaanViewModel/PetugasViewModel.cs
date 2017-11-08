using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerpustakaanViewModel
{
    public class PetugasViewModel
    {
        public int Id { get; set; }
        [DisplayName("Kode Petugas")]
        public string KodePetugas { get; set; }

        [Required]
        [DisplayName("Nama Petugas")]
        public string Nama { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? Created { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime? Modified { get; set; }
    }
}
