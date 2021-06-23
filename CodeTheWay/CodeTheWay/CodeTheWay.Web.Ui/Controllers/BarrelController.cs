using CodeTheWay.Web.Ui.Models;
using CodeTheWay.Web.Ui.Services;
using Microsoft.AspNetCore.Mvc;
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
        
    }
}
