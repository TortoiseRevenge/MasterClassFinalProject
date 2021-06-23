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

    }
}
