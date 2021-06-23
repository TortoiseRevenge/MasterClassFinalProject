using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeTheWay.Web.Ui.Models;
using CodeTheWay.Web.Ui.Services;

namespace CodeTheWay.Web.Ui.Controllers
{
    public class BarrelController : Controller
    {

        private IBarrelService BarrelService;

        public BarrelController(IBarrelService barrelService)
        {
            this.BarrelService = barrelService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await BarrelService.GetBarrels());
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            var Barrel = await BarrelService.GetBarrel(id);
            return View(Barrel);
        }
        public async Task<IActionResult> Update(Barrel model) {
            if (ModelState.IsValid) {
                var Barrel = await BarrelService.Update(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }
        

    }
}
