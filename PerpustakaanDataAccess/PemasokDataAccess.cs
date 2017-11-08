using PerpustakaanDataModel;
using PerpusViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerpusDataAccess
{
    public class PemasokDataAccess
    {
        public static string Message = string.Empty;

        public static List<PemasokViewModel> GetAll()
        {
            List<PemasokViewModel> result = new List<PemasokViewModel>();
            using (var db = new PerpusContext())
            {
                result = (from pms in db.Pemasok
                          select new PemasokViewModel
                          {
                                Id = pms.Id,
                                KodePemasok=pms.KodePemasok,
                                KodePembelian=pms.KodePembelian,
                                KodePenerbit=pms.KodePenerbit,
                                NamaPenerbit=pms.NamaPenerbit,
                                AlamatPemasok=pms.AlamatPemasok,
                                Telepon=pms.Telepon
                          }).ToList();
            }
            return result;
        }

        public static bool Update(PemasokViewModel mod)
        {
            bool result = true;
            try
            {
                using (var db = new PerpusContext())
                {
                    if (mod.Id == 0)
                    {
                        Pemasok pms = new Pemasok();
                            pms.Id=mod.Id;
                            pms.KodePemasok=mod.KodePemasok;
                            pms.KodePembelian=mod.KodePembelian;
                            pms.KodePenerbit=mod.KodePenerbit;
                            pms.NamaPenerbit=mod.NamaPenerbit;
                            pms.AlamatPemasok=mod.AlamatPemasok;
                            pms.Telepon=mod.Telepon;
                            //pms.CreatedBy="Admin";
                            //pms.Created=DateTime.Now;
                        db.Pemasok.Add(pms);
                        db.SaveChanges();
                    }
                    else
                    {
                        Pemasok pms = db.Pemasok.Where(o => o.Id == mod.Id).FirstOrDefault();
                        if (pms != null)
                        {
                            pms.Id = mod.Id;
                            pms.KodePemasok = mod.KodePemasok;
                            pms.KodePembelian = mod.KodePembelian;
                            pms.KodePenerbit = mod.KodePenerbit;
                            pms.NamaPenerbit = mod.NamaPenerbit;
                            pms.AlamatPemasok = mod.AlamatPemasok;
                            pms.Telepon = mod.Telepon;
                            //pms.ModifiedBy = "Admin";
                            //pms.Modified = DateTime.Now;
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

        public static PemasokViewModel GetById(int id)
        {
            PemasokViewModel result = new PemasokViewModel();
            using (var db = new PerpusContext())
            {
                result = (from pms in db.Pemasok
                          select new PemasokViewModel
                          {
                              Id = pms.Id,
                              KodePemasok = pms.KodePemasok,
                              KodePembelian = pms.KodePembelian,
                              KodePenerbit = pms.KodePenerbit,
                              NamaPenerbit = pms.NamaPenerbit,
                              AlamatPemasok = pms.AlamatPemasok,
                              Telepon = pms.Telepon
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
        //            Pemasok pms = db.Pemasok.Where(o => o.Id == id).FirstOrDefault();
        //            if (pms != null)
        //            {
        //                db.Pemasok.Remove(pms);
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
