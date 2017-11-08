using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerpusViewModel
{
    public class PendaftaranViewModel
    {
        public int Id { get; set; }

        public string KodeKartu { get; set; }

        public string KodePetugas { get; set; }

        public string KodeAnggota { get; set; }

        public DateTime TglPembuatan { get; set; }

        public DateTime TglExpired { get; set; }

        public bool StatusKembali { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? Created { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime? Modified { get; set; }
    }
}
