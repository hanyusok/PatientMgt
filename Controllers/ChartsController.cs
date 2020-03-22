using PatientMgt.Services;
using PatientMgt.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace PatientMgt.Controllers
{
    public class ChartsController : Controller
    {
        private readonly ChartService chartService;

        public ChartsController(ChartService chartService)
        {
            this.chartService = chartService;
        }

        public ActionResult Index()
        {
            return View(chartService.Get());
        }

        public ActionResult Inquiry(string ptName)
        {
            if (ptName == null)
            {
                return NotFound();
            }
            var inq = chartService.Inquiry(ptName);
            if (inq == null)
            {
                return NotFound();
            }
            return View(inq);      
        }

        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var c = chartService.Get(id);
            if ( c == null)
            {
                return NotFound();
            }
            return View(c);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Chart c)
        {
            if(ModelState.IsValid)
            {
                chartService.Create(c);
                return RedirectToAction(nameof(Index));
            }
            return View(c);
        }

        public IActionResult Edit(string id)
        {
            if (id == null)
            {
                return NotFound();                
            }
            var c = chartService.Get(id);
            if (c == null)
            {
                return NotFound();
            }
            return View(c);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, Chart c)
        {
            if (id != c.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                chartService.Update(id, c);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(c);
            }
        }

        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var c = chartService.Get(id);
            if (c == null)
            {
                return NotFound();
            }
            return View(c);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            try
            {
                var c = chartService.Get(id);
                if (c == null)
                {
                    return NotFound();
                }
                chartService.Remove(c.Id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}