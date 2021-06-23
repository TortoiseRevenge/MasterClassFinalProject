using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeTheWay.Web.Ui.Repositories;
using CodeTheWay.Web.Ui.Models;

namespace CodeTheWay.Web.Ui.Services
{
    public class BarrelService
    {
        private IBarrelRepository BarrelRepo;

        public BarrelService(AppDbContext dbContext)
        {
            this.BarrelRepo = new BarrelRepository(dbContext);
        }
    }
}
