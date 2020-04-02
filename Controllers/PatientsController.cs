using PatientMgt.Services;
using PatientMgt.Models;
using Microsoft.AspNetCore.Mvc;

namespace PatientMgt.Controllers
{
    public class PatientsController : Controller
    {
        private readonly PatientService patientService;

        public PatientsController(PatientService patientService)
        {
            this.patientService = patientService;
        }

        public ActionResult Index()
        {
            return View(patientService.Get());
        }

        public ActionResult Inquiry(string pname)
        {
            if (pname == null)
            {
                return NotFound();
            }
            var inq = patientService.Inquiry(pname);
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
            var p = patientService.Get(id);
            if ( p == null)
            {
                return NotFound();
            }
            return View(p);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Patient p)
        {
            if(ModelState.IsValid)
            {
                patientService.Create(p);
                return RedirectToAction(nameof(Index));
            }
            return View(p);
        }

        public IActionResult Edit(string id)
        {
            if (id == null)
            {
                return NotFound();                
            }
            var p = patientService.Get(id);
            if (p == null)
            {
                return NotFound();
            }
            return View(p);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, Patient p)
        {
            if (id != p.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                patientService.Update(id, p);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(p);
            }
        }

        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var p = patientService.Get(id);
            if (p == null)
            {
                return NotFound();
            }
            return View(p);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            try
            {
                var p = patientService.Get(id);
                if (p == null)
                {
                    return NotFound();
                }
                patientService.Remove(p.Id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Charting(string id, Patient p)
        {
            return View(patientService.Charting(id));
        }

        // public IActionResult CreateCharting(string id)
        // {
        //     if(ModelState.IsValid)
        //     {
        //         patientService.Create(p);
        //         return RedirectToAction(nameof(Index));
        //     }
        //     return View(p);
        // }
    }
}