using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AnjaliMISRepository;
using AnjaliMISViewModal;

namespace AnjaliMIS.Controllers
{
    public class LOC_CountryController : Controller
    {
        public static LOC_CountryRepository _LOC_CountryRepository = new LOC_CountryRepository();
        public ActionResult Index()
        {
            //return View(l.GetAll().ToList());
            List<LOC_CountryViewModal> LOC_Country = _LOC_CountryRepository.getallCountry();
            return View(LOC_Country);
        }
        //// GET: tbInsertMobiles/Edit/5
        //public ActionResult Edit(long id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    LOC_Country country = _lOC_Country.GetById(id);
        //    if (country == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(country);
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "MobileID,MobileName,MobileIMEno,mobileprice,mobileManufacured,CreatedDate")] LOC_Country country)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        //db.Entry(_lOC_Country).State = EntityState.Modified;
        //        _lOC_Country.Add(country);
        //        return RedirectToAction("Index");
        //    }
        //    return View(country);
        //}

    }
}
