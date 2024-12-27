using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmlakPortali1.Controllers
{
    public class IlanlarController : Controller
    {
        // GET: IlanlarController1
        public ActionResult Ilan()
        {
            return View();
        }

        // GET: IlanlarController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: IlanlarController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: IlanlarController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: IlanlarController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: IlanlarController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: IlanlarController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: IlanlarController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
