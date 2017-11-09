using PerpustakaanDataAccess;
using PerpustakaanViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Perpustakaan.Controllers
{
    public class PendaftaranController : Controller
    {
        // GET: Pendaftaran
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            return View(PendaftaranDataAccess.GetAll());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(PendaftaranViewModel model)
        {
            return CreateEdit(model);
        }

        public ActionResult Edit(int id)
        {
            return View(PendaftaranDataAccess.GetById(id));
        }

        [HttpPost]
        public ActionResult Edit(PendaftaranViewModel model)
        {
            return CreateEdit(model);
        }

        public ActionResult CreateEdit(PendaftaranViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (PendaftaranDataAccess.Update(model))
                    {
                        return Json(new { success = true, Message = "Success" }, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        return Json(new { success = false, Message = PendaftaranDataAccess.Message }, JsonRequestBehavior.AllowGet);
                    }
                }
                else
                {
                    return Json(new { success = false, Message = "Please Full Fill required Field" }, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                return Json(new { success = false, Message = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            return View(PendaftaranDataAccess.GetById(id));
        }

        [HttpPost]
        public ActionResult DeleteConfirm(int id)
        {
            if (PendaftaranDataAccess.Delete(id))
            {
                return Json(new { success = true, Message = "Success" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { success = false, Message = PendaftaranDataAccess.Message }, JsonRequestBehavior.AllowGet);
            }
            return Json(new { success = false, Message = "Error" }, JsonRequestBehavior.AllowGet);
        }
    }
}