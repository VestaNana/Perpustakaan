using PerpustakaanDataModel;
using PerpusViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerpusDataAccess
{
    class PenerbitDataAccess
    {
        public static string Message = string.Empty;

        public static List<PenerbitViewModel> GetAll()
        {
            List<PenerbitViewModel> result = new List<PenerbitViewModel>();
            using (var db = new PerpusContext())
            {
                result = (from pnb in db.Penerbit
                          select new PenerbitViewModel
                          {
                              Id = pnb.Id,
                              KodePenerbit = pnb.KodePenerbit,
                              NamaPenerbit = pnb.NamaPenerbit,
                              NamaPengarang = pnb.NamaPengarang,
                              AlamatPenerbit = pnb.AlamatPenerbit    
                          }).ToList();
            }
            return result;
        }
       
        public static bool Update(PenerbitViewModel mod)
        {
            bool result = true;
            try
            {
                using(var db = new PerpusContext())
                {
                    if (mod.Id==0)
	                {
                        Penerbit pnb = new Penerbit();
                        pnb.Id = mod.Id;
                        pnb.KodePenerbit=mod.KodePenerbit;
                        pnb.NamaPenerbit=mod.NamaPenerbit;
                        pnb.NamaPengarang=mod.NamaPengarang;
                        pnb.AlamatPenerbit=mod.AlamatPenerbit;
                        pnb.Telepon=mod.Telepon;
                        //pnb.CreatedBy="Admin";
                        //pnb.Created=DateTime.Now;
                        db.Penerbit.Add(pnb);
                        db.SaveChanges();
	                }
                    else
                    {
                        Penerbit pnb = db.Penerbit.Where(o => o.Id == mod.Id).FirstOrDefault();
                        if (pnb != null)
                        {
                            pnb.Id = mod.Id;
                        pnb.KodePenerbit=mod.KodePenerbit;
                        pnb.NamaPenerbit=mod.NamaPenerbit;
                        pnb.NamaPengarang=mod.NamaPengarang;
                        pnb.AlamatPenerbit=mod.AlamatPenerbit;
                        pnb.Telepon=mod.Telepon;
                        //pnb.ModifiedBy="Admin";
                        //pnb.Modified = DateTime.Now;
                        db.SaveChanges();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Message = ex.Message;
                result = false;
            }
            return result;
        }

        public static PenerbitViewModel GetById(int id)
        {
            PenerbitViewModel result = new PenerbitViewModel();
            using(var db = new PerpusContext())
            {
                result = (from pnb in db.Penerbit
                          select new PenerbitViewModel
                        {
                            Id = pnb.Id,
                            KodePenerbit = pnb.KodePenerbit,
                            NamaPenerbit = pnb.NamaPenerbit,
                            NamaPengarang = pnb.NamaPengarang,
                            AlamatPenerbit = pnb.AlamatPenerbit
                        }).FirstOrDefault();
            }
            return result;
        }

        //public bool Delete(int id)
        //{
        //    bool result = true;
        //    try
        //    {
        //        using (var db = new PerpusContext())
        //        {
        //            Penerbit pnb = db.Penerbit.Where(o => o.Id == id).FirstOrDefault();
        //            if (pnb != null)
        //            {
        //                db.Penerbit.Remove(pnb);
        //                db.SaveChanges();
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Message = ex.Message;
        //        result = false;
        //    }
        //}
    }
}
