using CodeTheWay.Web.Ui.Models;
using CodeTheWay.Web.Ui.Services;
using Microsoft.AspNetCore.Mvc;
﻿using CodeTheWay.Web.Ui.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeTheWay.Web.Ui.Models.ViewModels;

namespace CodeTheWay.Web.Ui.Controllers
{
    public class BarrelController : Controller
    {

        private IBarrelService BarrelService;

        public BarrelController(IBarrelService barrelService)
        {
            this.BarrelService = barrelService;
        }
        public async Task<IActionResult> Details(Guid id)
        {
            var result = await BarrelService.GetBarrel(id);
            BarrelViewModel barrel = new BarrelViewModel()
            {
                Id = id,
                Weight = result.Weight,
                Radius = result.Radius,
                Height = result.Height,
                Contents = result.Contents,
                Owner = result.Owner,
                Sender = result.Sender,
                Receiver = result.Receiver,
                GetLongitude = result.GetLongitude,
                GetLatitude = result.GetLatitude,
                SpecialInstruction = result.SpecialInstruction,
                isShipping = result.isShipping
            };
            return (View(barrel));
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

        public async Task<IActionResult> Delete(Guid id)
        {
            var barrel = await BarrelService.GetBarrel(id);
            await BarrelService.Delete(barrel);
            return RedirectToAction("Index");
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
