using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerpustakaanViewModel
{
    public class BukuViewModel
    {
        public int Id { get; set; }

        public string KodeBuku { get; set; }

        [Required]
        public string Kategori { get; set; }

        [Required]
        public string KodePenerbit { get; set; }

        [Required]
        public string JudulBuku { get; set; }

        public int jumlahBuku { get; set; }

        [Required]
        public string Pengarang { get; set; }

        public int TahunTerbit { get; set; }
    }
}
