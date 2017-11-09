using PerpustakaanDataModel;
using PerpustakaanViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerpustakaanDataAccess
{
    public class PendaftaranDataAccess
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
                              KodeKartu = pdf.KodeKartu,
                              KodePetugas = pdf.KodePetugas,
                              TglPembuatan = pdf.TglPembuatan,
                              TglExpired = pdf.TglExpired,
                          }).ToList();
            }
            return result;
        }

        public static bool Update(PendaftaranViewModel model)
        {
            bool result = true;
            try
            {
                using (var db = new PerpusContext())
                {
                    if (model.Id == 0)
                    {
                        Pendaftaran pdf = new Pendaftaran();
                        pdf.Id = model.Id;
                        pdf.KodeKartu = model.KodeKartu;
                        pdf.KodePetugas = model.KodePetugas;
                        pdf.TglPembuatan = model.TglPembuatan;
                        pdf.TglExpired = model.TglExpired;
                        pdf.CreatedBy = "Admin";
                        pdf.Created = DateTime.Now;
                        db.Pendaftaran.Add(pdf);
                        db.SaveChanges();
                    }
                    else
                    {
                        Pendaftaran pdf = db.Pendaftaran.Where(o => o.Id == model.Id).FirstOrDefault();
                        if (pdf != null)
                        {
                            pdf.KodeKartu = model.KodeKartu;
                            pdf.KodePetugas = model.KodePetugas;
                            pdf.TglPembuatan = model.TglPembuatan;
                            pdf.TglExpired = model.TglExpired;
                            pdf.ModifiedBy = "Admin";
                            pdf.Modified = DateTime.Now;
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
            using (var db = new PerpusContext())
            {
                result = (from pdf in db.Pendaftaran
                          where pdf.Id==id
                          select new PendaftaranViewModel
                        {
                            Id = pdf.Id,
                            KodeKartu = pdf.KodeKartu,
                            KodePetugas = pdf.KodePetugas,
                            TglPembuatan = pdf.TglPembuatan,
                            TglExpired = pdf.TglExpired,
                        }).FirstOrDefault();
            }
            return result;
        }

        public static bool Delete(int id)
        {
            bool result = true;
            try
            {
                using (var db = new PerpusContext())
                {
                    Pendaftaran pdf = db.Pendaftaran.Where(o => o.Id == id).FirstOrDefault();
                    if (pdf != null)
                    {
                        db.Pendaftaran.Remove(pdf);
                        db.SaveChanges();
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
    }
}
