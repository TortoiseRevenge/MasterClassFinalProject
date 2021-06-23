using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeTheWay.Web.Ui.Models.ViewModels
{
    public class BarrelViewModel
    {
        public Guid Id { get; set; }

        public double Weight { get; set; }
        public double Radius { get; set; }

        public double Height { get; set; }



        public string Contents { get; set; }

        public string Owner { get; set; }

        public string Sender { get; set; }
        public string Receiver { get; set; }

        public string SpecialInstruction { get; set; }
        public bool isShipping { get; set; }




        public double GetLongitude { get; set; }
        public double GetLatitude { get; set; }
    }
}
