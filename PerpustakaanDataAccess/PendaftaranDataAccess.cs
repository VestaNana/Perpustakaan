using PerpustakaanDataModel;
using PerpusViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerpusDataAccess
{
    class PendaftaranDataAccess
    {
        public static string Message = string.Empty;

        public static List<PendaftaranViewModel> GetAll()
        {
            List<PendaftaranViewModel> result = new List<PendaftaranViewModel>();
            using (var db = new PerpusContext())
            {
                result = (from pdf in db.Pendaftaran
                          select new PendaftaranViewModel
                          {
                            Id = pdf.Id,
                            KodeKartu= pdf.KodeKartu,
                            KodePetugas=pdf.KodePetugas,
                            TglPembuatan=pdf.TglPembuatan,
                            TglExpired=pdf.TglExpired,
                            StatusKembali=pdf.StatusKembali
                          }).ToList();
            }
            return result;
        }

        public static bool Update(PendaftaranViewModel mod)
        {
            bool result = true;
            try
            {
                using (var db = new PerpusContext())
                {
                    if (mod.Id == 0)
                    {
                        Pendaftaran pdf = new Pendaftaran();
                            pdf.Id = mod.Id;
                            pdf.KodeKartu=mod.KodeKartu;
                            pdf.KodePetugas=mod.KodePetugas;
                            pdf.TglPembuatan=mod.TglPembuatan;
                            pdf.TglExpired=mod.TglExpired;
                            pdf.StatusKembali=mod.StatusKembali;
                            //pdf.CreatedBy="Admin";
                            //pdf.Created=DateTime.Now;
                            db.Pendaftaran.Add(pdf);
                            db.SaveChanges();
                    }
                    else
                    {
                        Pendaftaran pdf = db.Pendaftaran.Where(o => o.Id == mod.Id).FirstOrDefault();
                        if (pdf != null)
                        {
                            pdf.Id = mod.Id;
                            pdf.KodeKartu = mod.KodeKartu;
                            pdf.KodePetugas = mod.KodePetugas;
                            pdf.TglPembuatan = mod.TglPembuatan;
                            pdf.TglExpired = mod.TglExpired;
                            pdf.StatusKembali = mod.StatusKembali;
                            //pdf.ModifiedBy = "Admin";
                            //pdf.Modified =DateTime.Now;
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

        public static PendaftaranViewModel GetById(int id)
        {
            PendaftaranViewModel result = new PendaftaranViewModel();
            using(var db = new PerpusContext())
            {
                result = (from pdf in db.Pendaftaran
                          select new PendaftaranViewModel
                        {
                            Id = pdf.Id,
                            KodeKartu = pdf.KodeKartu,
                            KodePetugas = pdf.KodePetugas,
                            TglPembuatan = pdf.TglPembuatan,
                            TglExpired = pdf.TglExpired,
                            StatusKembali = pdf.StatusKembali
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
        //            Pendaftaran pdf = db.Pendaftaran.Where(o => o.Id == id).FirstOrDefault();
        //            if (pdf != null)
        //            {
        //                db.Pendaftaran.Remove(pdf);
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
