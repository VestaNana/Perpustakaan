using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerpusViewModel
{
    public class PemasokViewModel
    {
        public int Id { get; set; }

        public string KodePemasok { get; set; }

        public string KodePembelian { get; set; }

        public string KodePenerbit { get; set; }

        public string NamaPenerbit { get; set; }

        public string AlamatPemasok { get; set; }

        public string Telepon { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? Created { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime? Modified { get; set; }
    }
}
