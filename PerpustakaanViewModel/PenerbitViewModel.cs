using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerpustakaanViewModel
{
    public class PenerbitViewModel
    {
        public int Id { get; set; }
        [DisplayName("Kode Penerbit")]
        public string KodePenerbit { get; set; }
        [DisplayName("Nama Penerbit")]
        public string NamaPenerbit { get; set; }
        [DisplayName("Nama Pengarang")]
        public string NamaPengarang { get; set; }
        [DisplayName("Alamat Penerbit")]
        public string AlamatPenerbit { get; set; }

        public string Telepon { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? Created { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime? Modified { get; set; }
    }
}
