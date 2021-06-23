using CodeTheWay.Web.Ui.Models.ViewModels;
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

        public async Task<IActionResult> Create()
        {
            return View(new BarrelViewModel());
        }

        [HttpPost]

        public async Task<IActionResult> Register(BarrelViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Height > 0)
                {
                    if (model.Radius > 0)
                    {
                        if (model.Weight > 0)
                        {

                            Barrel barrel = new Barrel()
                            {
                                Id = model.Id,
                                Weight = model.Weight,
                                Radius = model.Radius,
                                Height = model.Height,
                                Contents = model.Contents,
                                Owner = model.Owner,
                                Sender = model.Sender,
                                Receiver = model.Receiver,
                                SpecialInstruction = model.SpecialInstruction,
                                isShipping = model.isShipping,
                                GetLatitude = model.GetLatitude,
                                GetLongitude = model.GetLongitude,
                            };
                            var result = await BarrelService.Create(barrel);
                            return RedirectToAction("Index");
                        }
                    }
                }

            }
            return View("Create", model);
        }
    }
}
