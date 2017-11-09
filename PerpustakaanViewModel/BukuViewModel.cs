using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerpustakaanViewModel
{
    public class BukuViewModel
    {
        public int Id { get; set; }

        [DisplayName("Kode Buku")]
        public string KodeBuku { get; set; }

        [Required]
        public string Kategori { get; set; }

        [DisplayName("Kode Penerbit")]
        [Required]
        public string KodePenerbit { get; set; }

        [DisplayName("Judul Buku")]
        [Required]
        public string JudulBuku { get; set; }

        [DisplayName("Jumlah Buku")]
        public int jumlahBuku { get; set; }

        [Required]
        public string Pengarang { get; set; }

        [DisplayName("Tahun Penerbit")]
        public int TahunTerbit { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? Created { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime? Modified { get; set; }
    }
}
